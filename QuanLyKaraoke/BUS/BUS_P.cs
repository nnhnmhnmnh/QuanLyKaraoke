using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_P
    {
        DAL_P Phong;

        public BUS_P(string MaPhong, string LoaiPhong, string SoNguoiToiDa, string GiaTheoGio, string TrangThai)
        {
            Phong = new DAL_P(MaPhong, LoaiPhong, SoNguoiToiDa, GiaTheoGio, TrangThai);
        }

        public string MaPhongTuDong()
        {
            DataTable dt = Phong.getLastID();
            if (dt.Rows.Count == 0)
            {
                return "p0001";
            }
            string MaPhong = dt.Rows[0]["max"].ToString();
            int So = int.Parse(MaPhong.Substring(1)); // bỏ p lấy 0001
            int SoMoi = So + 1;
            string MaSoMoi = SoMoi.ToString().PadLeft(4, '0');
            string MaPhongMoi = "p" + MaSoMoi;
            return MaPhongMoi;
        }

        public void addQuery()
        {
            Phong.addQuery();
        }

        public void updateQuery()
        {
            Phong.updateQuery();
        }

        public void deleteQuery()
        {
            Phong.deleteQuery();
        }

        public string switchK(string K)
        {
            switch (K)
            {
                case "Mã phòng":
                    K = "MaPhong";
                    break;
                case "Loại phòng":
                    K = "LoaiPhong";
                    break;
                case "Số người tối đa":
                    K = "SoNguoiToiDa";
                    break;
                case "Giá theo giờ":
                    K = "GiaTheoGio";
                    break;
                case "Trạng thái":
                    K = "TrangThai";
                    break;
            }
            return K;
        }

        public List<string> searchV(string K)
        {
            K = switchK(K);
            List<string> GiaTri = new List<string>();
            DataTable dt = Phong.searchV(K);
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    GiaTri.Add(row[col].ToString());
                }
            }
            return GiaTri.Distinct().ToList();
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

        public int searchGiaTheoGio()
        {
            DataTable dt = Phong.searchGiaTheoGio();
            if (dt.Rows.Count > 0 && dt.Rows[0]["GiaTheoGio"] != DBNull.Value)
            {
                return Convert.ToInt32(dt.Rows[0]["GiaTheoGio"]);
            }
            return 0;
        }

        public string searchTrangThai()
        {
            DataTable dt = Phong.searchTrangThai();
            if (dt.Rows.Count > 0 && dt.Rows[0]["TrangThai"] != DBNull.Value)
            {
                return (dt.Rows[0]["TrangThai"]).ToString();
            }
            return "0";
        }

        public DataTable searchQuery(string K, string V)
        {
            K = switchK(K);
            DataTable dt = Phong.searchQuery(K, V);
            dt.Columns["MaPhong"].ColumnName = "Mã phòng";
            dt.Columns["LoaiPhong"].ColumnName = "Loại phòng";
            dt.Columns["SoNguoiToiDa"].ColumnName = "Số người tối đa";
            dt.Columns["GiaTheoGio"].ColumnName = "Giá theo giờ";
            dt.Columns["TrangThai"].ColumnName = "Trạng thái";
            return dt;
        }

        public DataTable searchByMaPhong(List<string> MaPhong)
        {
            return Phong.searchByMaPhong(MaPhong);
        }

        public DataTable selectQuery()
        {
            DataTable dt = Phong.selectQuery();
            dt.Columns["MaPhong"].ColumnName = "Mã phòng";
            dt.Columns["LoaiPhong"].ColumnName = "Loại phòng";
            dt.Columns["SoNguoiToiDa"].ColumnName = "Số người tối đa";
            dt.Columns["GiaTheoGio"].ColumnName = "Giá theo giờ";
            dt.Columns["TrangThai"].ColumnName = "Trạng thái";
            return dt;
        }
    }
}
