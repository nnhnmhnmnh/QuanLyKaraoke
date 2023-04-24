using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HD
    {
        private string MaHoaDon, MaPhieu, MaKhachHang, NgayLap, TongTien;

        public string get_MaHoaDon
        {
            get
            {
                return MaHoaDon;
            }
            set
            {
                this.MaHoaDon = value;
            }
        }

        public string get_MaPhieu
        {
            get
            {
                return MaPhieu;
            }
            set
            {
                this.MaPhieu = value;
            }
        }

        public string get_MaKhachHang
        {
            get
            {
                return MaKhachHang;
            }
            set
            {
                this.MaKhachHang = value;
            }
        }

        public string get_NgayLap
        {
            get
            {
                return NgayLap;
            }
            set
            {
                this.NgayLap = value;
            }
        }

        public string get_TongTien
        {
            get
            {
                return TongTien;
            }
            set
            {
                this.TongTien = value;
            }
        }


        public DTO_HD(string MaHoaDon, string MaPhieu, string MaKhachHang, string NgayLap, string TongTien)
        {
            this.MaHoaDon = MaHoaDon;
            this.MaPhieu = MaPhieu;
            this.MaKhachHang = MaKhachHang;
            this.NgayLap = NgayLap;
            this.TongTien = TongTien;
        }
    }
}
