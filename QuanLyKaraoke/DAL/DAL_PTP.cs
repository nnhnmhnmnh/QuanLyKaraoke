using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PTP
    {
        private DTO_PTP PhieuThuePhong;

        public DAL_PTP(string MaPhieu, string MaKhachHang, string MaPhong, string ThoiGianThuePhong, string ThoiGianTraPhong)
        {
            PhieuThuePhong = new DTO_PTP(MaPhieu, MaKhachHang, MaPhong, ThoiGianThuePhong, ThoiGianTraPhong);
        }

        public DataTable searchGioThueTraByMaPhong()
        {
            string s = "SELECT ThoiGianThuePhong, ThoiGianTraPhong FROM PhieuThuePhong WHERE MaPhong = @MaPhong";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", PhieuThuePhong.get_MaPhong)
            };
            return Connection.selectQuery(s, parameters);
        }

        public DataTable selectGioThueTra()
        {
            string s = "SELECT MaPhong, ThoiGianThuePhong, ThoiGianTraPhong FROM PhieuThuePhong";
            return Connection.selectQuery(s, null);
        }

        public void addQuery()
        {
            string query = "INSERT INTO PhieuThuePhong VALUES (@MaPhieu, @MaKhachHang, @MaPhong, @ThoiGianThuePhong, @ThoiGianTraPhong)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu", PhieuThuePhong.get_MaPhieu),
                new SqlParameter("@MaKhachHang", PhieuThuePhong.get_MaKhachHang),
                new SqlParameter("@MaPhong", PhieuThuePhong.get_MaPhong),
                new SqlParameter("@ThoiGianThuePhong", PhieuThuePhong.get_ThoiGianThuePhong),
                new SqlParameter("@ThoiGianTraPhong", PhieuThuePhong.get_ThoiGianTraPhong)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQueryThue()
        {
            string query = "UPDATE PhieuThuePhong SET ThoiGianThuePhong = @ThoiGianThuePhong WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu", PhieuThuePhong.get_MaPhieu),
                new SqlParameter("@ThoiGianThuePhong", PhieuThuePhong.get_ThoiGianThuePhong)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQueryTra()
        {
            string query = "UPDATE PhieuThuePhong SET ThoiGianTraPhong = @ThoiGianTraPhong WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu", PhieuThuePhong.get_MaPhieu),
                new SqlParameter("@ThoiGianTraPhong", PhieuThuePhong.get_ThoiGianTraPhong)
            };
            Connection.actionQuery(query, parameters);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM PhieuThuePhong WHERE MaPhieu = @MaPhieu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhieu", PhieuThuePhong.get_MaPhieu)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable searchMaKH()
        {
            string s = "SELECT * FROM PhieuThuePhong WHERE MaKhachHang = @MaKhachHang";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKhachHang", PhieuThuePhong.get_MaKhachHang)
            };
            return Connection.selectQuery(s, parameters);
        }

        //public DataTable selectCountKH()
        //{
        //    string s = "SELECT COUNT(MaKhachHang) AS Count FROM PhieuThuePhong WHERE (MaKhachHang = @MaKhachHang AND MaPhieu = @MaPhieu)";
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("@MaKhachHang", PhieuThuePhong.get_MaKhachHang),
        //        new SqlParameter("@MaPhieu", PhieuThuePhong.get_MaPhieu)
        //    };
        //    return Connection.selectQuery(s, parameters);
        //}

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM PhieuThuePhong";
            return Connection.selectQuery(s, null);
        }
    }
}
