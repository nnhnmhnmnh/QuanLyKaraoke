using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NV
    {
        private DTO_NV NhanVien;
        public DAL_NV(string MaNhanVien, string TenDangNhap, string HoTen, string CCCD, string SDT, string Email, string DiaChi, string GioiTinh, string NgaySinh, string ChucVu)
        {
            NhanVien = new DTO_NV(MaNhanVien, TenDangNhap, HoTen, CCCD, SDT, Email, DiaChi, GioiTinh, NgaySinh, ChucVu);
        }

        public DataTable getLastID()
        {
            string s = "SELECT TOP 1 MaNhanVien AS max FROM NhanVien ORDER BY MaNhanVien DESC";
            return Connection.selectQuery(s, null);
        }

        public DataTable searchV(string K)
        {
            string query = "SELECT " + K + " FROM NhanVien";
            return Connection.selectQuery(query, null);
        }

        public DataTable searchQuery(string K, string V)
        {
            string query = "SELECT * FROM NhanVien WHERE " + K + " = @V";
            SqlParameter[] parameters =
            {
                new SqlParameter("@V", V)
            };
            return Connection.selectQuery(query, parameters);
        }
        public void addQuery()
        {
            string query = "INSERT INTO NhanVien VALUES (@MaNhanVien, @TenDangNhap, @HoTen, @CCCD, @SDT, @Email, @DiaChi, @GioiTinh, @NgaySinh, @ChucVu)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNhanVien", NhanVien.get_MaNhanVien),
                new SqlParameter("@TenDangNhap", NhanVien.get_TenDangNhap),
                new SqlParameter("@HoTen", NhanVien.get_HoTen),
                new SqlParameter("@CCCD", NhanVien.get_CCCD),
                new SqlParameter("@SDT", NhanVien.get_SDT),
                new SqlParameter("@Email", NhanVien.get_Email),
                new SqlParameter("@DiaChi", NhanVien.get_DiaChi),
                new SqlParameter("@GioiTinh", NhanVien.get_GioiTinh),
                new SqlParameter("@NgaySinh", NhanVien.get_NgaySinh),
                new SqlParameter("@ChucVu", NhanVien.get_ChucVu)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQuery()
        {
            string query = "UPDATE NhanVien SET TenDangNhap = @TenDangNhap, HoTen = @HoTen, CCCD = @CCCD, SDT = @SDT, Email = @Email, DiaChi = @DiaChi, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, ChucVu = @ChucVu WHERE MaNhanVien = @MaNhanVien";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNhanVien", NhanVien.get_MaNhanVien),
                new SqlParameter("@TenDangNhap", NhanVien.get_TenDangNhap),
                new SqlParameter("@HoTen", NhanVien.get_HoTen),
                new SqlParameter("@CCCD", NhanVien.get_CCCD),
                new SqlParameter("@SDT", NhanVien.get_SDT),
                new SqlParameter("@Email", NhanVien.get_Email),
                new SqlParameter("@DiaChi", NhanVien.get_DiaChi),
                new SqlParameter("@GioiTinh", NhanVien.get_GioiTinh),
                new SqlParameter("@NgaySinh", NhanVien.get_NgaySinh),
                new SqlParameter("@ChucVu", NhanVien.get_ChucVu)
            };
            Connection.actionQuery(query, parameters);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNhanVien", NhanVien.get_MaNhanVien)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM NhanVien";
            return Connection.selectQuery(s ,null);
        }
    }
}
