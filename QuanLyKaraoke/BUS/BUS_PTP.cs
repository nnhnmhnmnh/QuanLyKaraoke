using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PTP
    {
        DAL_PTP PhieuThuePhong;

        public BUS_PTP(string MaPhieu, string MaKhachHang, string MaPhong, string ThoiGianThuePhong, string ThoiGianTraPhong)
        {
            PhieuThuePhong = new DAL_PTP(MaPhieu, MaKhachHang, MaPhong, ThoiGianThuePhong, ThoiGianTraPhong);
        }

        public void addQuery()
        {
            PhieuThuePhong.addQuery();
        }

        public void updateQueryThue()
        {
            PhieuThuePhong.updateQueryThue();
        }

        public void updateQueryTra()
        {
            PhieuThuePhong.updateQueryTra();
        }

        public void deleteQuery()
        {
            PhieuThuePhong.deleteQuery();
        }

        public string MaPhieuThePhongTuDong()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public DataTable searchMaKH()
        {
            return PhieuThuePhong.searchMaKH();
        }

        public bool checkKhungGio(DateTime Thue, DateTime Tra)
        {
            DataTable dt = searchGioThueTraByMaPhong();
            foreach (DataRow row in dt.Rows)
            {
                DateTime GioThue = Convert.ToDateTime(row["ThoiGianThuePhong"]);
                DateTime GioTra = Convert.ToDateTime(row["ThoiGianTraPhong"]);
                if ((Thue >= GioThue && Tra <= GioTra) || (Thue <= GioThue && Tra >= GioThue) || (Thue <= GioTra && Tra >= GioTra))
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkGioThue(DateTime Thue)
        {
            DataTable dt = searchGioThueTraByMaPhong();
            foreach (DataRow row in dt.Rows)
            {
                DateTime GioThue = Convert.ToDateTime(row["ThoiGianThuePhong"]);
                DateTime GioTra = Convert.ToDateTime(row["ThoiGianTraPhong"]);
                if (Thue >= GioThue && Thue <= GioTra)
                {
                    return true;
                }
            }
            return false;
        }

        public DataTable searchGioThueTraByMaPhong()
        {
            return PhieuThuePhong.searchGioThueTraByMaPhong();
        }

        public List<string> selectPhongDaDat(DateTime Thue, DateTime Tra)
        {
            DataTable dt = PhieuThuePhong.selectGioThueTra();
            List<string> dt2 = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                DateTime GioThue = Convert.ToDateTime(row["ThoiGianThuePhong"]);
                DateTime GioTra = Convert.ToDateTime(row["ThoiGianTraPhong"]);
                if ((Thue >= GioThue && Tra <= GioTra) || (Thue <= GioThue && Tra >= GioThue) || (Thue <= GioTra && Tra >= GioTra))
                {
                    string MaPhong = row["MaPhong"].ToString();
                    dt2.Add(MaPhong);
                }
            }
            return dt2;
        }

        //public int checkExistKH()
        //{
        //    DataTable dt = selectCountKH();
        //    int count = Convert.ToInt32(dt.Rows[0]["Count"]);
        //    return count;
        //}

        //public DataTable selectCountKH()
        //{
        //    return PhieuThuePhong.selectCountKH();
        //}

        public DataTable selectQueryByKH()
        {
            DataTable dt = PhieuThuePhong.searchMaKH();
            dt.Columns["MaPhieu"].ColumnName = "Mã phiếu";
            dt.Columns["MaKhachHang"].ColumnName = "Mã khách hàng";
            dt.Columns["MaPhong"].ColumnName = "Mã phòng";
            dt.Columns["ThoiGianThuePhong"].ColumnName = "Thời gian thuê phòng";
            dt.Columns["ThoiGianTraPhong"].ColumnName = "Thời gian trả phòng";
            return dt;
        }

        public DataTable selectQuery()
        {
            DataTable dt = PhieuThuePhong.selectQuery();
            dt.Columns["MaPhieu"].ColumnName = "Mã phiếu";
            dt.Columns["MaKhachHang"].ColumnName = "Mã khách hàng";
            dt.Columns["MaPhong"].ColumnName = "Mã phòng";
            dt.Columns["ThoiGianThuePhong"].ColumnName = "Thời gian thuê phòng";
            dt.Columns["ThoiGianTraPhong"].ColumnName = "Thời gian trả phòng";
            return dt;
        }
    }
}
