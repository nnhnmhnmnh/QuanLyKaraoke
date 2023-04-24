using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CTHD
    {
        DAL_CTHD CTHD;

        public BUS_CTHD(string MaCTHD, string MaHoaDon, string MaDichVu, string SoLuong, string ThanhTien)
        {
            CTHD = new DAL_CTHD(MaCTHD, MaHoaDon, MaDichVu, SoLuong, ThanhTien);
        }

        public string MaCTHDTuDong()
        {
            return "cthd" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public bool checkExistMaDV()
        {
            DataTable dt = CTHD.checkExistMaDV();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int searchTongCTHD()
        {
            DataTable dt = CTHD.searchTongCTHD();
            if (dt.Rows.Count > 0 && dt.Rows[0]["TongCTHD"] != DBNull.Value)
            {
                return Convert.ToInt32(dt.Rows[0]["TongCTHD"]);
            }
            return 0;
        }

        public void addQuery()
        {
            CTHD.addQuery();
        }

        public void updateSL()
        {
            CTHD.updateSL();
        }

        public void updateQuery()
        {
            CTHD.updateQuery();
        }

        public void deleteQuery()
        {
            CTHD.deleteQuery();
        }

        public DataTable selectQuery()
        {
            DataTable dt = CTHD.selectQuery();
            dt.Columns["MaCTHD"].ColumnName = "Mã CTHD";
            dt.Columns["MaHoaDon"].ColumnName = "Mã hóa đơn";
            dt.Columns["MaDichVu"].ColumnName = "Mã dịch vụ";
            dt.Columns["SoLuong"].ColumnName = "Số lượng";
            dt.Columns["ThanhTien"].ColumnName = "Thành tiền";
            return dt;
        }
    }
}
