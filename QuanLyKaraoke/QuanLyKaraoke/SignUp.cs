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
    public partial class SignUp : Form
    {
        BUS_KH KhachHang;
        BUS_TK TaiKhoan;
        private string MaKH;
        public SignUp()
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            TaiKhoan = new BUS_TK(txtPW.Text, "");
            if (txtName.Text == "" || txtPhone.Text == "" || txtSex.Text == "" || txtUN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TaiKhoan.checkExistTenDN() == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng nhập tên đăng nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPW.Text != txtConfirmPW.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPW.Focus();
            }
            else
            {
                KhachHang = new BUS_KH("", "", "", txtPhone.Text, "", "", "");
                MaKH = KhachHang.searchMaKHBySDT();
                TaiKhoan = new BUS_TK(txtUN.Text, txtPW.Text);
                TaiKhoan.addQuery();
                if (MaKH == "")
                {
                    KhachHang = new BUS_KH(KhachHang.MaKhachHangTuDong(), txtUN.Text, txtName.Text, txtPhone.Text, txtEmail.Text, txtSex.Text, dtpDoB.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
                    KhachHang.addQuery();
                }
                else
                {
                    KhachHang = new BUS_KH(MaKH, txtUN.Text, txtName.Text, txtPhone.Text, txtEmail.Text, txtSex.Text, dtpDoB.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
                    KhachHang.updateQuery();
                }
                MessageBox.Show("Đăng ký tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login form1 = new Login();
                form1.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
        }
    }
}
