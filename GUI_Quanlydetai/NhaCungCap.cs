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
    public partial class NhaCungCap : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
        public NhaCungCap()
        {
            InitializeComponent();
        }
        // co ban // 
        private void loaddata()
        {
            dt = BUS_NCC.Hienthi_ncc_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {


            txtMaNCC.Text = gridView2.GetFocusedRowCellValue(colMaNCC).ToString();
            txtTenNCC.Text = gridView2.GetFocusedRowCellValue(colTenNCC).ToString();
            txtDiaChi.Text = gridView2.GetFocusedRowCellValue(colDiaChi).ToString();
            txtDienThoai.Text = gridView2.GetFocusedRowCellValue(colDienThoai).ToString();
            txtEmail.Text = gridView2.GetFocusedRowCellValue(colEmail).ToString();
            txtGhiChu.Text = gridView2.GetFocusedRowCellValue(colGhiChu).ToString();

        }
        //het co ban // 
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }

        private void cmbKey_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã nhà cung cấp")
                {
                    cmbKey.DataSource = BUS_NCC.laymancc();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaNCC";
                }

                else if (sl == "Tên nhà cung cấp")
                {
                    cmbKey.DataSource = BUS_NCC.laytenncc();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenNCC";

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

        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã nhà cung cấp")
                {


                    dt = BUS_NCC.hienthincctheoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên nhà cung cấp")
                {
                    dt = BUS_NCC.hienthincctheoten(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }
        //
        //
        //them
        //
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NCC sv = new DTO_NCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);

                BUS_NCC.Them_ncc(sv);
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
        //
        //sua
        //
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
               DTO_NCC sv = new DTO_NCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtGhiChu.Text);

               BUS_NCC.Sua_ncc(sv);
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
        //
        //XOA
        //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_NCC.Xoa_ncc(txtMaNCC.Text);
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
