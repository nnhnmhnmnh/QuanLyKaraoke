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
    public partial class Login : Form
    {
        BUS_TK TaiKhoan;
        public static string TenDangNhap;

        public Login()
        {
            InitializeComponent();
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp form2 = new SignUp();
            form2.ShowDialog();
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            TenDangNhap = txtUN.Text.Trim();
            string MatKhau = txtPW.Text.Trim();
            TaiKhoan = new BUS_TK(TenDangNhap, MatKhau);
            switch (TaiKhoan.checkLogin(TenDangNhap, MatKhau))
            {
                case "Admin":
                    Manager form7 = new Manager();
                    this.Hide();
                    form7.ShowDialog();
                    break;
                case "Tiếp tân":
                    Receptionist form8 = new Receptionist();
                    this.Hide();
                    form8.ShowDialog();
                    break;
                case "Quản lý kho":
                    InventoryManager fqlk = new InventoryManager();
                    this.Hide();
                    fqlk.ShowDialog();
                    break;
                case "Phục vụ":
                    Staff fpv = new Staff();
                    this.Hide();
                    fpv.ShowDialog();
                    break;
                case "Successful":
                    Customer fc = new Customer();
                    this.Hide();
                    fc.ShowDialog();
                    break;
                case "Fail":
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo");
                    break;
                case "null UN":
                    MessageBox.Show("Vui lòng nhập Tên đăng nhập.", "Thông báo");
                    txtUN.Focus();
                    break;
                case "null PW":
                    MessageBox.Show("Vui lòng nhập Mật khẩu.", "Thông báo");
                    txtPW.Focus();
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
