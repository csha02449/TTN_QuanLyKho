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
    public partial class NhapKho : Form
    {
        public static SqlConnection con;
        public DataTable dt;
        public int quyen;
        public string strcon = @"Data Source=ADMINISTRATOR\SQLEXPRESS;Initial Catalog=QUANLYKHO;Integrated Security=True";
        public NhapKho()
        {
            InitializeComponent();
        }
        // co ban // 
        private void loaddata()
        {
            dt = BUS_NhapKho.Hienthi_nhapkho_all();
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
            txtMaNCC.Text = gridView2.GetFocusedRowCellValue(colMaNCC).ToString();
            txtTenNCC.Text = gridView2.GetFocusedRowCellValue(colTenNCC).ToString();
            txtSoPN.Text = gridView2.GetFocusedRowCellValue(colSoPN).ToString();
            txtSoLuongHH.Text = gridView2.GetFocusedRowCellValue(colSoLuong).ToString();
            txtNgayNhap.Text = gridView2.GetFocusedRowCellValue(colNgayNhap).ToString();
            txtNoiDung.Text = gridView2.GetFocusedRowCellValue(colNoiDung).ToString();

        }
        //het co ban // 
        private void NhapKho_Load(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {
            string sl = cboTimKiem.Text;
            try
            {
                //  sl = sl.Replace();

                if (sl == "Mã hàng hóa")
                {


                    dt = BUS_NhapKho.hienthinhapkhotheomahanghoa(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên hàng hóa")
                {
                    dt = BUS_NhapKho.hienthinhapkhotheotentenhanghoa(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }
                //
                if (sl == "Mã nhà cung cấp")
                {


                    dt = BUS_NhapKho.hienthinhapkhotheomanguoicungcap(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên nhà cung cấp")
                {
                    dt = BUS_NhapKho.hienthinhapkhotheotennguoicungcap(cmbKey.Text);
                    loaddata1(dt);
                    bindings();

                }
                //
                //
                if (sl == "Mã kho")
                {


                    dt = BUS_NhapKho.hienthinhapkhotheomakho(cmbKey.Text);
                    loaddata1(dt);
                    bindings();
                }
                else if (sl == "Tên kho")
                {
                    dt = BUS_NhapKho.hienthinhapkhotheotenkho(cmbKey.Text);
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhapKho sv = new DTO_NhapKho(txtMaKho.Text, txtMaHH.Text, txtMaNCC.Text, txtSoPN.Text, txtSoLuongHH.Text, txtNgayNhap.Text, txtNoiDung.Text);

                BUS_NhapKho.Them_nhapkho(sv);
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
                DTO_NhapKho sv = new DTO_NhapKho(txtMaKho.Text, txtMaHH.Text, txtMaNCC.Text, txtSoPN.Text, txtSoLuongHH.Text, txtNgayNhap.Text, txtNoiDung.Text);
                BUS_NhapKho.Sua_nhapkho(sv);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_NhapKho.Xoa_nhapkho(txtSoPN.Text);
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

        private void txtTenKho_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenKho.DataSource = BUS_Kho.laytenkho();
                //cmbKey.DisplayMember = "TENTD";
                txtTenKho.ValueMember = "TenKho";

                //
                //


            }
            catch (Exception ex)
            {

            }
        }

        private void txtTenHH_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenHH.DataSource = BUS_HangHoa.laytenhh();
                //cmbKey.DisplayMember = "TENTD";
                txtTenHH.ValueMember = "TenHH";


                //

            }
            catch (Exception ex)
            {

            }
        }

        private void txtTenNCC_Click(object sender, EventArgs e)
        {
            try
            {

                txtTenNCC.DataSource = BUS_NCC.laytenncc();
                //cmbKey.DisplayMember = "TENTD";
                txtTenNCC.ValueMember = "TenNCC";
                //
                //

            }
            catch (Exception ex)
            {

            }
        }
        //
        //
        // dang sua
        private void txtMaKho_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text != " ")
            {
                con = DAO_KetNoiDB.OpenConnect();
                string s1 = txtTenKho.Text;
                string s2 = SqlHelper.ExecuteScalar(con, "hienthitenthanhmakho", s1).ToString();
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
                string s2 = SqlHelper.ExecuteScalar(con, "hienthitenthanhmahanghoa", s1).ToString();
                txtMaHH.Text = s2;
            }
            else txtMaKho.Text = " ";
        }

        private void txtMaNCC_Click(object sender, EventArgs e)
        {
            //
            if (txtTenNCC.Text != " ")
            {
                con = DAO_KetNoiDB.OpenConnect();
                string s1 = txtTenNCC.Text;
                string s2 = SqlHelper.ExecuteScalar(con, "hienthitenthanhmanhacungcap", s1).ToString();
                txtMaNCC.Text = s2;
            }
            else txtMaKho.Text = " ";
        }

        private void grdGiangVien_Click(object sender, EventArgs e)
        {

        }
    }
}
