using BUS;
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
    public partial class Staff : Form
    {
        BUS_DV DichVu;
        BUS_CTHD CTHD;
        BUS_HD HD;
        BUS_PTP PhieuThuePhong;
        private string MaDV = "";
        private string MaCTHD = "";
        private string MaHD = "";
        private string MaKH = "";
        private string MaPTP = "";
        private int SLBanDauSSL = 0;
        private int SLChenhLechSSL = 0;
        private int TonKho = 0;
        private int DonGia = 0;
        private int ThanhTien = 0;

        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Load_DichVu();
            Load_PhieuThuePhong();
            Load_CTHD();
            cbSearchKDV.DataSource = DichVu.searchK();
            cbSearchKDV.SelectedIndex = -1;
            cbSearchVDV.Enabled = false;
        }

        private void Load_DichVu()
        {
            DichVu = new BUS_DV("", "", "", "", "");
            dgvDSDV.DataSource = DichVu.selectQuery();
        }

        private void Load_PhieuThuePhong()
        {
            PhieuThuePhong = new BUS_PTP("", "", "", "", "");
            dgvDSPTP.DataSource = PhieuThuePhong.selectQuery();
        }

        private void Load_CTHD()
        {
            CTHD = new BUS_CTHD("", MaHD, "", "", "");
            dgvCTHD.DataSource = CTHD.selectQuery();
        }

        private void cbSearchDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKDV.Text;
            if (K != "")
            {
                cbSearchVDV.DataSource = DichVu.searchV(K);
            }
            else
            {
                cbSearchVDV.DataSource = null;
            }
            cbSearchVDV.SelectedIndex = -1;
            cbSearchVDV.Enabled = true;
            Load_DichVu();
        }

        private void cbSearchVDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKDV.Text;
            string V = cbSearchVDV.Text;
            if (K != "" && V != "")
            {
                dgvDSDV.DataSource = DichVu.searchQuery(K, V);
            }
        }

        private void dgvDSDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSDV.Rows[e.RowIndex];
            MaDV = row.Cells[0].Value.ToString();
            txtTenDV.Text = row.Cells[2].Value.ToString();
            DonGia = Convert.ToInt32(row.Cells[3].Value);
            nudCSL.Maximum = Convert.ToInt32(row.Cells[4].Value);
            TonKho = Convert.ToInt32(row.Cells[4].Value);
            nudCSL.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HD = new BUS_HD("", MaPTP, MaKH, "", "");
            MaHD = HD.searchMaHD(); //////////// kiếm mã HD
            CTHD = new BUS_CTHD("", MaHD, MaDV, "", "");
            if (CTHD.checkExistMaDV() == true)
            {
                MessageBox.Show("Dịch vụ này đã được thêm, vui lòng chọn dịch vụ khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nudCSL.Text == "0")
            {
                MessageBox.Show("Vui lòng chọn số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CTHD = new BUS_CTHD("", MaHD, MaDV, nudCSL.Text, "");
                MaCTHD = CTHD.MaCTHDTuDong();
                ThanhTien = DonGia * Convert.ToInt32(nudCSL.Text);

                CTHD = new BUS_CTHD(MaCTHD, MaHD, MaDV, nudCSL.Text, ThanhTien.ToString());
                CTHD.addQuery();
                Load_CTHD();
                nudCSL.Enabled = false;
                btnAdd.Enabled = false;

                DichVu = new BUS_DV(MaDV, "", "", "", Convert.ToInt32(TonKho - Convert.ToInt32(nudCSL.Text)).ToString());
                DichVu.updateSLTK();
                Load_DichVu();
            }
        }

        private void dgvDSPTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSPTP.Rows[e.RowIndex];
            txtMaPTP.Text = row.Cells[0].Value.ToString();
            MaPTP = row.Cells[0].Value.ToString();
            MaKH = row.Cells[1].Value.ToString();
            HD = new BUS_HD("", MaPTP, MaKH, "", "");
            MaHD = HD.searchMaHD(); //////////// kiếm mã HD------chọn phiếu đặt phòng mới thì có mã hóa đơn mới
            Load_CTHD();
            gbDSDV.Enabled = true;
            gbCTHD.Enabled = true;
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvCTHD.Rows[e.RowIndex];
            MaCTHD = row.Cells[0].Value.ToString();
            MaDV = row.Cells[2].Value.ToString();
            nudSSL.Text = row.Cells[3].Value.ToString();
            SLBanDauSSL = Convert.ToInt32(row.Cells[3].Value);
            btnEdit.Enabled = true;
            btnDel.Enabled = true;

            DichVu = new BUS_DV(MaDV, "", "", "", "");
            TonKho = DichVu.searchSLTK();
            nudSSL.Maximum = SLBanDauSSL + TonKho;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DichVu = new BUS_DV(MaDV, "", "", "", "");
            DonGia = DichVu.searchDonGia();
            TonKho = DichVu.searchSLTK();
            SLChenhLechSSL = SLBanDauSSL - Convert.ToInt32(nudSSL.Text);
            DichVu = new BUS_DV(MaDV, "", "", "", (TonKho + SLChenhLechSSL).ToString());
            DichVu.updateSLTK();
            CTHD = new BUS_CTHD(MaCTHD, "", "", nudSSL.Text, (Convert.ToInt32(nudSSL.Text)*DonGia).ToString());
            CTHD.updateSL();
            nudSSL.Text = "0";
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            Load_DichVu();
            Load_CTHD();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            CTHD = new BUS_CTHD(MaCTHD, "", "", "", "");
            CTHD.deleteQuery();

            DichVu = new BUS_DV("", "", "", "", "");
            TonKho = DichVu.searchSLTK();
            DichVu = new BUS_DV(MaDV, "", "", "", (TonKho+Convert.ToInt32(nudSSL.Text)).ToString());
            DichVu.updateSLTK();

            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            Load_DichVu();
            Load_CTHD();
            nudSSL.Text = "0";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Load_CTHD();
        }

        private void btnAllDV_Click(object sender, EventArgs e)
        {
            Load_DichVu();
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
    }
}
