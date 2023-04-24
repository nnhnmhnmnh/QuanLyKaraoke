using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KH
    {
        private DTO_KH KhachHang;

        public DAL_KH(string MaKhachHang, string TenDangNhap, string HoTen, string SDT, string Email, string GioiTinh, string NgaySinh)
        {
            KhachHang = new DTO_KH(MaKhachHang, TenDangNhap, HoTen, SDT, Email, GioiTinh, NgaySinh);
        }

        public DataTable getLastID()
        {
            string s = "SELECT TOP 1 MaKhachHang AS max FROM KhachHang ORDER BY MaKhachHang DESC";
            return Connection.selectQuery(s, null);
        }

        public DataTable searchV(string K)
        {
            string query = "SELECT " + K + " FROM KhachHang";
            return Connection.selectQuery(query, null);
        }

        public DataTable searchPhone()
        {
            string query = "SELECT SDT FROM KhachHang";
            return Connection.selectQuery(query, null);
        }

        public DataTable searchMaKHBySDT()
        {
            string query = "SELECT MaKhachHang FROM KhachHang WHERE SDT = @SDT";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SDT", KhachHang.get_SDT)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchMaKHByUN()
        {
            string query = "SELECT MaKhachHang FROM KhachHang WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", KhachHang.get_TenDangNhap)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchQuery(string K, string V)
        {
            string query = "SELECT * FROM KhachHang WHERE " + K + " = @V";
            SqlParameter[] parameters =
            {
                new SqlParameter("@V", V)
            };
            return Connection.selectQuery(query, parameters);
        }
        public void addQuery()
        {
            string query = "INSERT INTO KhachHang VALUES (@MaKhachHang, @TenDangNhap, @HoTen, @SDT, @Email, @GioiTinh, @NgaySinh)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", KhachHang.get_TenDangNhap),
                new SqlParameter("@HoTen", KhachHang.get_HoTen),
                new SqlParameter("@SDT", KhachHang.get_SDT),
                new SqlParameter("@Email", KhachHang.get_Email),
                new SqlParameter("@GioiTinh", KhachHang.get_GioiTinh),
                new SqlParameter("@NgaySinh", KhachHang.get_NgaySinh),
                new SqlParameter("@MaKhachHang", KhachHang.get_MaKhachHang)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQuery()
        {
            //string query = "UPDATE KhachHang SET TenDangNhap = '" + KhachHang.get_TenDangNhap + "', HoTen = N'" + KhachHang.get_HoTen + "', SDT = '" + KhachHang.get_SDT + "', Email = '" + KhachHang.get_Email + "', GioiTinh = N'" + KhachHang.get_GioiTinh + "', NgaySinh = '" + KhachHang.get_NgaySinh + "' WHERE MaKhachHang = '" + KhachHang.get_MaKhachHang + "'";
            string query = "UPDATE KhachHang SET TenDangNhap = @TenDangNhap, HoTen = @HoTen, SDT = @SDT, Email = @Email, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh WHERE MaKhachHang = @MaKhachHang";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", KhachHang.get_TenDangNhap),
                new SqlParameter("@HoTen", KhachHang.get_HoTen),
                new SqlParameter("@SDT", KhachHang.get_SDT),
                new SqlParameter("@Email", KhachHang.get_Email),
                new SqlParameter("@GioiTinh", KhachHang.get_GioiTinh),
                new SqlParameter("@NgaySinh", KhachHang.get_NgaySinh),
                new SqlParameter("@MaKhachHang", KhachHang.get_MaKhachHang)
            };
            Connection.actionQuery(query, parameters);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKhachHang", KhachHang.get_MaKhachHang)
            };
            Connection.actionQuery(query, parameters);
            //SqlParameter[] parameters = {new SqlParameter("@MaKhachHang", SqlDbType.VarChar) { Value = KhachHang.get_MaKhachHang }};
            //string query = "DELETE FROM KhachHang WHERE MaKhachHang = '" + KhachHang.get_MaKhachHang + "'";
            //Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM KhachHang";
            return Connection.selectQuery(s, null);
        }
    }
}
