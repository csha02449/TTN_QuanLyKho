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
    public class DAO_HangHoa
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;
        public static DataTable HIENTHI_HH_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHIHH_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laymahanghoa()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "laymahanghoa").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laytenhanghoa()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "laytenhanghoa").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthihanghoatheoma(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthihanghoatheoma", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthihanghoatheoten(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthihanghoatheoten", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }

        // THEM
        public static void Themhanghoa(DTO_HangHoa gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_HH", gv.MaHH, gv.TenHH,gv.DVT);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //SUA
        public static void Suahanghoa(DTO_HangHoa gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_HH", gv.MaHH, gv.TenHH, gv.DVT);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //xoa
        public static void Xoahanghoa(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_HH", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
