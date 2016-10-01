using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace GUI_Quanlydetai.REPORT_DETAICHUADANGKI
{
    public partial class RE_DeTaiChuaDangKi : DevExpress.XtraReports.UI.XtraReport
    {
        public RE_DeTaiChuaDangKi()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            TENDT.DataMember="TENDT";
            NOIDUNG.DataMember="NOIDUNG";
            TENGV.DataMember = "TENGV";
            TENKHOA.DataMember="TENKHOA";
            lblDate.Text = string.Format("Hà Nội, Ngày {0} Tháng {1} Năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

        }

    }
}
