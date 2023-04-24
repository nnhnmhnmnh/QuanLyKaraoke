using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke
{
    public partial class Receptionist : Form
    {
        BUS_P Phong;
        BUS_HD HD;
        BUS_KH KhachHang;
        BUS_PTP PhieuThuePhong;
        BUS_CTHD CTHD;
        private string MaPhieuThuePhong = "";
        private string MaKH = "";
        private string MaHD = "";
        private string TrangThai = "";
        private int TongCTHD = 0;
        private DateTime TGThue;
        private DateTime TGTra;
        private int SoGioThue = 0;
        private int GiaTheoGio = 0;
        private List<string> phoneList;

        public Receptionist()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            Phong = new BUS_P("", "", "", "", "");
            cbSearchKP.DataSource = Phong.searchK();
            Load_PhongHat();
            Load_KhachHang();
            Load_PhieuThuePhong();
            cbSearchKP.SelectedIndex = -1;
            cbSearchVP.SelectedIndex = -1;
            cbSearchVP.Enabled = false;
            dtpLocTo.MinDate = dtpLocFrom.Value;
            phoneList = KhachHang.searchPhone();
            txtSDTKH.AutoCompleteCustomSource.AddRange(phoneList.ToArray());
            txtSDTKH.KeyDown += new KeyEventHandler(txtSDTKH_KeyDown);
            txtDTP_PTP_SDT.AutoCompleteCustomSource.AddRange(phoneList.ToArray());
            txtDTP_PTP_SDT.KeyDown += new KeyEventHandler(txtDTP_PTP_SDT_KeyDown);
            txtLXHD_PTP_SDT.AutoCompleteCustomSource.AddRange(phoneList.ToArray());
            txtLXHD_PTP_SDT.KeyDown += new KeyEventHandler(txtDTP_PTP_SDT_KeyDown);
        }

        private void btnDTP_Click(object sender, EventArgs e)
        {
            pnDTP.Visible = true;
            gbLXHD.Visible = false;
            gbQLKH.Visible = false;
            Load_PhongHat();
            Load_KhachHang();
            cbSearchKP.SelectedIndex = -1;
            cbSearchVP.SelectedIndex = -1;
            cbSearchVP.Enabled = false;
        }

        private void btnLHD_Click(object sender, EventArgs e)
        {
            pnDTP.Visible = false;
            gbLXHD.Visible = true;
            gbQLKH.Visible = false;
            Load_PhieuThuePhong_LXHD();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            ChangePW form9 = new ChangePW();
            form9.ShowDialog();
        }

        private void Load_PhongHat()
        {
            Phong = new BUS_P("", "", "", "", "");
            dgvDSPH.DataSource = Phong.selectQuery();
        }

        private void Load_KhachHang()
        {
            KhachHang = new BUS_KH("", "", "", "", "", "", "");
            dgvDSKH.DataSource = KhachHang.selectQuery();
        }

        private void Load_KhachHang_QLKH()
        {
            KhachHang = new BUS_KH("", "", "", "", "", "", "");
            dgvQLKH_DSKH.DataSource = KhachHang.selectQuery();
        }

        private void Load_PhieuThuePhong()
        {
            PhieuThuePhong = new BUS_PTP("", "", "", "", "");
            dgvDSPTP.DataSource = PhieuThuePhong.selectQuery();
        }

        private void Load_PhieuThuePhong_LXHD()
        {
            PhieuThuePhong = new BUS_PTP("", "", "", "", "");
            dgvDSPTP_LXHD.DataSource = PhieuThuePhong.selectQuery();
        }

        private void cbSearchKP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKP.Text;
            if (K != "")
            {
                cbSearchVP.DataSource = Phong.searchV(K);
            }
            else
            {
                cbSearchVP.DataSource = null;
            }
            cbSearchVP.SelectedIndex = -1;
            cbSearchVP.Enabled = true;
            Load_PhongHat();
        }

        private void cbSearchVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKP.Text;
            string V = cbSearchVP.Text;
            if (K != "" && V != "")
            {
                dgvDSPH.DataSource = Phong.searchQuery(K, V);
            }
        }

        private void btnAllP_Click(object sender, EventArgs e)
        {
            Load_PhongHat();
            cbSearchKP.SelectedIndex = -1;
            cbSearchVP.SelectedIndex = -1;
            cbSearchVP.Enabled = false;
        }

        private void dgvDSPH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSPH.Rows[e.RowIndex];
            PhieuThuePhong = new BUS_PTP("", "", row.Cells[0].Value.ToString(), "", "");
            if (PhieuThuePhong.checkGioThue(DateTime.Now) == true)
            {
                MessageBox.Show("Hiện tại phòng này đã được thuê, vui lòng chọn phòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtP.Text = row.Cells[0].Value.ToString();
                TrangThai = row.Cells[4].Value.ToString();
            }
            
        }

        private void txtSDTKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Handled)
            {
                string SDT = txtSDTKH.Text;
                if (!phoneList.Contains(SDT))
                {
                    if (SDT == "")
                    {
                        Load_KhachHang();
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Khách hàng có SDT này chưa có trong hệ thống, vui lòng thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Load_KhachHang_QLKH();
                        pnDTP.Visible = false;
                        gbLXHD.Visible = false;
                        gbQLKH.Visible = true;
                        cbSearchKKH.DataSource = KhachHang.searchK();
                        cbSearchKKH.SelectedIndex = -1;
                        cbSearchVKH.SelectedIndex = -1;
                        cbSearchVKH.Enabled = false;
                        txtQLKH_SDT.Text = txtSDTKH.Text;
                    }
                }
                else
                {
                    dgvDSKH.DataSource = KhachHang.searchQuery("SDT", SDT);
                }
            }
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSKH.Rows[e.RowIndex];
            txtKH.Text = row.Cells[0].Value.ToString();
            btnAddKH.Enabled = true;
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            if (txtP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MaPhieuThuePhong == "")
                {
                    PhieuThuePhong = new BUS_PTP("", txtKH.Text, "", "", "");
                    MaPhieuThuePhong = PhieuThuePhong.MaPhieuThePhongTuDong();
                }
                PhieuThuePhong = new BUS_PTP(MaPhieuThuePhong, txtKH.Text, txtP.Text, "", "");
                PhieuThuePhong.addQuery();
                MaKH = txtKH.Text;
                txtSDTKH.Clear();
                txtKH.Clear();
                MessageBox.Show("Thêm khách hàng vào phiếu thuê phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAddKH.Enabled = false;
                btnDatP.Enabled = true;
            }
        }

        private void btnDatP_Click(object sender, EventArgs e)
        {
            string ThoiGianThuePhong = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            PhieuThuePhong = new BUS_PTP(MaPhieuThuePhong, "", "", ThoiGianThuePhong, ThoiGianThuePhong);
            PhieuThuePhong.updateQueryThue();
            Load_PhieuThuePhong();
            TrangThai = (Convert.ToInt32(TrangThai) + 1).ToString();
            Phong = new BUS_P(txtP.Text, "", "", "", TrangThai);
            Phong.updateQuery();
            //txtP.Clear();
            btnAddKH.Enabled = false;
            HD = new BUS_HD("","", "", "", "");
            HD = new BUS_HD(HD.MaHDTuDong(), MaPhieuThuePhong, MaKH, "", "");
            MaPhieuThuePhong = "";
            MaKH = "";
            HD.addQuery();
            btnDatP.Enabled = false;
        }

        private void dgvDSPTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSPTP.Rows[e.RowIndex];
            MaPhieuThuePhong = row.Cells[0].Value.ToString();
            btnTraP.Enabled = true;
            btnHuyP.Enabled = true;
        }

        private void btnTraP_Click(object sender, EventArgs e)
        {
            string ThoiGianTraPhong = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            PhieuThuePhong = new BUS_PTP(MaPhieuThuePhong, "", "", "", ThoiGianTraPhong);
            PhieuThuePhong.updateQueryTra();
            Load_PhieuThuePhong();
            MaPhieuThuePhong = "";
            btnTraP.Enabled = false;
            btnHuyP.Enabled = false;
            TrangThai = (Convert.ToInt32(TrangThai) - 1).ToString();
            Phong = new BUS_P(txtP.Text, "", "", "", TrangThai);
            Phong.updateQuery();
        }

        private void btnHuyP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu đặt phòng không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PhieuThuePhong = new BUS_PTP(MaPhieuThuePhong, "", "", "", "");
                PhieuThuePhong.deleteQuery();
                Load_PhieuThuePhong();
                MaPhieuThuePhong = "";
                btnTraP.Enabled = false;
                btnHuyP.Enabled = false;
                TrangThai = (Convert.ToInt32(TrangThai) - 1).ToString();
                Phong = new BUS_P(txtP.Text, "", "", "", TrangThai);
                Phong.updateQuery();
            }
        }

        private void txtDTP_PTP_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Handled)
            {
                string SDT = txtDTP_PTP_SDT.Text;
                if (!phoneList.Contains(SDT))
                {
                    if (SDT == "")
                    {
                        Load_PhieuThuePhong();
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Khách hàng có SDT này chưa có phiếu đặt phòng trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DataTable dt = KhachHang.searchQuery("SDT", SDT);
                    PhieuThuePhong = new BUS_PTP("", dt.Rows[0]["Mã khách hàng"].ToString(), "", "", "");
                    dgvDSPTP.DataSource = PhieuThuePhong.searchMaKH();
                }
            }
        }

        private void txtLXHD_PTP_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Handled)
            {
                string SDT = txtLXHD_PTP_SDT.Text;
                if (!phoneList.Contains(SDT))
                {
                    if (SDT == "")
                    {
                        Load_PhieuThuePhong_LXHD();
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Khách hàng có SDT này chưa có phiếu đặt phòng trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DataTable dt = KhachHang.searchQuery("SDT", SDT);
                    PhieuThuePhong = new BUS_PTP("", dt.Rows[0]["Mã khách hàng"].ToString(), "", "", "");
                    dgvDSPTP_LXHD.DataSource = PhieuThuePhong.searchMaKH();
                }
            }
        }

        private void dgvDSPTP_LXHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSPTP_LXHD.Rows[e.RowIndex];
            MaKH = row.Cells[1].Value.ToString();
            DataTable dt = KhachHang.searchQuery("MaKhachHang", MaKH);
            MaPhieuThuePhong = row.Cells[0].Value.ToString();
            dtpLXHD_NgayLap.Value = DateTime.Now;
            btnLapHD.Enabled = true;
            btnXemIn.Enabled = true;
            txtLXHD_TenKH.Text = dt.Rows[0]["Họ tên"].ToString();
            HD = new BUS_HD("", MaPhieuThuePhong, "", "", "");
            MaHD = HD.searchMaHD();
            CTHD = new BUS_CTHD("", MaHD, "", "", "");
            TongCTHD = CTHD.searchTongCTHD();
            TGThue = Convert.ToDateTime(row.Cells[3].Value);
            TGTra = Convert.ToDateTime(row.Cells[4].Value);
            SoGioThue = (int)Math.Ceiling((TGTra - TGThue).TotalHours);
            Phong = new BUS_P(row.Cells[2].Value.ToString(), "", "", "", "");
            GiaTheoGio = Phong.searchGiaTheoGio();
            if (SoGioThue * GiaTheoGio + TongCTHD > 0)
            {
                nudLXHD_GiamGia.Maximum = SoGioThue * GiaTheoGio + TongCTHD;
                txtLXHD_TongTien.Text = (SoGioThue * GiaTheoGio + TongCTHD - nudLXHD_GiamGia.Value).ToString();
            }
            else
            {
                txtLXHD_TongTien.Text = "0";
            }
        }

        private void nudLXHD_GiamGia_ValueChanged(object sender, EventArgs e)
        {
            txtLXHD_TongTien.Text = (SoGioThue * GiaTheoGio + TongCTHD - nudLXHD_GiamGia.Value).ToString();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            HD = new BUS_HD(MaHD, MaPhieuThuePhong, MaKH, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"), txtLXHD_TongTien.Text);
            HD.updateQuery();
            MessageBox.Show("Lập hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLapHD.Enabled = false;
            btnXemIn.Enabled = false;
        }

        private void btnXemIn_Click(object sender, EventArgs e)
        {
            Print f = new Print();
            f.Show();
            HD = new BUS_HD("hd20230420222552", "", "", "", "");
            CrystalReport1 cr1 = new CrystalReport1();

            TextObject TongGioThue = (TextObject)cr1.ReportDefinition.Sections["Section2"].ReportObjects["TongGioThue"];
            TongGioThue.Text = SoGioThue.ToString();

            TextObject TienPhong = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["TienPhong"];
            TienPhong.Text = (SoGioThue * GiaTheoGio).ToString();

            TextObject Giam = (TextObject)cr1.ReportDefinition.Sections["Section4"].ReportObjects["Giam"];
            Giam.Text = nudLXHD_GiamGia.Text;

            DataTable dt = HD.searchByMaHD();
            cr1.SetDataSource(dt);
            f.crystalReportViewer1.ReportSource = cr1;
            f.crystalReportViewer1.Refresh();
            btnLapHD.Enabled = false;
            btnXemIn.Enabled = false;
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            Load_KhachHang_QLKH();
            pnDTP.Visible = false;
            gbLXHD.Visible = false;
            gbQLKH.Visible = true;
            cbSearchKKH.DataSource = KhachHang.searchK();
            cbSearchKKH.SelectedIndex = -1;
            cbSearchVKH.SelectedIndex = -1;
            cbSearchVKH.Enabled = false;
        }

        private void cbSearchKKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKKH.Text;
            if (K != "")
            {
                cbSearchVKH.DataSource = KhachHang.searchV(K);
            }
            else
            {
                cbSearchVKH.DataSource = null;
            }
            cbSearchVKH.SelectedIndex = -1;
            cbSearchVKH.Enabled = true;
            Load_KhachHang_QLKH();
        }

        private void cbSearchVKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKKH.Text;
            string V = cbSearchVKH.Text;
            if (K != "" && V != "")
            {
                V = KhachHang.convertDateTime(V);
                dgvQLKH_DSKH.DataSource = KhachHang.searchQuery(K, V);
            }
        }

        private void btnAllKH_Click(object sender, EventArgs e)
        {
            Load_KhachHang_QLKH();
            cbSearchKKH.SelectedIndex = -1;
            cbSearchVKH.SelectedIndex = -1;
            cbSearchVKH.Enabled = false;
        }

        private void ClearTextbox_KhachHang()
        {
            txtQLKH_Ten.Clear();
            txtQLKH_SDT.Clear();
            cbQLKH_Gioi.SelectedIndex = -1;
            txtQLKH_Email.Clear();
        }

        private void btnQLKH_Add_Click(object sender, EventArgs e)
        {
            if (txtQLKH_Ten.Text == "" || txtQLKH_SDT.Text == "" || cbQLKH_Gioi.Text == "" || txtQLKH_Email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachHang = new BUS_KH(KhachHang.MaKhachHangTuDong(), "", txtQLKH_Ten.Text, txtQLKH_SDT.Text, txtQLKH_Email.Text, cbQLKH_Gioi.Text, KhachHang.convertDate(dtpQLKH_NS.Text));
                KhachHang.addQuery();
                ClearTextbox_KhachHang();
                Load_KhachHang();
            }
        }

        private void btnQLKH_Edit_Click(object sender, EventArgs e)
        {
            if (txtQLKH_Ten.Text == "" || txtQLKH_SDT.Text == "" || cbQLKH_Gioi.Text == "" || txtQLKH_Email.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachHang = new BUS_KH(MaKH, "", txtQLKH_Ten.Text, txtQLKH_SDT.Text, txtQLKH_Email.Text, cbQLKH_Gioi.Text, KhachHang.convertDate(dtpQLKH_NS.Text));
                KhachHang.updateQuery();
                ClearTextbox_KhachHang();
                Load_KhachHang();
            }
        }

        private void dgvQLKH_DSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvQLKH_DSKH.Rows[e.RowIndex];
            MaKH = row.Cells[0].Value.ToString();
            txtQLKH_Ten.Text = row.Cells[2].Value.ToString();
            txtQLKH_SDT.Text = row.Cells[3].Value.ToString();
            txtQLKH_Email.Text = row.Cells[4].Value.ToString();
            cbQLKH_Gioi.Text = row.Cells[5].Value.ToString();
            dtpQLKH_NS.Text = row.Cells[6].Value.ToString();
        }

        private void btnQLKH_Del_Click(object sender, EventArgs e)
        {
            if (MaKH == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    KhachHang = new BUS_KH(MaKH, "", txtQLKH_Ten.Text, txtQLKH_SDT.Text, txtQLKH_Email.Text, cbQLKH_Gioi.Text, KhachHang.convertDate(dtpQLKH_NS.Text));
                    KhachHang.deleteQuery();
                    ClearTextbox_KhachHang();
                    Load_KhachHang();
                    MaKH = "";
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            PhieuThuePhong = new BUS_PTP("", "", "", "", "");
            List<string> MaP = PhieuThuePhong.selectPhongDaDat(dtpLocFrom.Value, dtpLocTo.Value);
            Phong = new BUS_P("", "", "", "", "");
            dgvDSPH.DataSource = Phong.searchByMaPhong(MaP);
        }

        private void dtpLocFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpLocTo.MinDate = dtpLocFrom.Value;
        }
    }
}
