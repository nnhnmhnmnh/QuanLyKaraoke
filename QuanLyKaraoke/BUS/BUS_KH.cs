using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KH
    {
        DAL_KH KhachHang;

        public BUS_KH(string MaKhachHang, string TenDangNhap, string HoTen, string SDT, string Email, string GioiTinh, string NgaySinh)
        {
            KhachHang = new DAL_KH(MaKhachHang, TenDangNhap, HoTen, SDT, Email, GioiTinh, NgaySinh);
        }

        public string MaKhachHangTuDong()
        {
            DataTable dt = KhachHang.getLastID();
            if (dt.Rows.Count == 0)
            {
                return "kh0001";
            }
            string MaKhachHang = dt.Rows[0]["max"].ToString();
            int So = int.Parse(MaKhachHang.Substring(2)); // bỏ kh lấy 0001
            int SoMoi = So + 1;
            string MaSoMoi = SoMoi.ToString().PadLeft(4, '0');
            string MaKhachHangMoi = "kh" + MaSoMoi;
            return MaKhachHangMoi;
        }

        public void addQuery()
        {
            KhachHang.addQuery();
        }

        public void updateQuery()
        {
            KhachHang.updateQuery();
        }

        public void deleteQuery()
        {
            KhachHang.deleteQuery();
        }

        public string switchK(string K)
        {
            switch (K)
            {
                case "Mã khách hàng":
                    K = "MaKhachHang";
                    break;
                case "Tên đăng nhập":
                    K = "TenDangNhap";
                    break;
                case "Họ tên":
                    K = "HoTen";
                    break;
                case "Giới tính":
                    K = "GioiTinh";
                    break;
                case "Ngày sinh":
                    K = "NgaySinh";
                    break;
            }
            return K;
        }

        public List<string> searchV(string K)
        {
            K = switchK(K);
            List<string> GiaTri = new List<string>();
            DataTable dt = KhachHang.searchV(K);
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

        public List<string> searchPhone()
        {
            List<string> GiaTri = new List<string>();
            DataTable dt = KhachHang.searchPhone();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    GiaTri.Add(row[col].ToString());
                }
            }
            return GiaTri;
        }

        public string searchMaKHBySDT()
        {
            DataTable dt = KhachHang.searchMaKHBySDT();
            if (dt.Rows.Count > 0)
            {
                return (dt.Rows[0]["MaKhachHang"]).ToString();
            }
            return "";
        }

        public string searchMaKHByUN()
        {
            DataTable dt = KhachHang.searchMaKHByUN();
            if (dt.Rows.Count > 0)
            {
                return (dt.Rows[0]["MaKhachHang"]).ToString();
            }
            return "";
        }

        public DataTable searchQuery(string K, string V)
        {
            K = switchK(K);
            DataTable dt = KhachHang.searchQuery(K, V);
            dt.Columns["MaKhachHang"].ColumnName = "Mã khách hàng";
            dt.Columns["TenDangNhap"].ColumnName = "Tên đăng nhập";
            dt.Columns["HoTen"].ColumnName = "Họ tên";
            dt.Columns["GioiTinh"].ColumnName = "Giới tính";
            dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
            return dt;
        }

        public string convertDate(string text)
        {
            DateTime date;
            bool isValidDate = DateTime.TryParseExact(text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            if (isValidDate == true)
            {
                return date.ToString("yyyy-MM-dd");
            }
            else
            {
                return text;
            }
        }

        public string convertDateTime(string text)
        {
            DateTime date;
            bool isValidDate = DateTime.TryParseExact(text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            if (isValidDate == true)
            {
                return date.ToString("yyyy-MM-ddTHH:mm:ss");
            }
            else
            {
                return text;
            }
        }

        public DataTable selectQuery()
        {
            DataTable dt = KhachHang.selectQuery();
            dt.Columns["MaKhachHang"].ColumnName = "Mã khách hàng";
            dt.Columns["TenDangNhap"].ColumnName = "Tên đăng nhập";
            dt.Columns["HoTen"].ColumnName = "Họ tên";
            dt.Columns["GioiTinh"].ColumnName = "Giới tính";
            dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
            return dt;
        }
    }
}
