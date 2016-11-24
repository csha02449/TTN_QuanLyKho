namespace GUI_Quanlydetai
{
    partial class NhapKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdGiangVien = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongHH = new System.Windows.Forms.TextBox();
            this.txtTenKho = new System.Windows.Forms.ComboBox();
            this.txtTenHH = new System.Windows.Forms.ComboBox();
            this.txtTenNCC = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtSoPN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdGiangVien);
            this.groupBox1.Controls.Add(this.navBarControl1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 510);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // grdGiangVien
            // 
            this.grdGiangVien.DataMember = "CustomSqlQuery";
            this.grdGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGiangVien.Location = new System.Drawing.Point(3, 16);
            this.grdGiangVien.MainView = this.gridView2;
            this.grdGiangVien.Name = "grdGiangVien";
            this.grdGiangVien.Size = new System.Drawing.Size(507, 491);
            this.grdGiangVien.TabIndex = 36;
            this.grdGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            this.grdGiangVien.Click += new System.EventHandler(this.grdGiangVien_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKho,
            this.colTenKho,
            this.colMaHH,
            this.colTenHH,
            this.colMaNCC,
            this.colTenNCC,
            this.colSoPN,
            this.colSoLuong,
            this.colNgayNhap,
            this.colNoiDung});
            this.gridView2.GridControl = this.grdGiangVien;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindDelay = 100;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 0;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 1;
            // 
            // colMaHH
            // 
            this.colMaHH.Caption = "Mã Hàng Hóa";
            this.colMaHH.FieldName = "MaHH";
            this.colMaHH.Name = "colMaHH";
            this.colMaHH.Visible = true;
            this.colMaHH.VisibleIndex = 2;
            // 
            // colTenHH
            // 
            this.colTenHH.Caption = "Tên Hàng Hóa";
            this.colTenHH.FieldName = "TenHH";
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.Visible = true;
            this.colTenHH.VisibleIndex = 3;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Mã Người Cung Cấp";
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 4;
            // 
            // colTenNCC
            // 
            this.colTenNCC.Caption = "Tên Người Cung Cấp";
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 5;
            // 
            // colSoPN
            // 
            this.colSoPN.Caption = "Số Phiếu Nhập";
            this.colSoPN.FieldName = "SoPN";
            this.colSoPN.Name = "colSoPN";
            this.colSoPN.Visible = true;
            this.colSoPN.VisibleIndex = 6;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng Hàng Hóa";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 7;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Caption = "Ngày Nhập";
            this.colNgayNhap.FieldName = "NgayNhap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 8;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Caption = "Nội Dung";
            this.colNoiDung.FieldName = "NoiDung";
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.Visible = true;
            this.colNoiDung.VisibleIndex = 9;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdGiangVien;
            this.gridView1.Name = "gridView1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(510, 16);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 470;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(470, 491);
            this.navBarControl1.TabIndex = 35;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Thông tin";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 371;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.groupBox2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(470, 388);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoLuongHH);
            this.groupBox2.Controls.Add(this.txtTenKho);
            this.groupBox2.Controls.Add(this.txtTenHH);
            this.groupBox2.Controls.Add(this.txtTenNCC);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.txtNoiDung);
            this.groupBox2.Controls.Add(this.txtMaNCC);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtNgayNhap);
            this.groupBox2.Controls.Add(this.txtSoPN);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtMaHH);
            this.groupBox2.Controls.Add(this.txtMaKho);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 368);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // txtSoLuongHH
            // 
            this.txtSoLuongHH.Location = new System.Drawing.Point(316, 207);
            this.txtSoLuongHH.Name = "txtSoLuongHH";
            this.txtSoLuongHH.Size = new System.Drawing.Size(133, 20);
            this.txtSoLuongHH.TabIndex = 87;
            // 
            // txtTenKho
            // 
            this.txtTenKho.FormattingEnabled = true;
            this.txtTenKho.Location = new System.Drawing.Point(316, 101);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(133, 21);
            this.txtTenKho.TabIndex = 86;
            this.txtTenKho.Click += new System.EventHandler(this.txtTenKho_Click);
            // 
            // txtTenHH
            // 
            this.txtTenHH.FormattingEnabled = true;
            this.txtTenHH.Location = new System.Drawing.Point(316, 136);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(133, 21);
            this.txtTenHH.TabIndex = 85;
            this.txtTenHH.Click += new System.EventHandler(this.txtTenHH_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.FormattingEnabled = true;
            this.txtTenNCC.Location = new System.Drawing.Point(316, 170);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(133, 21);
            this.txtTenNCC.TabIndex = 84;
            this.txtTenNCC.Click += new System.EventHandler(this.txtTenNCC_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 83;
            this.label10.Text = "Số lượng HH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tên NCC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tên hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Tên kho:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cmbKey);
            this.groupBox13.Controls.Add(this.button14);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.cboTimKiem);
            this.groupBox13.Location = new System.Drawing.Point(12, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(446, 55);
            this.groupBox13.TabIndex = 79;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = " ";
            // 
            // cmbKey
            // 
            this.cmbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(62, 23);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(197, 21);
            this.cmbKey.TabIndex = 12;
            this.cmbKey.Click += new System.EventHandler(this.cmbKey_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::GUI_Quanlydetai.Properties.Resources.search_1_;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(285, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 28);
            this.button14.TabIndex = 9;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 29);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "Từ khóa:";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã kho",
            "Tên kho",
            "Mã nhà cung cấp",
            "Tên nhà cung cấp",
            "Mã hàng hóa",
            "Tên hàng hóa"});
            this.cboTimKiem.Location = new System.Drawing.Point(326, 23);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(108, 21);
            this.cboTimKiem.TabIndex = 10;
            this.cboTimKiem.Text = "Nâng cao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = " Thêm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Xóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Sửa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = " ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::GUI_Quanlydetai.Properties.Resources.file_delete__1_;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(265, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 39);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::GUI_Quanlydetai.Properties.Resources.images;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(145, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(39, 39);
            this.btnThem.TabIndex = 73;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::GUI_Quanlydetai.Properties.Resources.boton_escribir_1_remix;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(206, 293);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(39, 39);
            this.btnSua.TabIndex = 72;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(316, 239);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(133, 20);
            this.txtNoiDung.TabIndex = 56;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(86, 167);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(126, 20);
            this.txtMaNCC.TabIndex = 55;
            this.txtMaNCC.Click += new System.EventHandler(this.txtMaNCC_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(252, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Nội dung:";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(86, 235);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(126, 20);
            this.txtNgayNhap.TabIndex = 43;
            // 
            // txtSoPN
            // 
            this.txtSoPN.Location = new System.Drawing.Point(86, 203);
            this.txtSoPN.Name = "txtSoPN";
            this.txtSoPN.Size = new System.Drawing.Size(126, 20);
            this.txtSoPN.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Ngày nhập:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Số PN :";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(86, 133);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(126, 20);
            this.txtMaHH.TabIndex = 33;
            this.txtMaHH.Click += new System.EventHandler(this.txtMaHH_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(86, 102);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.ReadOnly = true;
            this.txtMaKho.Size = new System.Drawing.Size(126, 20);
            this.txtMaKho.TabIndex = 32;
            this.txtMaKho.Click += new System.EventHandler(this.txtMaKho_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mã NCC :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mã hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mã kho:";
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 512);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapKho";
            this.Text = "NhapKho";
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grdGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtSoPN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPN;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDung;
        private System.Windows.Forms.TextBox txtSoLuongHH;
        private System.Windows.Forms.ComboBox txtTenKho;
        private System.Windows.Forms.ComboBox txtTenHH;
        private System.Windows.Forms.ComboBox txtTenNCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}