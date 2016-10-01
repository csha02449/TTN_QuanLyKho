using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace GUI_Quanlydetai.REPORT_CHITIETTIEUBAN
{
    public partial class REPORT_CHITIETTIEUBAN : DevExpress.XtraReports.UI.XtraReport
    {
        public REPORT_CHITIETTIEUBAN()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            TENDT.DataMember = "TENDT";
            TEN.DataMember = "TEN";
            lblDate.Text = string.Format("Hà Nội, Ngày {0} Tháng {1} Năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);    
            lblTitle.DataBindings.Add("Text", DataSource, "TENHD");
            
        }


    }
}
