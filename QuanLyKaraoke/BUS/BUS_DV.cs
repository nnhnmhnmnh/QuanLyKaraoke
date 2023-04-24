using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DV
    {
        DAL_DV DichVu;

        public BUS_DV(string MaDichVu, string LoaiDichVu, string TenDichVu, string DonGia, string TonKho)
        {
            DichVu = new DAL_DV(MaDichVu, LoaiDichVu, TenDichVu, DonGia, TonKho);
        }

        public string MaDichVuTuDong()
        {
            DataTable dt = DichVu.getLastID();
            if (dt.Rows.Count == 0)
            {
                return "dv0001";
            }
            string MaDichVu = dt.Rows[0]["max"].ToString();
            int So = int.Parse(MaDichVu.Substring(2)); // bỏ dv lấy 0001
            int SoMoi = So + 1;
            string MaSoMoi = SoMoi.ToString().PadLeft(4, '0');
            string MaDichVuMoi = "dv" + MaSoMoi;
            return MaDichVuMoi;
        }

        public int searchDonGia()
        {
            DataTable dt = DichVu.searchDonGia();
            if (dt.Rows.Count > 0)
            {
                int DonGia = Convert.ToInt32(dt.Rows[0]["DonGia"]);
                return DonGia;
            }
            return 0;
            
        }

        public int searchSLTK()
        {
            DataTable dt = DichVu.searchSLTK();
            if (dt.Rows.Count > 0)
            {
                int SLTK = Convert.ToInt32(dt.Rows[0]["TonKho"]);
                return SLTK;
            }
            return 0;
        }

        public void addQuery()
        {
            DichVu.addQuery();
        }

        public void updateSLTK()
        {
            DichVu.updateSLTK();
        }

        public void updateQuery()
        {
            DichVu.updateQuery();
        }

        public void deleteQuery()
        {
            DichVu.deleteQuery();
        }

        public string switchK(string K)
        {
            switch (K)
            {
                case "Mã dịch vụ":
                    K = "MaDichVu";
                    break;
                case "Loại dịch vụ":
                    K = "LoaiDichVu";
                    break;
                case "Tên dịch vụ":
                    K = "TenDichVu";
                    break;
                case "Đơn giá":
                    K = "DonGia";
                    break;
                case "Tồn kho":
                    K = "TonKho";
                    break;
            }
            return K;
        }

        public List<string> searchK()
        {
            DataTable dt = selectQuery();
            List<string> ThuocTinh = new List<string>();
            foreach (DataColumn TenCot in dt.Columns)
            {
                ThuocTinh.Add(TenCot.ToString());
            }
            return ThuocTinh;
        }

        public List<string> searchV(string K)
        {
            K = switchK(K);
            List<string> GiaTri = new List<string>();
            DataTable dt = DichVu.searchV(K);
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    GiaTri.Add(row[col].ToString());
                }
            }
            return GiaTri.Distinct().ToList();
        }

        public DataTable searchQuery(string K, string V)
        {
            K = switchK(K);
            DataTable dt = DichVu.searchQuery(K, V);
            dt.Columns["MaDichVu"].ColumnName = "Mã dịch vụ";
            dt.Columns["LoaiDichVu"].ColumnName = "Loại dịch vụ";
            dt.Columns["TenDichVu"].ColumnName = "Tên dịch vụ";
            dt.Columns["DonGia"].ColumnName = "Đơn giá";
            dt.Columns["TonKho"].ColumnName = "Tồn kho";
            return dt;
        }

        public DataTable selectQuery()
        {
            DataTable dt = DichVu.selectQuery();
            dt.Columns["MaDichVu"].ColumnName = "Mã dịch vụ";
            dt.Columns["LoaiDichVu"].ColumnName = "Loại dịch vụ";
            dt.Columns["TenDichVu"].ColumnName = "Tên dịch vụ";
            dt.Columns["DonGia"].ColumnName = "Đơn giá";
            dt.Columns["TonKho"].ColumnName = "Tồn kho";
            return dt;
        }
    }
}
