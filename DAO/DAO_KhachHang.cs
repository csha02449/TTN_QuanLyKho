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
    public class DAO_KhachHang
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static IDataAdapter da;
        public static DataTable HIENTHI_ALL()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHIKHACHHANG_ALL").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laymakhachhang()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "laymakhachhang").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable laytenkhachhang()
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "laytenkhachhang").Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthikhachhangtheoma(string ma)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthikhachhangtheoma",ma).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }
        public static DataTable hienthikhachhangtheoten(string ten)
        {
            con = DAO_KetNoiDB.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "hienthikhachhangtheoten",ten).Tables[0];
            DAO_KetNoiDB.CloseConnect(con);
            return dt;
        }

        // THEM
        public static void Themkhachhang(DTO_KhachHang gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_THEM_KHACHHANG", gv.MaKH, gv.TenKH, gv.DiaChi,gv.DienThoai,gv.Email,gv.GhiChu);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //SUA
        public static void Suakhachhang(DTO_KhachHang gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_SUA_KHACHHANG", gv.MaKH, gv.TenKH, gv.DiaChi, gv.DienThoai, gv.Email, gv.GhiChu);
            DAO_KetNoiDB.CloseConnect(con);
        }
        //xoa
        public static void Xoakhachhang(string gv)
        {
            con = DAO_KetNoiDB.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_XOA_KHACHHANG", gv);
            DAO_KetNoiDB.CloseConnect(con);
        }
    }
}
