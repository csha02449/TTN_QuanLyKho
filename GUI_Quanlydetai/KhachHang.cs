using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.ApplicationBlocks.Data;
namespace GUI_Quanlydetai
{
    public partial class KhachHang : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
        public KhachHang()
        {
            InitializeComponent();
        }

        // co ban // 
        private void loaddata()
        {
            dt = BUS_KhachHang.Hienthi_khachhang_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {


            txtMaKH.Text = gridView2.GetFocusedRowCellValue(colMaKH).ToString();
            txtTenKH.Text = gridView2.GetFocusedRowCellValue(colTenKH).ToString();
            txtDiaChi.Text = gridView2.GetFocusedRowCellValue(colDiaChi).ToString();
            txtDienThoai.Text = gridView2.GetFocusedRowCellValue(colDienThoai).ToString();
            txtEmail.Text = gridView2.GetFocusedRowCellValue(colEmail).ToString();
            txtGhiChu.Text = gridView2.GetFocusedRowCellValue(colGhiChu).ToString();

        }
        //het co ban // 
        private void KhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        //forcusRowChange
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }
        //
        //
        //
        // combokey-click;
        private void cmbKey_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã khách hàng")
                {
                    cmbKey.DataSource = BUS_KhachHang.laymakhachhang();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaKH";
                }

                else if (sl == "Tên khách hàng")
                {
                    cmbKey.DataSource = BUS_KhachHang.laytenkhachhang();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenKH";

                }
                else
                {
                    cmbKey.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        //
        //
        //
        // button click ;;;
        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã khách hàng")
                {


                    dt = BUS_KhachHang.hienthikhachhangtheoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên khách hàng")
                {
                    dt = BUS_KhachHang.hienthikhachhangtheoten(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }
        // them
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KhachHang sv = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);

                BUS_KhachHang.Them_khachhang(sv);
                DialogResult dr = MessageBox.Show("Them thanh Cong", "Thông Báo", MessageBoxButtons.OK);
                loaddata();
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!\n" + ex.Message);
            }
        }
        //sua khach hang
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KhachHang sv = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);

                BUS_KhachHang.Sua_khachhang(sv);
                DialogResult dr = MessageBox.Show("Sua thanh Cong", "Thông Báo", MessageBoxButtons.OK);
                loaddata();
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua không thành công!\n" + ex.Message);
            }
        }
        //xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_KhachHang.Xoa_khachhang(txtMaKH.Text);
                DialogResult dr = MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi");
            }
        }


    }
}
