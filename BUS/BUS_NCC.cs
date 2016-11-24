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
    public class BUS_NCC
    {
        public static DataTable Hienthi_ncc_all()
        {
            return DAO_NCC.HIENTHI_NCC_ALL();
        }
        public static DataTable laymancc()
        {
            return DAO_NCC.laymaNCC();
        }
        public static DataTable laytenncc()
        {
            return DAO_NCC.laytenNCC();
        }
        public static DataTable hienthincctheoma(string ma)
        {
            return DAO_NCC.hienthiNCCtheoma(ma);
        }
        public static DataTable hienthincctheoten(string ten)
        {
            return DAO_NCC.hienthiNCCtheoten(ten);
        }
        //them
        //sua
        //xoa
        public static void Them_ncc(DTO_NCC nv)
        {
            DAO_NCC.ThemNCC(nv);
        }
        public static void Sua_ncc(DTO_NCC nv)
        {
            DAO_NCC.SuaNCC(nv);
        }
        public static void Xoa_ncc(string nv)
        {
            DAO_NCC.XoaNCC(nv);
        }
    }
}
