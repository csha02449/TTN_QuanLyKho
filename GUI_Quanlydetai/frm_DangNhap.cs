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
namespace GUI_Quanlydetai
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }


        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quyen = BUS_DangNhap.Xacthuc(txtUsername.Text, txtPassword.Text);
            //MAIN frm = new MAIN(quyen);

            if (quyen != -1)
            {

                MAIN frm = new MAIN(quyen);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                base.OnShown(e);
            }
        }

        private void frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
