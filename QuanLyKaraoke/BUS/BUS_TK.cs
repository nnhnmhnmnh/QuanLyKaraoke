using DAL;
using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TK
    {
        DAL_TK TaiKhoan;

        public BUS_TK(string TenDangNhap, string MatKhau)
        {
            TaiKhoan = new DAL_TK(TenDangNhap, MatKhau);
        }

        //public bool checkAccount(string username, string password)
        //{
        //    List<DTO_TK> danhSachTaiKhoan = TaiKhoan.selectAcount();
        //    foreach (DTO_TK taiKhoan in danhSachTaiKhoan)
        //    {
        //        if (taiKhoan.get_TenDangNhap == username && taiKhoan.get_MatKhau == password)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public string checkLogin(string TenDangNhap, string MatKhau) 
        {
            //if (TK.get_TenDangNhap != "" && TK.get_MatKhau != "") 
            if (TenDangNhap != "" && MatKhau != "")
            {
                List<DTO_TK> danhSachTaiKhoan = TaiKhoan.selectAcount();
                foreach (DTO_TK taiKhoan in danhSachTaiKhoan)
                {
                    if (taiKhoan.get_TenDangNhap == TenDangNhap && taiKhoan.get_MatKhau == MatKhau)
                    {
                        if (taiKhoan.get_TenDangNhap == "admin")
                        {
                            return "Admin";
                        }
                        if (taiKhoan.get_TenDangNhap == "tieptan")
                        {
                            return "Tiếp tân";
                        }
                        if (taiKhoan.get_TenDangNhap == "phucvu")
                        {
                            return "Phục vụ";
                        }
                        if (taiKhoan.get_TenDangNhap == "quanlykho")
                        {
                            return "Quản lý kho";
                        }
                        return "Successful";
                    }
                }
                return "Fail";
            }
            if (TenDangNhap == "")
            {
                return "null UN";
            }
            return "null PW";
        }

        public bool checkExistTenDN()
        {
            DataTable dt = TaiKhoan.selectCount();
            if (dt.Rows.Count > 0 )
            { 
                return true; 
            }
            return false;
        }

        public void addQuery()
        {
            TaiKhoan.addQuery();
        }

        public string updateQuery(string TenDN, string MK, string MKMoi, string XacNhanMK)
        {
            if (TenDN == "" || MK == "" || MKMoi == "" || XacNhanMK == "")
            {
                return "null";
            }
            List<DTO_TK> danhSachTaiKhoan = TaiKhoan.selectAcount();
            foreach (DTO_TK taiKhoan in danhSachTaiKhoan)
            {
                if (taiKhoan.get_TenDangNhap == TenDN && taiKhoan.get_MatKhau == MK)
                {
                    if (MK == MKMoi)
                    {
                        return "Duplicate";
                    }
                    if (MKMoi != XacNhanMK)
                    {
                        return "Wrong confirm";
                    }
                    TaiKhoan.updateQuery(TenDN, MKMoi);
                    return "Successful";
                }
            }
            return "Fail";
        }
    }
}
