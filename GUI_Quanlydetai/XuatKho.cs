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
using DAO;
namespace GUI_Quanlydetai
{
    public partial class XuatKho : Form
    {
        public static SqlConnection con;
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
        public XuatKho()
        {
            InitializeComponent();
        }
        // co ban // 
        private void loaddata()
        {
            dt = BUS_XuatKho.Hienthi_xuatkho_all();
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
            txtMaHH.Text = gridView2.GetFocusedRowCellValue(colMaHH).ToString();
            txtTenHH.Text = gridView2.GetFocusedRowCellValue(colTenHH).ToString();
            txtMaKH.Text = gridView2.GetFocusedRowCellValue(colMaKH).ToString();
            txtTenKH.Text = gridView2.GetFocusedRowCellValue(colTenKH).ToString();
            txtSoPX.Text = gridView2.GetFocusedRowCellValue(colSoPX).ToString();
            txtSoLuongHH.Text = gridView2.GetFocusedRowCellValue(colSoLuong).ToString();
            txtNgayXuat.Text = gridView2.GetFocusedRowCellValue(colNgayXuat).ToString();
            txtNoiDung.Text = gridView2.GetFocusedRowCellValue(colNoiDung).ToString();

        }
        //het co ban // 
        private void XuatKho_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }
        //
        //
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindings();
        }

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
                //
                //
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
                //
                //
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

        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã hàng hóa")
                {


                    dt = BUS_XuatKho.hienthixuatkhotheomahanghoa(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên hàng hóa")
                {
                    dt = BUS_XuatKho.hienthixuatkhotheotentenhanghoa(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }
                //
                if (sl == "Mã khách hàng")
                {


                    dt = BUS_XuatKho.hienthixuatkhotheomakhachhang(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên khách hàng")
                {
                    dt = BUS_XuatKho.hienthixuatkhotheotenkhachhang(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }
                //
                //
                if (sl == "Mã kho")
                {


                    dt = BUS_XuatKho.hienthixuatkhotheomakho(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên kho")
                {
                    dt = BUS_XuatKho.hienthixuatkhotheotenkho(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }

            }
            catch (Exception ex)
            {
            }
        }
        //them
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
               DTO_XuatKho sv = new DTO_XuatKho(txtSoPX.Text, txtMaKho.Text, txtNgayXuat.Text, txtMaKH.Text,txtNoiDung.Text,txtMaHH.Text,txtSoLuongHH.Text);

               BUS_XuatKho.Them_xuatkho(sv);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_XuatKho sv = new DTO_XuatKho(txtSoPX.Text, txtMaKho.Text, txtNgayXuat.Text, txtMaKH.Text, txtNoiDung.Text, txtMaHH.Text, txtSoLuongHH.Text);
                BUS_XuatKho.Sua_xuatkho(sv);
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
                BUS_XuatKho.Xoa_xuatkho(txtSoPX.Text);
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
        //
        private void txtTenKho_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenKho.DataSource = BUS_Kho.laytenkho();
                //cmbKey.DisplayMember = "TENTD";
                txtTenKho.ValueMember = "TenKho";
            }
            catch (Exception ex)
            {

            }
        }
        //
        private void txtTenHH_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenHH.DataSource = BUS_HangHoa.laytenhh();
                //cmbKey.DisplayMember = "TENTD";
                txtTenHH.ValueMember = "TenHH";
            }
            catch (Exception ex)
            {

            }
        }

        private void txtTenKH_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenKH.DataSource = BUS_KhachHang.laytenkhachhang();
                //cmbKey.DisplayMember = "TENTD";
                txtTenKH.ValueMember = "TenKH";
            }
            catch (Exception ex)
            {

            }
        }
        //
        //dang sua chua xong
        private void txtMaKho_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text != " ")
            {
                con=DAO_KetNoiDB.OpenConnect();
                string s1 = txtTenKho.Text;
                string s2 = SqlHelper.ExecuteScalar(con,"hienthitenthanhmakh",s1).ToString();
                txtMaKho.Text = s2;
            }
            else txtMaKho.Text = " ";
        }

        private void txtMaHH_Click(object sender, EventArgs e)
        {
            if (txtTenHH.Text != " ")
            {
                con = DAO_KetNoiDB.OpenConnect();
                string s1 = txtTenHH.Text;
                string s2 = SqlHelper.ExecuteScalar(con, "hienthitenthanhmahangho", s1).ToString();
                txtMaHH.Text = s2;
            }
            else txtMaKho.Text = " ";
        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != " ")
            {
                con = DAO_KetNoiDB.OpenConnect();
                string s1 = txtTenKH.Text;
                string s2 = SqlHelper.ExecuteScalar(con, "hienthitenthanhmakhachhang", s1).ToString();
                txtMaKH.Text = s2;
            }
            else txtMaKho.Text = " ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
        //

    }
}
