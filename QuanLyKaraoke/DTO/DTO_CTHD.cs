using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHD
    {
        private string MaCTHD, MaHoaDon, MaDichVu, SoLuong, ThanhTien;

        public string get_MaCTHD
        {
            get
            {
                return MaCTHD;
            }
            set
            {
                this.MaCTHD = value;
            }
        }

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

        public string get_MaDichVu
        {
            get
            {
                return MaDichVu;
            }
            set
            {
                this.MaDichVu = value;
            }
        }

        public string get_SoLuong
        {
            get
            {
                return SoLuong;
            }
            set
            {
                this.SoLuong = value;
            }
        }

        public string get_ThanhTien
        {
            get
            {
                return ThanhTien;
            }
            set
            {
                this.ThanhTien = value;
            }
        }

        public DTO_CTHD(string MaCTHD, string MaHoaDon, string MaDichVu, string SoLuong, string ThanhTien)
        {
            this.MaCTHD = MaCTHD;
            this.MaHoaDon = MaHoaDon;
            this.MaDichVu = MaDichVu;
            this.SoLuong = SoLuong;
            this.ThanhTien = ThanhTien;
        }
    }
}
