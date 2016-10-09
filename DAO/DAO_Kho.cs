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
    public class DAO_Kho
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;
        public static DataTable HIENTHI_KHO_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHIKHO_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laymakho()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "laymakho").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laytenkho()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "laytenkho").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthikhotheoma(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthikhotheoma", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthikhotheoten(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthikhotheoten", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }

        // THEM
        public static void Themkho(DTO_Kho gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_KHO", gv.MaKho,gv.TenKho);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //SUA
        public static void Suakho(DTO_Kho gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_KHO", gv.MaKho, gv.TenKho);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //xoa
        public static void Xoakho(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_KHO", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
