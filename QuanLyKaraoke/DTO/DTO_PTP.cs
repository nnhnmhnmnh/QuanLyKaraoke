using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PTP
    {
        private string MaPhieu, MaKhachHang, MaPhong, ThoiGianThuePhong, ThoiGianTraPhong;

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

        public string get_MaPhong
        {
            get
            {
                return MaPhong;
            }
            set
            {
                this.MaPhong = value;
            }
        }

        public string get_ThoiGianThuePhong
        {
            get
            {
                return ThoiGianThuePhong;
            }
            set
            {
                this.ThoiGianThuePhong = value;
            }
        }

        public string get_ThoiGianTraPhong
        {
            get
            {
                return ThoiGianTraPhong;
            }
            set
            {
                this.ThoiGianTraPhong = value;
            }
        }

        public DTO_PTP(string MaPhieu, string MaKhachHang, string MaPhong, string ThoiGianThuePhong, string ThoiGianTraPhong)
        {
            this.MaPhieu = MaPhieu;
            this.MaKhachHang = MaKhachHang;
            this.MaPhong = MaPhong;
            this.ThoiGianThuePhong = ThoiGianThuePhong;
            this.ThoiGianTraPhong = ThoiGianTraPhong;
        }
    }
}
