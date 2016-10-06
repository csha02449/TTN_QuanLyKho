using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DTO;

namespace DAO
{
   public class DAO_NCC
   {
       public static SqlConnection con;
       public static DataSet ds;
       public static DataTable dt;
       public static IDataAdapter da;

       public static DataTable HIENTHI_NCC_ALL()
       {
           con = DAO_KetNoiDB.OpenConnect();
           dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHINCC_ALL").Tables[0];
           DAO_KetNoiDB.CloseConnect(con);
           return dt;
       }
       public static DataTable laymaNCC()
       {
           con = DAO_KetNoiDB.OpenConnect();
           dt = SqlHelper.ExecuteDataset(con, "laymaNCC").Tables[0];
           DAO_KetNoiDB.CloseConnect(con);
           return dt;
       }
       public static DataTable laytenNCC()
       {
           con = DAO_KetNoiDB.OpenConnect();
           dt = SqlHelper.ExecuteDataset(con, "laytenNCC").Tables[0];
           DAO_KetNoiDB.CloseConnect(con);
           return dt;
       }
       public static DataTable hienthiNCCtheoma(string ma)
       {
           con = DAO_KetNoiDB.OpenConnect();
           dt = SqlHelper.ExecuteDataset(con, "hienthiNCCtheoma", ma).Tables[0];
           DAO_KetNoiDB.CloseConnect(con);
           return dt;
       }
       public static DataTable hienthiNCCtheoten(string ten)
       {
           con = DAO_KetNoiDB.OpenConnect();
           dt = SqlHelper.ExecuteDataset(con, "hienthiNCCtheoten", ten).Tables[0];
           DAO_KetNoiDB.CloseConnect(con);
           return dt;
       }

       // THEM
       public static void ThemNCC(DTO_NCC gv)
       {
           con = DAO_KetNoiDB.OpenConnect();
           SqlHelper.ExecuteNonQuery(con, "PR_THEM_NCC", gv.MaNCC,gv.TenNCC,gv.DiaChi,gv.DienThoai,gv.Email,gv.GhiChu);
           DAO_KetNoiDB.CloseConnect(con);
       }
       //SUA
       public static void SuaNCC(DTO_NCC gv)
       {
           con = DAO_KetNoiDB.OpenConnect();
           SqlHelper.ExecuteNonQuery(con, "PR_SUA_NCC", gv.MaNCC, gv.TenNCC, gv.DiaChi, gv.DienThoai, gv.Email, gv.GhiChu);
           DAO_KetNoiDB.CloseConnect(con);
       }
       //xoa
       public static void XoaNCC(string gv)
       {
           con = DAO_KetNoiDB.OpenConnect();
           SqlHelper.ExecuteNonQuery(con, "PR_XOA_NCC", gv);
           DAO_KetNoiDB.CloseConnect(con);
       }
    }
}
