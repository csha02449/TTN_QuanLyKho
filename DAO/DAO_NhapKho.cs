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
    public class DAO_NhapKho
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;
        public static DataTable HIENTHI_NHAPKHO_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHINHAPKHO_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }

        public static DataTable hienthinhapkhotheomakho(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthinhapkhotheomakho", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthinhapkhotheotenkho(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthinhapkhotheotenkho", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthinhapkhotheomahanghoa(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthinhapkhotheomahanghoa", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthinhapkhotheotenhanghoa(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthinhapkhotheotenhanghoa", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthinhapkhotheomanguoicungcap(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthinhapkhotheomanguoicungcap", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthinhapkhotheotennguoicungcap(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthinhapkhotheotennguoicungcap", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        //
        //
        public static DataTable hienthitenthanhmanhacungcap(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthitenthanhmanhacungcap", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthitenthanhmakho(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthitenthanhmakho", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthitenthanhmahanghoa(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthitenthanhmahanghoa", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        //
        //
        // THEM
        public static void Themnhapkho(DTO_NhapKho gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_NHAPKHO", gv.SoPN, gv.MaKho, gv.NgayNhap, gv.MaNCC, gv.NoiDung ,gv.MaHH,  gv.SoLuong);
            DAO_KetNoiDB.CloseConnect(con); 
        }
        //SUA
        public static void Suanhapkho(DTO_NhapKho gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_NHAPKHO", gv.SoPN, gv.MaKho, gv.NgayNhap, gv.MaNCC, gv.NoiDung, gv.MaHH, gv.SoLuong);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //xoa
        public static void Xoanhapkho(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_NHAPKHO", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
