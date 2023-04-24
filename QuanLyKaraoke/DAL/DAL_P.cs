using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_P
    {
        private DTO_P Phong;
        public DAL_P(string MaPhong, string LoaiPhong, string SoNguoiToiDa, string GiaTheoGio, string TrangThai)
        {
            Phong = new DTO_P(MaPhong, LoaiPhong, SoNguoiToiDa, GiaTheoGio, TrangThai);
        }

        public DataTable getLastID()
        {
            string s = "SELECT TOP 1 MaPhong AS max FROM PhongHat ORDER BY MaPhong DESC";
            return Connection.selectQuery(s, null);
        }

        public void updateQuery()
        {
            string query = "UPDATE PhongHat SET LoaiPhong = @LoaiPhong, SoNguoiToiDa = @SoNguoiToiDa, GiaTheoGio = @GiaTheoGio, TrangThai = @TrangThai WHERE MaPhong = @MaPhong";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", Phong.get_MaPhong),
                new SqlParameter("@LoaiPhong", Phong.get_LoaiPhong),
                new SqlParameter("@SoNguoiToiDa", Phong.get_SoNguoiToiDa),
                new SqlParameter("@GiaTheoGio", Phong.get_GiaTheoGio),
                new SqlParameter("@TrangThai", Phong.get_TrangThai)
            };
            Connection.actionQuery(query, parameters);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM PhongHat WHERE MaPhong = @MaPhong";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", Phong.get_MaPhong)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable searchV(string K)
        {
            string query = "SELECT " + K + " FROM PhongHat";
            return Connection.selectQuery(query, null);
        }

        public DataTable searchGiaTheoGio()
        {
            string s = "SELECT GiaTheoGio FROM PhongHat WHERE MaPhong = @MaPhong";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", Phong.get_MaPhong)
            };
            return Connection.selectQuery(s, parameters);
        }

        public DataTable searchTrangThai()
        {
            string s = "SELECT TrangThai FROM PhongHat WHERE MaPhong = @MaPhong";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", Phong.get_MaPhong)
            };
            return Connection.selectQuery(s, parameters);
        }

        public DataTable searchQuery(string K, string V)
        {
            //string query = "SELECT * FROM PhongHat WHERE " + K + " = N'" + V + "'";
            string query = "SELECT * FROM PhongHat WHERE " + K + " = @V";
            SqlParameter[] parameters =
            {
                new SqlParameter("@V", V)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchByMaPhong(List<string> MaPhong)
        {
            string query = "SELECT * FROM PhongHat WHERE MaPhong NOT IN ('" + string.Join("','", MaPhong) + "')";
            Console.WriteLine(query);
            return Connection.selectQuery(query, null);
        }

        public void addQuery()
        {
            //string query = "insert into PhongHat values ('" + Phong.get_MaPhong + "','" + Phong.get_LoaiPhong + "'," + Phong.get_SoNguoiToiDa + "," + Phong.get_GiaTheoGio + ",N'" + Phong.get_TrangThai + "')";
            string query = "INSERT INTO PhongHat VALUES (@MaPhong, @LoaiPhong, @SoNguoiToiDa, @GiaTheoGio, @TrangThai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPhong", Phong.get_MaPhong),
                new SqlParameter("@LoaiPhong", Phong.get_LoaiPhong),
                new SqlParameter("@SoNguoiToiDa", Phong.get_SoNguoiToiDa),
                new SqlParameter("@GiaTheoGio", Phong.get_GiaTheoGio),
                new SqlParameter("@TrangThai", Phong.get_TrangThai)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM PhongHat";
            return Connection.selectQuery(s, null);
        }
    }
}
