using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TK
    {
        private string TenDangNhap, MatKhau;

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

        public string get_MatKhau
        {
            get
            {
                return MatKhau;
            }
            set
            {
                this.MatKhau = value;
            }
        }

        public DTO_TK(string TenDangNhap, string MatKhau)
        {
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
    }
}
