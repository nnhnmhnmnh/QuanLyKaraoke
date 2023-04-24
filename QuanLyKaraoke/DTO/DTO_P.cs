using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_P
    {
        private string MaPhong, LoaiPhong, SoNguoiToiDa, GiaTheoGio, TrangThai;

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

        public string get_LoaiPhong
        {
            get
            {
                return LoaiPhong;
            }
            set
            {
                this.LoaiPhong = value;
            }
        }

        public string get_SoNguoiToiDa
        {
            get
            {
                return SoNguoiToiDa;
            }
            set
            {
                this.SoNguoiToiDa = value;
            }
        }

        public string get_GiaTheoGio
        {
            get
            {
                return GiaTheoGio;
            }
            set
            {
                this.GiaTheoGio = value;
            }
        }

        public string get_TrangThai
        {
            get
            {
                return TrangThai;
            }
            set
            {
                this.TrangThai = value;
            }
        }

        public DTO_P(string MaPhong, string LoaiPhong, string SoNguoiToiDa, string GiaTheoGio, string TrangThai)
        {
            this.MaPhong = MaPhong;
            this.LoaiPhong = LoaiPhong;
            this.SoNguoiToiDa = SoNguoiToiDa;
            this.GiaTheoGio = GiaTheoGio;
            this.TrangThai = TrangThai;
        }
    }
}
