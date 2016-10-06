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
    public partial class Kho : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
        public Kho()
        {
            InitializeComponent();
        }
        // co ban // 
        private void loaddata()
        {
            dt = BUS_Kho.Hienthi_kho_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {
            txtMaKho.Text = gridView2.GetFocusedRowCellValue(colMaKho).ToString();
            txtTenKho.Text = gridView2.GetFocusedRowCellValue(colTenKho).ToString();
        }
        //het co ban // 

        //sua kho
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
               DTO_Kho sv = new DTO_Kho(txtMaKho.Text, txtTenKho.Text);

               BUS_Kho.Sua_kho(sv);
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
        //loadform
        private void Kho_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }
        // forcusRowChange   :
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }
        //
        //
        //
        // combokeyclick :
        private void cmbKey_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã kho")
                {
                    cmbKey.DataSource = BUS_Kho.laymakho();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaKho";
                }

                else if (sl == "Tên kho")
                {
                    cmbKey.DataSource = BUS_Kho.laytenkho();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenKho";

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
            //BUTTON CLICK :
        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã kho")
                {


                    dt = BUS_Kho.hienthikhotheoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên kho")
                {
                    dt = BUS_Kho.hienthikhotheoten(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }
        // them kho :
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Kho sv = new DTO_Kho(txtMaKho.Text, txtTenKho.Text);

                BUS_Kho.Them_kho(sv);
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

        // xoa kho
        private void btnXoa_Click(object sender, EventArgs e)
        {
        
        
            try
            {
                BUS_Kho.Xoa_kho(txtMaKho.Text);
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
