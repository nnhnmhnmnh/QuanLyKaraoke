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
    public class DAL_TK
    {
        private DTO_TK TaiKhoan;

        public DAL_TK(string TenDangNhap, string MatKhau)
        {
            TaiKhoan = new DTO_TK(TenDangNhap, MatKhau);
        }

        public List<DTO_TK> selectAcount()
        {
            string s = "SELECT * FROM TaiKhoan";
            DataTable tk = Connection.selectQuery(s, null);
            List<DTO_TK> danhSachTaiKhoan = new List<DTO_TK>();
            for (int i = 0; i < tk.Rows.Count; i++)
            {
                DataRow row = tk.Rows[i];
                string UN = (string)row["TenDangNhap"];
                string PW = (string)row["MatKhau"];
                DTO_TK taiKhoan = new DTO_TK(UN, PW);
                danhSachTaiKhoan.Add(taiKhoan);
            }
            return danhSachTaiKhoan;
        }

        public DataTable selectCount()
        {
            string s = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", TaiKhoan.get_TenDangNhap)
            };
            return Connection.selectQuery(s, parameters);
        }

        public void addQuery()
        {
            string s = "INSERT INTO TaiKhoan VALUES (@TenDN, @MatKhau)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDN", TaiKhoan.get_TenDangNhap),
                new SqlParameter("@MatKhau", TaiKhoan.get_MatKhau)
            };
            Connection.actionQuery(s, parameters);
        }

        public void updateQuery(string TenDN, string MKMoi)
        {
            string s = "UPDATE TaiKhoan SET MatKhau = @MKMoi WHERE TenDangNhap = @TenDN";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MKMoi", MKMoi),
                new SqlParameter("@TenDN", TenDN)
            };
            Connection.actionQuery(s, parameters);
        }
    }
}
