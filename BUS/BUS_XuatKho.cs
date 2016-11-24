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
    public class BUS_XuatKho
    {
        public static DataTable Hienthi_xuatkho_all()
        {
            return DAO_XuatKho.HIENTHI_XUATKHO_ALL();
        }

        public static DataTable hienthixuatkhotheomakho(string ma)
        {
            return DAO_XuatKho.hienthixuatkhotheomakho(ma);
        }
        public static DataTable hienthixuatkhotheotenkho(string ten)
        {
            return DAO_XuatKho.hienthixuatkhotheotenkho(ten);
        }
        public static DataTable hienthixuatkhotheomahanghoa(string ma)
        {
            return DAO_XuatKho.hienthixuatkhotheomahanghoa(ma);
        }
        public static DataTable hienthixuatkhotheotentenhanghoa(string ten)
        {
            return DAO_XuatKho.hienthixuatkhotheotenhanghoa(ten);
        }
        public static DataTable hienthixuatkhotheomakhachhang(string ma)
        {
            return DAO_XuatKho.hienthixuatkhotheomakhachhang(ma);
        }
        public static DataTable hienthixuatkhotheotenkhachhang(string ten)
        {
            return DAO_XuatKho.hienthixuatkhotheotenkhachhang(ten);
        }
        //
        //
        public static DataTable hienthitenthanhmankhachhang(string ten)
        {
            return DAO_XuatKho.hienthitenthanhmakhachhang(ten);
        }
        public static DataTable hienthitenthanhmakho(string ten)
        {
            return DAO_XuatKho.hienthitenthanhmakho(ten);
        }
        public static DataTable hienthitenthanhmahanghoa(string ten)
        {
            return DAO_XuatKho.hienthitenthanhmahanghoa(ten);
        }
        //
        //

        //them
        //sua
        //xoa
        public static void Them_xuatkho(DTO_XuatKho nv)
        {
            DAO_XuatKho.Themxuatkho(nv);
        }
        public static void Sua_xuatkho(DTO_XuatKho nv)
        {
            DAO_XuatKho.Suaxuatkho(nv);
        }
        public static void Xoa_xuatkho(string nv)
        {
            DAO_XuatKho.Xoaxuatkho(nv);
        }
    }
}
