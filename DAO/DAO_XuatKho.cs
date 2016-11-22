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
    public class DAO_XuatKho
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;
        public static DataTable HIENTHI_XUATKHO_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHIXUATKHO_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }

        public static DataTable hienthixuatkhotheomakho(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthixuatkhotheomakho", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthixuatkhotheotenkho(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthixuatkhotheotenkho", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthixuatkhotheomahanghoa(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthixuatkhotheomahanghoa", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthixuatkhotheotenhanghoa(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthixuatkhotheotenhanghoa", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthixuatkhotheomakhachhang(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthixuatkhotheomakhachhang", ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthixuatkhotheotenkhachhang(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthixuatkhotheotenkhachhang", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        //
        //
        public static DataTable hienthitenthanhmakhachhang(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthitenthanhmakhachhang", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthitenthanhmakho(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthitenthanhmakh", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthitenthanhmahanghoa(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthitenthanhmahangho", ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        //
        //
        // THEM
        public static void Themxuatkho(DTO_XuatKho gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_XUATKHO", gv.SoPX, gv.MaKho, gv.NgayXuat, gv.MaKH, gv.NoiDung, gv.MaHH, gv.SoLuong);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //SUA
        public static void Suaxuatkho(DTO_XuatKho gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_XUATKHO", gv.SoPX, gv.MaKho, gv.NgayXuat, gv.MaKH, gv.NoiDung, gv.MaHH, gv.SoLuong);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //xoa
        public static void Xoaxuatkho(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_XUATKHO", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
