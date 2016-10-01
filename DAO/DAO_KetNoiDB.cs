using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
   public class DAO_KetNoiDB
    {
        public static SqlConnection OpenConnect()
        {
            string ChuoiKetNoi = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
            SqlConnection con = new SqlConnection(ChuoiKetNoi);
            con.Open();
            return con;

        }
        public static void CloseConnect(SqlConnection con)
        {
            con.Close();
        }
        public static DataTable GetDataTable(SqlCommand cmd)
        {
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }
        public static void Thucthi(string sTruyVan, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(sTruyVan, con);
            com.CommandType = CommandType.StoredProcedure;
            com.ExecuteNonQuery();
        }
    }
}
