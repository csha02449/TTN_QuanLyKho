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
    public partial class TaiKhoan : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLINHANSU;Integrated Security=True";
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            dt = BUS_DangNhap.Hienthi_dangnhap_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {


            txtUserName.Text = gridView2.GetFocusedRowCellValue(colUserName).ToString();
            txtPassWord.Text = gridView2.GetFocusedRowCellValue(colPassWord).ToString();
            //txtQuyen.Text = gridView2.GetFocusedRowCellValue(colQuyen).ToString();
            


        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }
        // THEM
        int vaitro;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbVaiTro.Text == "Quản trị viên")
                vaitro = 1;
            if (cmbVaiTro.Text == "Nhân viên")
                vaitro = 2;
            if (cmbVaiTro.Text == "Khách")
                vaitro = 3;
            try
            {
                DTO_DangNhap sv = new DTO_DangNhap(txtUserName.Text, txtPassWord.Text,vaitro);

                BUS_DangNhap.Them_dangnhap(sv);
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
        //SUA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbVaiTro.Text == "Quản trị viên")
                vaitro = 1;
            if (cmbVaiTro.Text == "Nhân viên")
                vaitro = 2;
            if (cmbVaiTro.Text == "Khách")
                vaitro = 3;
            try
            {
                DTO_DangNhap sv = new DTO_DangNhap(txtUserName.Text, txtPassWord.Text, vaitro);

                BUS_DangNhap.Sua_dangnhap(sv);
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
        //XOA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_DangNhap.Xoa_dangnhap(txtUserName.Text);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            try
            {
                bindings();
                string q = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Quyen").ToString();
                if (q == "1")
                {
                    cmbVaiTro.Text = "Quản trị viên";
                }
                if(q == "2")
                {
                    cmbVaiTro.Text = "Nhân viên";
                }
                if (q == "3")
                {
                    cmbVaiTro.Text = "Khách";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu!\n" + ex.Message);
            }
        }
    }
}
