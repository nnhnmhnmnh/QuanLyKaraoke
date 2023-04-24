using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KH
    {
        private string MaKhachHang, TenDangNhap, HoTen, SDT, Email, GioiTinh, NgaySinh;

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

        public string get_TenDangNhap
        {
            get
            {
                return TenDangNhap;
            }
            set
            {
                this.TenDangNhap = value;
            }
        }

        public string get_HoTen
        {
            get
            {
                return HoTen;
            }
            set
            {
                this.HoTen = value;
            }
        }

        public string get_SDT
        {
            get
            {
                return SDT;
            }
            set
            {
                this.SDT = value;
            }
        }

        public string get_Email
        {
            get
            {
                return Email;
            }
            set
            {
                this.Email = value;
            }
        }

        public string get_GioiTinh
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                this.GioiTinh = value;
            }
        }

        public string get_NgaySinh
        {
            get
            {
                return NgaySinh;
            }
            set
            {
                this.NgaySinh = value;
            }
        }

        public DTO_KH(string MaKhachHang, string TenDangNhap, string HoTen, string SDT, string Email, string GioiTinh, string NgaySinh)
        {
            this.MaKhachHang = MaKhachHang;
            this.TenDangNhap = TenDangNhap;
            this.HoTen = HoTen;
            this.SDT = SDT;
            this.Email = Email;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
        }
    }
}
