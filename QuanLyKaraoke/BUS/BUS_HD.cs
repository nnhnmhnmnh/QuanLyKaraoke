using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HD
    {
        DAL_HD HD;

        public BUS_HD(string MaHoaDon, string MaPhieu, string MaKhachHang, string NgayLap, string TongTien)
        {
            HD = new DAL_HD(MaHoaDon, MaPhieu, MaKhachHang, NgayLap, TongTien);
        }

        public string MaHDTuDong()
        {
            return "hd" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public string searchMaHD()
        {
            DataTable dt = HD.searchMaHD();
            if (dt.Rows.Count > 0)
            {
                string maHoaDon = dt.Rows[0]["MaHoaDon"].ToString();
                return maHoaDon;
            }
            return "";
        }

        public void addQuery()
        {
            HD.addQuery();
        }

        public void updateQuery()
        {
            HD.updateQuery();
        }

        public DataTable searchByMaHD()
        {
            DataTable dt = HD.searchByMaHD();
            return dt;
        }

        public DataTable selectQuery()
        {
            DataTable dt = HD.selectQuery();
            dt.Columns["MaHoaDon"].ColumnName = "Mã hóa đơn";
            dt.Columns["MaPhieu"].ColumnName = "Mã phiếu";
            dt.Columns["MaKhachHang"].ColumnName = "Mã khách hàng";
            dt.Columns["NgayLap"].ColumnName = "Ngày lập";
            dt.Columns["TongTien"].ColumnName = "Tổng tiền";
            return dt;
        }
    }
}
