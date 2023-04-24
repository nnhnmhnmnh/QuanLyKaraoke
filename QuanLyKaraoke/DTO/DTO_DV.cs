using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DV
    {
        private string MaDichVu, LoaiDichVu, TenDichVu, DonGia, TonKho;

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

        public string get_LoaiDichVu
        {
            get
            {
                return LoaiDichVu;
            }
            set
            {
                this.LoaiDichVu = value;
            }
        }

        public string get_TenDichVu
        {
            get
            {
                return TenDichVu;
            }
            set
            {
                this.TenDichVu = value;
            }
        }

        public string get_DonGia
        {
            get
            {
                return DonGia;
            }
            set
            {
                this.DonGia = value;
            }
        }

        public string get_TonKho
        {
            get
            {
                return TonKho;
            }
            set
            {
                this.TonKho = value;
            }
        }

        public DTO_DV(string MaDichVu, string LoaiDichVu, string TenDichVu, string DonGia, string TonKho)
        {
            this.MaDichVu = MaDichVu;
            this.LoaiDichVu = LoaiDichVu;
            this.TenDichVu = TenDichVu;
            this.DonGia = DonGia;
            this.TonKho = TonKho;
        }
    }
}
