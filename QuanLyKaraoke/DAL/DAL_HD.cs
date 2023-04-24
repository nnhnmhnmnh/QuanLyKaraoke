using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HD
    {
        private DTO_HD HD;

        public DAL_HD(string MaHoaDon, string MaPhieu, string MaKhachHang, string NgayLap, string TongTien)
        {
            HD = new DTO_HD(MaHoaDon, MaPhieu, MaKhachHang, NgayLap, TongTien);
        }

        public DataTable searchByMaHD()
        {
            string query = "SELECT * FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHoaDon", HD.get_MaHoaDon)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchMaHD()
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu", HD.get_MaPhieu)
            };
            return Connection.selectQuery(query, parameters);
        }

        public void addQuery()
        {
            string query = "INSERT INTO HoaDon VALUES (@MaHoaDon, @MaPhieu, @MaKhachHang, @NgayLap, @TongTien)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHoaDon", HD.get_MaHoaDon),
                new SqlParameter("@MaPhieu", HD.get_MaPhieu),
                new SqlParameter("@MaKhachHang", HD.get_MaKhachHang),
                new SqlParameter("@NgayLap", HD.get_NgayLap),
                new SqlParameter("@TongTien", HD.get_TongTien)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQuery()
        {
            string query = "UPDATE HoaDon SET MaPhieu = @MaPhieu, MaKhachHang = @MaKhachHang, NgayLap = @NgayLap, TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaHoaDon", HD.get_MaHoaDon),
                new SqlParameter("@MaPhieu", HD.get_MaPhieu),
                new SqlParameter("@MaKhachHang", HD.get_MaKhachHang),
                new SqlParameter("@NgayLap", HD.get_NgayLap),
                new SqlParameter("@TongTien", HD.get_TongTien)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM HoaDon";
            return Connection.selectQuery(s, null);
        }
    }
}
