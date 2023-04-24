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
    public partial class InventoryManager : Form
    {
        BUS_DV DichVu;
        private string MaDichVu = "";

        public InventoryManager()
        {
            InitializeComponent();
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {
            Load_DichVu();
            cbSearchKDV.DataSource = DichVu.searchK();
            cbSearchKDV.SelectedIndex = -1;
            cbSearchVDV.Enabled = false;
            cbType.SelectedIndex = -1;
        }

        private void Load_DichVu()
        {
            DichVu = new BUS_DV("", "", "", "", "");
            dgvDSDV.DataSource = DichVu.selectQuery();
        }

        private void ClearTextbox_DichVu()
        {
            cbType.SelectedIndex = -1;
            txtName.Clear();
            txtPrice.Clear();
            txtRem.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtRem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DichVu = new BUS_DV(DichVu.MaDichVuTuDong(), cbType.Text, txtName.Text, txtPrice.Text, txtRem.Text);
                DichVu.addQuery();
                ClearTextbox_DichVu();
                Load_DichVu();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MaDichVu == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DichVu = new BUS_DV(MaDichVu, cbType.Text, txtName.Text, txtPrice.Text, txtRem.Text);
                DichVu.updateQuery();
                ClearTextbox_DichVu();
                Load_DichVu();
                MaDichVu = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MaDichVu == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DichVu = new BUS_DV(MaDichVu, cbType.Text, txtName.Text, txtPrice.Text, txtRem.Text);
                    DichVu.deleteQuery();
                    ClearTextbox_DichVu();
                    Load_DichVu();
                    MaDichVu = "";
                }
            }
        }

        private void dgvDSDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSDV.Rows[e.RowIndex];
            MaDichVu = row.Cells[0].Value.ToString();
            cbType.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
            txtRem.Text = row.Cells[4].Value.ToString();
        }

        private void cbSearchKDV_SelectedIndexChanged(object sender, EventArgs e)
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
