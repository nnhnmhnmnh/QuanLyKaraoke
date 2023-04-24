using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;

namespace DAL
{
    public class DAL_CTHD
    {
        private DTO_CTHD CTHD;

        public DAL_CTHD(string MaCTHD, string MaHoaDon, string MaDichVu, string SoLuong, string ThanhTien)
        {
            CTHD = new DTO_CTHD(MaCTHD, MaHoaDon, MaDichVu, SoLuong, ThanhTien);
        }

        public DataTable checkExistMaDV()
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE (MaDichVu = @MaDichVu AND MaHoaDon = @MaHoaDon)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu ", CTHD.get_MaDichVu),
                new SqlParameter("@MaHoaDon ", CTHD.get_MaHoaDon)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchQuery(string K, string V)
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE " + K + " = @V";
            SqlParameter[] parameters =
            {
                new SqlParameter("@V", V)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchTongCTHD()
        {
            string query = "SELECT SUM(ThanhTien) AS TongCTHD FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHoaDon", CTHD.get_MaHoaDon)
            };
            return Connection.selectQuery(query, parameters);
        }

        public void addQuery()
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES (@MaCTHD, @MaHoaDon, @MaDichVu, @SoLuong, @ThanhTien)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaCTHD", CTHD.get_MaCTHD),
                new SqlParameter("@MaHoaDon", CTHD.get_MaHoaDon),
                new SqlParameter("@MaDichVu", CTHD.get_MaDichVu),
                new SqlParameter("@SoLuong", CTHD.get_SoLuong),
                new SqlParameter("@ThanhTien", CTHD.get_ThanhTien)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateSL()
        {
            string query = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong, ThanhTien = @ThanhTien WHERE MaCTHD = @MaCTHD";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaCTHD", CTHD.get_MaCTHD),
                new SqlParameter("@SoLuong", CTHD.get_SoLuong),
                new SqlParameter("@ThanhTien", CTHD.get_ThanhTien)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQuery()
        {
            string query = "UPDATE ChiTietHoaDon SET MaHoaDon = @MaHoaDon, MaDichVu = @MaDichVu, SoLuong = @SoLuong, ThanhTien = @ThanhTien WHERE MaCTHD = @MaCTHD";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaCTHD", CTHD.get_MaCTHD),
                new SqlParameter("@MaHoaDon", CTHD.get_MaHoaDon),
                new SqlParameter("@MaDichVu", CTHD.get_MaDichVu),
                new SqlParameter("@SoLuong", CTHD.get_SoLuong),
                new SqlParameter("@ThanhTien", CTHD.get_ThanhTien)
            };
            Connection.actionQuery(query, parameters);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaCTHD = @MaCTHD";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaCTHD", CTHD.get_MaCTHD)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHoaDon", CTHD.get_MaHoaDon)
            };
            return Connection.selectQuery(s, parameters);
        }
    }
}
