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
   public  class BUS_Kho
    {
        public static DataTable Hienthi_kho_all()
        {
            return DAO_Kho.HIENTHI_KHO_ALL();
        }
        public static DataTable laymakho()
        {
            return DAO_Kho.laymakho();
        }
        public static DataTable laytenkho()
        {
            return DAO_Kho.laytenkho();
        }
        public static DataTable hienthikhotheoma(string ma)
        {
            return DAO_Kho.hienthikhotheoma(ma);
        }
        public static DataTable hienthikhotheoten(string ten)
        {
            return DAO_Kho.hienthikhotheoten(ten);
        }
        //them
        //sua
        //xoa
        public static void Them_kho(DTO_Kho nv)
        {
            DAO_Kho.Themkho(nv);
        }
        public static void Sua_kho(DTO_Kho nv)
        {
            DAO_Kho.Suakho(nv);
        }
        public static void Xoa_kho(string nv)
        {
            DAO_Kho.Xoakho(nv);
        }
    }
}
