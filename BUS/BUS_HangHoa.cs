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
    public class BUS_HangHoa
    {
        public static DataTable Hienthi_HH_all()
        {
            return DAO_HangHoa.HIENTHI_HH_ALL();
        }
        public static DataTable laymahh()
        {
            return DAO_HangHoa.laymahanghoa();
        }
        public static DataTable laytenhh()
        {
            return DAO_HangHoa.laytenhanghoa();
        }
        public static DataTable hienthihhtheoma(string ma)
        {
            return DAO_HangHoa.hienthihanghoatheoma(ma);
        }
        public static DataTable hienthihhtheoten(string ten)
        {
            return DAO_HangHoa.hienthihanghoatheoten(ten);
        }
        //them
        //sua
        //xoa
        public static void Them_hh(DTO_HangHoa nv)
        {
            DAO_HangHoa.Themhanghoa(nv);
        }
        public static void Sua_hh(DTO_HangHoa nv)
        {
            DAO_HangHoa.Suahanghoa(nv);
        }
        public static void Xoa_hh(string nv)
        {
            DAO_HangHoa.Xoahanghoa(nv);
        }
    }
}
