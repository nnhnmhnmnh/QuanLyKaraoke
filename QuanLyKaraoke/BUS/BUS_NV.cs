using DAL;
using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NV
    {
        DAL_NV NhanVien;

        public BUS_NV(string MaNhanVien, string TenDangNhap, string HoTen, string CCCD, string SDT, string Email, string DiaChi, string GioiTinh, string NgaySinh, string ChucVu)
        {
            NhanVien = new DAL_NV(MaNhanVien, TenDangNhap, HoTen, CCCD, SDT, Email, DiaChi, GioiTinh, NgaySinh, ChucVu);
        }

        public string MaNhanVienTuDong()
        {
            DataTable dt = NhanVien.getLastID();
            if (dt.Rows.Count == 0)
            {
                return "nv0001";
            }
            string MaNhanVien = dt.Rows[0]["max"].ToString();
            int So = int.Parse(MaNhanVien.Substring(2)); // bỏ nv lấy 0001
            int SoMoi = So + 1;
            string MaSoMoi = SoMoi.ToString().PadLeft(4, '0');
            string MaNhanVienMoi = "nv" + MaSoMoi;
            return MaNhanVienMoi;
        }

        public void addQuery()
        {
            NhanVien.addQuery();
        }

        public void updateQuery()
        {
            NhanVien.updateQuery();
        }

        public void deleteQuery()
        {
            NhanVien.deleteQuery();
        }

        public string switchK(string K)
        {
            switch (K)
            {
                case "Mã nhân viên":
                    K = "MaNhanVien";
                    break;
                case "Tên đăng nhập":
                    K = "TenDangNhap";
                    break;
                case "Họ tên":
                    K = "HoTen";
                    break;
                case "Địa chỉ":
                    K = "DiaChi";
                    break;
                case "Giới tính":
                    K = "GioiTinh";
                    break;
                case "Ngày sinh":
                    K = "NgaySinh";
                    break;
                case "Chức vụ":
                    K = "ChucVu";
                    break;
            }
            return K;
        }

        public List<string> searchV(string K)
        {
            K = switchK(K);
            List<string> GiaTri = new List<string>();
            DataTable dt = NhanVien.searchV(K);
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

        public DataTable searchQuery(string K, string V)
        {
            K = switchK(K);
            DataTable dt = NhanVien.searchQuery(K, V);
            dt.Columns["MaNhanVien"].ColumnName = "Mã nhân viên";
            dt.Columns["TenDangNhap"].ColumnName = "Tên đăng nhập";
            dt.Columns["HoTen"].ColumnName = "Họ tên";
            dt.Columns["DiaChi"].ColumnName = "Địa chỉ";
            dt.Columns["GioiTinh"].ColumnName = "Giới tính";
            dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
            dt.Columns["ChucVu"].ColumnName = "Chức vụ";
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
            //if (text.Length >= 10)
            //{
            //    text = text.Substring(0, 10);
            //}
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
            DataTable dt = NhanVien.selectQuery();
            dt.Columns["MaNhanVien"].ColumnName = "Mã nhân viên";
            dt.Columns["TenDangNhap"].ColumnName = "Tên đăng nhập";
            dt.Columns["HoTen"].ColumnName = "Họ tên";
            dt.Columns["DiaChi"].ColumnName = "Địa chỉ";
            dt.Columns["GioiTinh"].ColumnName = "Giới tính";
            dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
            dt.Columns["ChucVu"].ColumnName = "Chức vụ";
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        Console.WriteLine(row[col].ToString());
            //    }
            //}
            return dt;
        }
    }
}
