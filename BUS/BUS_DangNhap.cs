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
    public class BUS_DangNhap
    {
        public static DataTable Hienthi_dangnhap_all()
        {
            return DAO_DangNhap.HIENTHI_ALL();
        }
        public static void Them_dangnhap(DTO_DangNhap nv)
        {
            DAO_DangNhap.Them(nv);
        }
        public static void Sua_dangnhap(DTO_DangNhap nv)
        {
            DAO_DangNhap.Sua(nv);
        }
        public static void Xoa_dangnhap(string gv)
        {
            DAO_DangNhap.Xoa(gv);
        }
        public static int Xacthuc(string ten, string mk)
        {
            return DAO_DangNhap.Xacthuc(ten,mk);
        }
    }
}
