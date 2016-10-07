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
    public partial class HangHoa : Form
    {
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
        public HangHoa()
        {
            InitializeComponent();
        }
        // co ban // 
        private void loaddata()
        {
            dt = BUS_HangHoa.Hienthi_HH_all();
            grdGiangVien.DataSource = dt;

        }
        private void loaddata1(DataTable dt)
        {

            grdGiangVien.DataSource = dt;
        }
        private void bindings()
        {


            txtMaHH.Text = gridView2.GetFocusedRowCellValue(colMaHH).ToString();
            txtTenHH.Text = gridView2.GetFocusedRowCellValue(colTenHH).ToString();
            txtDVT.Text = gridView2.GetFocusedRowCellValue(colDVT).ToString();


        }
        //het co ban // 
        private void label16_Click(object sender, EventArgs e)
        {

        }
        //loadfrom
        private void HangHoa_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }
        //forcusRowChange
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }
        // combokey click
        private void cmbKey_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                if (sl == "Mã hàng hóa")
                {
                    cmbKey.DataSource = BUS_HangHoa.laymahh();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "MaHH";
                }

                else if (sl == "Tên hàng hóa")
                {
                    cmbKey.DataSource = BUS_HangHoa.laytenhh();
                    //cmbKey.DisplayMember = "TENTD";
                    cmbKey.ValueMember = "TenHH";

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
        // BUTTON CLICK
        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã hàng hóa")
                {


                    dt = BUS_HangHoa.hienthihhtheoma(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên hàng hóa")
                {
                    dt = BUS_HangHoa.hienthihhtheoten(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }

        //
        // them
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HangHoa sv = new DTO_HangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text);

                BUS_HangHoa.Them_hh(sv);
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
                DTO_HangHoa sv = new DTO_HangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text);

                BUS_HangHoa.Sua_hh(sv);
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
        //xoa
        //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_HangHoa.Xoa_hh(txtMaHH.Text);
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
