using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NV
    {
        private string MaNhanVien, TenDangNhap, HoTen, CCCD, SDT, Email, DiaChi, GioiTinh, NgaySinh, ChucVu;

        public string get_MaNhanVien
        {
            get
            {
                return MaNhanVien;
            }
            set
            {
                this.MaNhanVien = value;
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

        public string get_CCCD
        {
            get
            {
                return CCCD;
            }
            set
            {
                this.CCCD = value;
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

        public string get_DiaChi
        {
            get
            {
                return DiaChi;
            }
            set
            {
                this.DiaChi = value;
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

        public string get_ChucVu
        {
            get
            {
                return ChucVu;
            }
            set
            {
                this.ChucVu = value;
            }
        }

        public DTO_NV(string MaNhanVien, string TenDangNhap, string HoTen, string CCCD, string SDT, string Email, string DiaChi, string GioiTinh, string NgaySinh, string ChucVu)
        {
            this.MaNhanVien = MaNhanVien;
            this.TenDangNhap = TenDangNhap;
            this.HoTen = HoTen;
            this.CCCD = CCCD;
            this.SDT = SDT;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.ChucVu = ChucVu;
        }
    }
}
