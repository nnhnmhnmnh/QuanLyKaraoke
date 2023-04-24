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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKaraoke
{
    public partial class Manager : Form
    {
        BUS_P Phong;
        BUS_NV NhanVien;
        BUS_KH KhachHang;
        private string MaPhong;
        private string TrangThai;
        private string MaNhanVien;
        private string MaKhachHang;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            Phong = new BUS_P("", "", "", "", "");
            cbSearchK.DataSource = Phong.searchK();
            cbSearchK.SelectedIndex = -1;
            cbSearchV.Enabled = false;
            Load_PhongHat();
            //cbSearchV.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbSearchV.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cbSearchK.DisplayMember = "ToString";
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            Load_NhanVien();
            gbQLNV.Visible = true;
            gbQLPH.Visible = false;
            gbQLKH.Visible = false;
            cbSearchKNV.DataSource = NhanVien.searchK();
            cbSearchKNV.SelectedIndex = -1;
            cbSearchVNV.SelectedIndex = -1;
            cbSearchVNV.Enabled = false;
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            Load_KhachHang();
            gbQLKH.Visible = true;
            gbQLPH.Visible = false;
            gbQLNV.Visible = false;
            cbSearchKKH.DataSource = KhachHang.searchK();
            cbSearchKKH.SelectedIndex = -1;
            cbSearchVKH.SelectedIndex = -1;
            cbSearchVKH.Enabled = false;
        }

        private void btnQLPH_Click(object sender, EventArgs e)
        {
            Load_PhongHat();
            gbQLPH.Visible = true;
            gbQLNV.Visible = false;
            gbQLKH.Visible = false;
            cbSearchK.SelectedIndex = -1;
            cbSearchV.SelectedIndex = -1;
            cbSearchV.Enabled = false;
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
            //dgvDSPH.Columns[0].HeaderCell.Value = "Mã phòng";
            //dgvDSPH.Columns[1].HeaderCell.Value = "Loại phòng";
            //dgvDSPH.Columns[2].HeaderCell.Value = "Số người tối đa";
            //dgvDSPH.Columns[3].HeaderCell.Value = "Giá theo giờ";
            //dgvDSPH.Columns[4].HeaderCell.Value = "Trạng thái";
        }

        private void Load_NhanVien()
        {
            NhanVien = new BUS_NV("", "", "", "", "", "", "", "", "", "");
            dgvDSNV.DataSource = NhanVien.selectQuery();
            dgvDSNV.Columns["Tên đăng nhập"].Visible = false;
            dgvDSNV.Columns["SDT"].Visible = false;
            dgvDSNV.Columns["Email"].Visible = false;
            dgvDSNV.Columns["CCCD"].Visible = false;
            dgvDSNV.Columns["Địa chỉ"].Visible = false;
        }

        private void Load_KhachHang()
        {
            KhachHang = new BUS_KH("", "", "", "", "", "", "");
            dgvDSKH.DataSource = KhachHang.selectQuery();
        }

        private void ClearTextbox_PhongHat()
        {
            txtType.Clear();
            txtMax.Clear();
            txtPrice.Clear();
        }

        private void ClearTextbox_NhanVien()
        {
            cbDNNV.SelectedIndex = -1;
            txtNameNV.Clear();
            txtSDTNV.Clear();
            txtSexNV.SelectedIndex = -1;
            txtEmailNV.Clear();
            txtCCCDNV.Clear();
            txtDCNV.Clear();
            txtCVNV.Clear();
        }

        private void ClearTextbox_KhachHang()
        {
            txtNameKH.Clear();
            txtDNKH.Clear();
            txtSDTKH.Clear();
            cbSexKH.SelectedIndex = -1;
            txtEmailKH.Clear();
        }

        private void dgvDSPH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSPH.Rows[e.RowIndex];
            MaPhong = row.Cells[0].Value.ToString();
            txtType.Text = row.Cells[1].Value.ToString();
            txtMax.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
            TrangThai = row.Cells[4].Value.ToString();
            //cbState.SelectedIndex = cbState.FindString(row.Cells[4].Value.ToString());
            //txtPrice.Value = DateTime.ParseExact(row.Cells[2].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSNV.Rows[e.RowIndex];
            MaNhanVien = row.Cells[0].Value.ToString();
            cbDNNV.Text = row.Cells[1].Value.ToString();
            txtNameNV.Text = row.Cells[2].Value.ToString();
            txtCCCDNV.Text = row.Cells[3].Value.ToString();
            txtSDTNV.Text = row.Cells[4].Value.ToString();
            txtEmailNV.Text = row.Cells[5].Value.ToString();
            txtDCNV.Text = row.Cells[6].Value.ToString();
            txtSexNV.Text = row.Cells[7].Value.ToString();
            dtpNSNV.Text = row.Cells[8].Value.ToString();
            txtCVNV.Text = row.Cells[9].Value.ToString();
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSKH.Rows[e.RowIndex];
            MaKhachHang = row.Cells[0].Value.ToString();
            txtDNKH.Text = row.Cells[1].Value.ToString();
            txtNameKH.Text = row.Cells[2].Value.ToString();
            txtSDTKH.Text = row.Cells[3].Value.ToString();
            txtEmailKH.Text = row.Cells[4].Value.ToString();
            cbSexKH.Text = row.Cells[5].Value.ToString();
            dtpNSKH.Text = row.Cells[6].Value.ToString();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "" || txtMax.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Phong = new BUS_P(Phong.MaPhongTuDong(), txtType.Text, txtMax.Text, txtPrice.Text, "0");
                Phong.addQuery();
                ClearTextbox_PhongHat();
                Load_PhongHat();
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (cbDNNV.Text == "" || txtNameNV.Text == "" || txtSDTNV.Text == "" || txtSexNV.Text == "" || txtEmailNV.Text == "" || txtCCCDNV.Text == "" || txtDCNV.Text == "" || txtCVNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NhanVien = new BUS_NV(NhanVien.MaNhanVienTuDong(), cbDNNV.Text, txtNameNV.Text, txtCCCDNV.Text, txtSDTNV.Text, txtEmailNV.Text, txtDCNV.Text, txtSexNV.Text, NhanVien.convertDate(dtpNSNV.Text), txtCVNV.Text);
                NhanVien.addQuery();
                ClearTextbox_NhanVien();
                Load_NhanVien();
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            if (txtDNKH.Text == "" || txtNameKH.Text == "" || txtSDTKH.Text == "" || cbSexKH.Text == "" || txtEmailKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachHang = new BUS_KH(KhachHang.MaKhachHangTuDong(), txtDNKH.Text, txtNameKH.Text, txtSDTKH.Text, txtEmailKH.Text, cbSexKH.Text, KhachHang.convertDate(dtpNSKH.Text));
                KhachHang.addQuery();
                ClearTextbox_KhachHang();
                Load_KhachHang();
            }
        }

        private void btnEditP_Click(object sender, EventArgs e)
        {
            if (MaPhong == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Phong = new BUS_P(MaPhong, txtType.Text, txtMax.Text, txtPrice.Text, TrangThai);
                Phong.updateQuery();
                ClearTextbox_PhongHat();
                Load_PhongHat();
                MaPhong = "";
            }
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            if (MaNhanVien == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NhanVien = new BUS_NV(MaNhanVien, cbDNNV.Text, txtNameNV.Text, txtCCCDNV.Text, txtSDTNV.Text, txtEmailNV.Text, txtDCNV.Text, txtSexNV.Text, NhanVien.convertDate(dtpNSNV.Text), txtCVNV.Text);
                NhanVien.updateQuery();
                ClearTextbox_NhanVien();
                Load_NhanVien();
                MaNhanVien = "";
            }
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            if (MaKhachHang == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KhachHang = new BUS_KH(MaKhachHang, txtDNKH.Text, txtNameKH.Text, txtSDTKH.Text, txtEmailKH.Text, cbSexKH.Text, KhachHang.convertDate(dtpNSKH.Text));
                KhachHang.updateQuery();
                ClearTextbox_KhachHang();
                Load_KhachHang();
                MaKhachHang = "";
            }
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            if (MaPhong == "")
            {
                MessageBox.Show("Vui lòng chọn phòng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Phong = new BUS_P(MaPhong, txtType.Text, txtMax.Text, txtPrice.Text, TrangThai);
                    Phong.deleteQuery();
                    ClearTextbox_PhongHat();
                    Load_PhongHat();
                    MaPhong = "";
                }
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            if (MaNhanVien == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NhanVien = new BUS_NV(MaNhanVien, cbDNNV.Text, txtNameNV.Text, txtCCCDNV.Text, txtSDTNV.Text, txtEmailNV.Text, txtDCNV.Text, txtSexNV.Text, NhanVien.convertDate(dtpNSNV.Text), txtCVNV.Text);
                    NhanVien.deleteQuery();
                    ClearTextbox_NhanVien();
                    Load_NhanVien();
                    MaNhanVien = "";
                }
            }
        }

        private void btnDelKH_Click(object sender, EventArgs e)
        {
            if (MaKhachHang == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    KhachHang = new BUS_KH(MaKhachHang, txtDNKH.Text, txtNameKH.Text, txtSDTKH.Text, txtEmailKH.Text, cbSexKH.Text, KhachHang.convertDate(dtpNSKH.Text));
                    KhachHang.deleteQuery();
                    ClearTextbox_KhachHang();
                    Load_KhachHang();
                    MaKhachHang = "";
                }
            }
        }

        private void btnAllP_Click(object sender, EventArgs e)
        {
            Load_PhongHat();
            cbSearchK.SelectedIndex = -1;
            cbSearchV.SelectedIndex = -1;
            cbSearchV.Enabled = false;
        }

        private void btnAllNV_Click(object sender, EventArgs e)
        {
            Load_NhanVien();
            cbSearchKNV.SelectedIndex = -1;
            cbSearchVNV.SelectedIndex = -1;
            cbSearchVNV.Enabled = false;
        }

        private void btnAllKH_Click(object sender, EventArgs e)
        {
            Load_KhachHang();
            cbSearchKKH.SelectedIndex = -1;
            cbSearchVKH.SelectedIndex = -1;
            cbSearchVKH.Enabled = false;
        }

        private void cbSearchK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchK.Text;
            if (K != "")
            {
                cbSearchV.DataSource = Phong.searchV(K);
            }
            else
            {
                cbSearchV.DataSource = null;
            }
            cbSearchV.SelectedIndex = -1;
            cbSearchV.Enabled = true;
            Load_PhongHat();
        }

        private void cbSearchV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchK.Text;
            string V = cbSearchV.Text;
            if (K != "" && V != "")
            {
                dgvDSPH.DataSource = Phong.searchQuery(K, V);
            }
        }

        private void cbSearchV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string K = cbSearchK.Text;
                string V = cbSearchV.Text;
                if (K != "" && V != "")
                {
                    dgvDSPH.DataSource = Phong.searchQuery(K, V);
                }
            }
        }

        private void cbSearchKNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKNV.Text;
            if (K != "")
            {
                cbSearchVNV.DataSource = NhanVien.searchV(K);
            }
            else
            {
                cbSearchVNV.DataSource = null;
            }
            cbSearchVNV.SelectedIndex = -1;
            cbSearchVNV.Enabled = true;
            Load_NhanVien();
        }

        private void cbSearchVNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKNV.Text;
            string V = cbSearchVNV.Text;
            if (K != "" && V != "")
            {
                V = NhanVien.convertDateTime(V);
                dgvDSNV.DataSource = NhanVien.searchQuery(K, V);
            }
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
            Load_KhachHang();
        }

        private void cbSearchVKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string K = cbSearchKKH.Text;
            string V = cbSearchVKH.Text;
            if (K != "" && V != "")
            {
                V = KhachHang.convertDateTime(V);
                dgvDSKH.DataSource = KhachHang.searchQuery(K, V);
            }
        }

    }
}
