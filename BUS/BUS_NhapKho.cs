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
    public class BUS_NhapKho
    {
        public static DataTable Hienthi_nhapkho_all()
        {
            return DAO_NhapKho.HIENTHI_NHAPKHO_ALL();
        }

        public static DataTable hienthinhapkhotheomakho(string ma)
        {
            return DAO_NhapKho.hienthinhapkhotheomakho(ma);
        }
        public static DataTable hienthinhapkhotheotenkho(string ten)
        {
            return DAO_NhapKho.hienthinhapkhotheotenkho(ten);
        }
        public static DataTable hienthinhapkhotheomahanghoa(string ma)
        {
            return DAO_NhapKho.hienthinhapkhotheomahanghoa(ma);
        }
        public static DataTable hienthinhapkhotheotentenhanghoa(string ten)
        {
            return DAO_NhapKho.hienthinhapkhotheotenhanghoa(ten);
        }
        public static DataTable hienthinhapkhotheomanguoicungcap(string ma)
        {
            return DAO_NhapKho.hienthinhapkhotheomanguoicungcap(ma);
        }
        public static DataTable hienthinhapkhotheotennguoicungcap(string ten)
        {
            return DAO_NhapKho.hienthinhapkhotheotennguoicungcap(ten);
        }
        //
        //
        public static DataTable hienthitenthanhmanguoicungcap(string ten)
        {
            return DAO_NhapKho.hienthitenthanhmanhacungcap(ten);
        }
        public static DataTable hienthitenthanhmakho(string ten)
        {
            return DAO_NhapKho.hienthitenthanhmakho(ten);
        }
        public static DataTable hienthitenthanhmahanghoa(string ten)
        {
            return DAO_NhapKho.hienthitenthanhmahanghoa(ten);
        }
        //
        //
   
        //them
        //sua
        //xoa
        public static void Them_nhapkho(DTO_NhapKho nv)
        {
            DAO_NhapKho.Themnhapkho(nv);
        }
        public static void Sua_nhapkho(DTO_NhapKho nv)
        {
            DAO_NhapKho.Suanhapkho(nv);
        }
        public static void Xoa_nhapkho(string nv)
        {
            DAO_NhapKho.Xoanhapkho(nv);
        }
    }
}
