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
    public class DAL_DV
    {
        private DTO_DV DichVu;

        public DAL_DV(string MaDichVu, string LoaiDichVu, string TenDichVu, string DonGia, string TonKho)
        {
            DichVu = new DTO_DV(MaDichVu, LoaiDichVu, TenDichVu, DonGia, TonKho);
        }

        public DataTable getLastID()
        {
            string s = "SELECT TOP 1 MaDichVu AS max FROM DichVu ORDER BY MaDichVu DESC";
            return Connection.selectQuery(s, null);
        }

        public DataTable searchV(string K)
        {
            string query = "SELECT " + K + " FROM DichVu";
            return Connection.selectQuery(query, null);
        }

        public DataTable searchQuery(string K, string V)
        {
            string query = "SELECT * FROM DichVu WHERE " + K + " = @V";
            SqlParameter[] parameters =
            {
                new SqlParameter("@V", V)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchDonGia()
        {
            string query = "SELECT DonGia FROM DichVu WHERE MaDichVu = @MaDichVu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu ", DichVu.get_MaDichVu)
            };
            return Connection.selectQuery(query, parameters);
        }

        public DataTable searchSLTK()
        {
            string query = "SELECT TonKho FROM DichVu WHERE MaDichVu = @MaDichVu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu ", DichVu.get_MaDichVu)
            };
            return Connection.selectQuery(query, parameters);
        }

        public void addQuery()
        {
            string query = "INSERT INTO DichVu VALUES (@MaDichVu, @LoaiDichVu, @TenDichVu, @DonGia, @TonKho)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu", DichVu.get_MaDichVu),
                new SqlParameter("@LoaiDichVu", DichVu.get_LoaiDichVu),
                new SqlParameter("@TenDichVu", DichVu.get_TenDichVu),
                new SqlParameter("@DonGia", DichVu.get_DonGia),
                new SqlParameter("@TonKho", DichVu.get_TonKho)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateSLTK()
        {
            string query = "UPDATE DichVu SET TonKho = @TonKho WHERE MaDichVu = @MaDichVu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu", DichVu.get_MaDichVu),
                new SqlParameter("@TonKho", DichVu.get_TonKho)
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQuery()
        {
            string query = "UPDATE DichVu SET LoaiDichVu = @LoaiDichVu, TenDichVu = @TenDichVu, DonGia = @DonGia, TonKho = @TonKho WHERE MaDichVu = @MaDichVu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu", DichVu.get_MaDichVu),
                new SqlParameter("@LoaiDichVu", DichVu.get_LoaiDichVu),
                new SqlParameter("@TenDichVu", DichVu.get_TenDichVu),
                new SqlParameter("@DonGia", DichVu.get_DonGia),
                new SqlParameter("@TonKho", DichVu.get_TonKho)
            };
            Connection.actionQuery(query, parameters);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM DichVu WHERE MaDichVu = @MaDichVu";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaDichVu", DichVu.get_MaDichVu)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM DichVu";
            return Connection.selectQuery(s, null);
        }
    }
}
