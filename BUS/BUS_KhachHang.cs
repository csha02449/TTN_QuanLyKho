using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_KhachHang
    {
        public static DataTable Hienthi_khachhang_all()
        {
            return DAO_KhachHang.HIENTHI_ALL();
        }
        public static DataTable laymakhachhang()
        {
            return DAO_KhachHang.laymakhachhang();
        }
        public static DataTable laytenkhachhang()
        {
            return DAO_KhachHang.laytenkhachhang();
        }
        public static DataTable hienthikhachhangtheoma(string ma)
        {
            return DAO_KhachHang.hienthikhachhangtheoma(ma);
        }
        public static DataTable hienthikhachhangtheoten(string ten)
        {
            return DAO_KhachHang.hienthikhachhangtheoten(ten);
        }
        //them
        //sua
        //xoa
        public static void Them_khachhang(DTO_KhachHang nv)
        {
            DAO_KhachHang.Themkhachhang(nv);
        }
        public static void Sua_khachhang(DTO_KhachHang nv)
        {
            DAO_KhachHang.Suakhachhang(nv);
        }
        public static void Xoa_khachhang(string nv)
        {
            DAO_KhachHang.Xoakhachhang(nv);
        }

    }
}
