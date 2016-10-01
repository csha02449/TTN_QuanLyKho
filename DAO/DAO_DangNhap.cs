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
    public class DAO_DangNhap
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;
        public static void Them(DTO_DangNhap gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_DANGNHAP", gv.UserName, gv.PassWord, gv.Quyen);
            DAO_KetNoiDB.CloseConnect(con);
        }
        public static DataTable HIENTHI_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHIDANGNHAP_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static void Sua(DTO_DangNhap gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_DANGNHAP", gv.UserName, gv.PassWord,gv.Quyen);
            DAO_KetNoiDB.CloseConnect(con);
        }

        public static void Xoa(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_DANGNHAP", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }
        public static int Xacthuc(string username, string pass)
        {
            con = DAO_KetNoiDB.OpenConnect();
            int role = -1;
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_XACTHUC", username, pass).Tables[0];
            if (dt.Rows.Count > 0)
                role = (int)dt.Rows[0][0];
            DAO_KetNoiDB.CloseConnect(con);
            return role;
        }
    }
}
