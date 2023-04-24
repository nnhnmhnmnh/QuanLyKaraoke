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
    public partial class Customer : Form
    {
        BUS_PTP PhieuThuePhong;
        BUS_KH KhachHang;
        BUS_P Phong;
        private string MaPhieu;
        private string MaKH;
        private string TrangThai;

        public Customer()
        {
            InitializeComponent();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            ChangePW form9 = new ChangePW();
            form9.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đặt phòng không?", "Xác nhận đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PhieuThuePhong = new BUS_PTP("", "", txtMaPhong.Text, "", "");
                if (PhieuThuePhong.checkKhungGio(dtpThue.Value, dtpTra.Value) == true)
                {
                    MessageBox.Show("Khung giờ này đã hết chỗ, vui lòng chọn khung giờ hoặc phòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MaPhieu = PhieuThuePhong.MaPhieuThePhongTuDong();
                    KhachHang = new BUS_KH("", Login.TenDangNhap, "", "", "", "", "");
                    MaKH = KhachHang.searchMaKHByUN();
                    PhieuThuePhong = new BUS_PTP(MaPhieu, MaKH, txtMaPhong.Text, dtpThue.Value.ToString("yyyy-MM-ddTHH:mm:ss"), dtpTra.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
                    PhieuThuePhong.addQuery();
                    Phong = new BUS_P(txtMaPhong.Text, "", "", "", "");
                    TrangThai = Phong.searchTrangThai();
                    TrangThai = (Convert.ToInt32(TrangThai) + 1).ToString();
                    Phong = new BUS_P(txtMaPhong.Text, "", "", "", TrangThai);
                    Phong.updateQuery();
                    MessageBox.Show("Đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvDSPH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSPH.Rows[e.RowIndex];
            txtMaPhong.Text = row.Cells[0].Value.ToString();
            txtGiaTheoGio.Text = row.Cells[3].Value.ToString();
        }

        private void Load_PhongHat()
        {
            Phong = new BUS_P("", "", "", "", "");
            dgvDSPH.DataSource = Phong.selectQuery();
        }

        private void Load_PhieuThuePhong()
        {
            KhachHang = new BUS_KH("", Login.TenDangNhap, "", "", "", "", "");
            MaKH = KhachHang.searchMaKHByUN();
            PhieuThuePhong = new BUS_PTP("", MaKH, "", "", "");
            dgvLS_DSPTP.DataSource = PhieuThuePhong.selectQueryByKH();
        }

        private void Load_ThongTinCaNhan()
        {
            KhachHang = new BUS_KH("", "", "", "", "", "", "");
            DataTable dt = KhachHang.searchQuery("TenDangNhap", Login.TenDangNhap);
            txtTTCN_MaKH.Text = (dt.Rows[0]["Mã khách hàng"]).ToString();
            txtTTCN_Ten.Text = (dt.Rows[0]["Họ tên"]).ToString();
            txtTTCN_UN.Text = (dt.Rows[0]["Tên đăng nhập"]).ToString();
            txtTTCN_SDT.Text = (dt.Rows[0]["SDT"]).ToString();
            txtTTCN_Email.Text = (dt.Rows[0]["Email"]).ToString();
            cbTTCN_Gioi.Text = (dt.Rows[0]["Giới tính"]).ToString();
            dtpTTCN_NS.Text = (dt.Rows[0]["Ngày sinh"]).ToString();
        }

        private void btnDatPhongHat_Click(object sender, EventArgs e)
        {
            pnDatPhongHat.Visible = true;
            gbLichSu.Visible = false;
            gbTTCN.Visible = false;
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Load_PhieuThuePhong();
            gbLichSu.Visible = true;
            pnDatPhongHat.Visible = false;
            gbTTCN.Visible = false;
        }

        private void btnTTCaNhan_Click(object sender, EventArgs e)
        {
            Load_ThongTinCaNhan();
            gbTTCN.Visible = true;
            gbLichSu.Visible = false;
            pnDatPhongHat.Visible = false;
        }

        private void btnTTCN_Edit_Click(object sender, EventArgs e)
        {
            txtTTCN_Ten.Enabled = true;
            txtTTCN_SDT.Enabled = true;
            txtTTCN_Email.Enabled = true;
            cbTTCN_Gioi.Enabled = true;
            dtpTTCN_NS.Enabled = true;
        }

        private void btnTTCN_Save_Click(object sender, EventArgs e)
        {
            KhachHang = new BUS_KH(txtTTCN_MaKH.Text, txtTTCN_UN.Text, txtTTCN_Ten.Text, txtTTCN_SDT.Text, txtTTCN_Email.Text, cbTTCN_Gioi.Text, dtpTTCN_NS.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
            KhachHang.updateQuery();
            MessageBox.Show("Sửa thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Load_PhongHat();
            dtpThue.MinDate = DateTime.Now;
            dtpLocTo.MinDate = dtpLocFrom.Value;
        }

        private void dtpThue_ValueChanged(object sender, EventArgs e)
        {
            dtpTra.MinDate = dtpThue.Value;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Load_PhongHat();
        }

        private void dtpLocFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpLocTo.MinDate = dtpLocFrom.Value;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            PhieuThuePhong = new BUS_PTP("", "", "", "", "");
            List<string> MaP = PhieuThuePhong.selectPhongDaDat(dtpLocFrom.Value, dtpLocTo.Value);
            Phong = new BUS_P("", "", "", "", "");
            dgvDSPH.DataSource = Phong.searchByMaPhong(MaP);
        }
    }
}
