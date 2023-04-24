using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke
{
    public partial class ChangePW : Form
    {
        BUS_TK TaiKhoan;

        public ChangePW()
        {
            InitializeComponent();
        }

        private void chkbShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbShowPW.Checked)
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void chkbShowNPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbShowNPW.Checked)
            {
                txtNPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtNPW.UseSystemPasswordChar = true;
            }
        }
        private void chkbShowPWC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbShowPWC.Checked)
            {
                txtConfirmPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPW.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string TenDN = txtUN.Text;
            string MK = txtPW.Text;
            string MKMoi = txtNPW.Text;
            string XacNhanMK = txtConfirmPW.Text;
            TaiKhoan = new BUS_TK(TenDN, MK);
            switch (TaiKhoan.updateQuery(TenDN, MK, MKMoi, XacNhanMK))
            {
                case "null":
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
                    break;
                case "Fail":
                    MessageBox.Show("Mật khẩu không chính xác.", "Thông báo");
                    txtPW.Focus();
                    break;
                case "Duplicate":
                    MessageBox.Show("Mật khẩu mới trùng với mật khẩu hiện tại.", "Thông báo");
                    txtNPW.Focus();
                    break;
                case "Wrong confirm":
                    MessageBox.Show("Xác nhận mật khẩu không khớp.", "Thông báo");
                    txtConfirmPW.Focus();
                    break;
                case "Successful":
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
                    this.Hide();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            txtUN.Text = Login.TenDangNhap;
            txtPW.Focus();
        }
    }
}
