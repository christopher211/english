﻿namespace EnglishCenterManagement
{
    partial class frmQuanLyLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLopHoc));
            this.dgcontrol_lopHoc = new DevExpress.XtraGrid.GridControl();
            this.dgview_lopHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_malop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tenlop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_maphg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_makhoahoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_lichhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_giobatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_gioketthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoiLopHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suaLopHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaLopHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themLopHoc = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_gioKetThuc = new DevExpress.XtraEditors.TextEdit();
            this.txt_gioBatDau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_maPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lke_makh = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maLop = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenLop = new DevExpress.XtraEditors.TextEdit();
            this.cbo_lichHoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lke_maNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_lopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_lopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gioKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gioBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_maPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_makh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_lichHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_maNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcontrol_lopHoc
            // 
            this.dgcontrol_lopHoc.Location = new System.Drawing.Point(12, 247);
            this.dgcontrol_lopHoc.MainView = this.dgview_lopHoc;
            this.dgcontrol_lopHoc.Name = "dgcontrol_lopHoc";
            this.dgcontrol_lopHoc.Size = new System.Drawing.Size(1135, 293);
            this.dgcontrol_lopHoc.TabIndex = 0;
            this.dgcontrol_lopHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_lopHoc});
            this.dgcontrol_lopHoc.Click += new System.EventHandler(this.dgcontrol_lopHoc_Click);
            // 
            // dgview_lopHoc
            // 
            this.dgview_lopHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_malop,
            this.cl_tenlop,
            this.cl_manv,
            this.cl_maphg,
            this.cl_makhoahoc,
            this.cl_lichhoc,
            this.cl_giobatdau,
            this.cl_gioketthuc});
            this.dgview_lopHoc.GridControl = this.dgcontrol_lopHoc;
            this.dgview_lopHoc.Name = "dgview_lopHoc";
            this.dgview_lopHoc.OptionsBehavior.ReadOnly = true;
            this.dgview_lopHoc.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // cl_malop
            // 
            this.cl_malop.Caption = "Mã lớp";
            this.cl_malop.FieldName = "MaLop";
            this.cl_malop.Name = "cl_malop";
            this.cl_malop.OptionsColumn.AllowEdit = false;
            this.cl_malop.Visible = true;
            this.cl_malop.VisibleIndex = 0;
            this.cl_malop.Width = 100;
            // 
            // cl_tenlop
            // 
            this.cl_tenlop.Caption = "Tên lớp";
            this.cl_tenlop.FieldName = "TenLop";
            this.cl_tenlop.Name = "cl_tenlop";
            this.cl_tenlop.OptionsColumn.AllowEdit = false;
            this.cl_tenlop.Visible = true;
            this.cl_tenlop.VisibleIndex = 1;
            this.cl_tenlop.Width = 154;
            // 
            // cl_manv
            // 
            this.cl_manv.Caption = "Mã nhân viên";
            this.cl_manv.FieldName = "MaNV";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.OptionsColumn.AllowEdit = false;
            this.cl_manv.Visible = true;
            this.cl_manv.VisibleIndex = 3;
            this.cl_manv.Width = 140;
            // 
            // cl_maphg
            // 
            this.cl_maphg.Caption = "Mã phòng";
            this.cl_maphg.FieldName = "MaPhg";
            this.cl_maphg.Name = "cl_maphg";
            this.cl_maphg.OptionsColumn.AllowEdit = false;
            this.cl_maphg.Visible = true;
            this.cl_maphg.VisibleIndex = 4;
            this.cl_maphg.Width = 140;
            // 
            // cl_makhoahoc
            // 
            this.cl_makhoahoc.Caption = "Mã khóa học";
            this.cl_makhoahoc.FieldName = "MaKhoaHoc";
            this.cl_makhoahoc.Name = "cl_makhoahoc";
            this.cl_makhoahoc.OptionsColumn.AllowEdit = false;
            this.cl_makhoahoc.Visible = true;
            this.cl_makhoahoc.VisibleIndex = 2;
            this.cl_makhoahoc.Width = 151;
            // 
            // cl_lichhoc
            // 
            this.cl_lichhoc.Caption = "Lịch học";
            this.cl_lichhoc.FieldName = "LichHoc";
            this.cl_lichhoc.Name = "cl_lichhoc";
            this.cl_lichhoc.OptionsColumn.AllowEdit = false;
            this.cl_lichhoc.Visible = true;
            this.cl_lichhoc.VisibleIndex = 5;
            this.cl_lichhoc.Width = 140;
            // 
            // cl_giobatdau
            // 
            this.cl_giobatdau.Caption = "Giờ bắt đầu";
            this.cl_giobatdau.FieldName = "GioBatDau";
            this.cl_giobatdau.Name = "cl_giobatdau";
            this.cl_giobatdau.OptionsColumn.AllowEdit = false;
            this.cl_giobatdau.Visible = true;
            this.cl_giobatdau.VisibleIndex = 6;
            this.cl_giobatdau.Width = 140;
            // 
            // cl_gioketthuc
            // 
            this.cl_gioketthuc.Caption = "Giờ kết thúc";
            this.cl_gioketthuc.FieldName = "GioKetThuc";
            this.cl_gioketthuc.Name = "cl_gioketthuc";
            this.cl_gioketthuc.OptionsColumn.AllowEdit = false;
            this.cl_gioketthuc.Visible = true;
            this.cl_gioketthuc.VisibleIndex = 7;
            this.cl_gioketthuc.Width = 149;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_lamMoiLopHoc);
            this.groupControl1.Controls.Add(this.btn_suaLopHoc);
            this.groupControl1.Controls.Add(this.btn_xoaLopHoc);
            this.groupControl1.Controls.Add(this.btn_themLopHoc);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(413, 170);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(734, 71);
            this.groupControl1.TabIndex = 27;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_lamMoiLopHoc
            // 
            this.btn_lamMoiLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoiLopHoc.ImageOptions.Image")));
            this.btn_lamMoiLopHoc.Location = new System.Drawing.Point(533, 26);
            this.btn_lamMoiLopHoc.Name = "btn_lamMoiLopHoc";
            this.btn_lamMoiLopHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoiLopHoc.TabIndex = 3;
            this.btn_lamMoiLopHoc.Text = "Làm mới";
            this.btn_lamMoiLopHoc.Click += new System.EventHandler(this.btn_lamMoiLopHoc_Click);
            // 
            // btn_suaLopHoc
            // 
            this.btn_suaLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaLopHoc.ImageOptions.Image")));
            this.btn_suaLopHoc.Location = new System.Drawing.Point(267, 26);
            this.btn_suaLopHoc.Name = "btn_suaLopHoc";
            this.btn_suaLopHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_suaLopHoc.TabIndex = 2;
            this.btn_suaLopHoc.Text = "Sửa";
            this.btn_suaLopHoc.Click += new System.EventHandler(this.btn_suaLopHoc_Click);
            // 
            // btn_xoaLopHoc
            // 
            this.btn_xoaLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaLopHoc.ImageOptions.Image")));
            this.btn_xoaLopHoc.Location = new System.Drawing.Point(401, 26);
            this.btn_xoaLopHoc.Name = "btn_xoaLopHoc";
            this.btn_xoaLopHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaLopHoc.TabIndex = 1;
            this.btn_xoaLopHoc.Text = "Xóa";
            this.btn_xoaLopHoc.Click += new System.EventHandler(this.btn_xoaLopHoc_Click);
            // 
            // btn_themLopHoc
            // 
            this.btn_themLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themLopHoc.ImageOptions.Image")));
            this.btn_themLopHoc.Location = new System.Drawing.Point(130, 26);
            this.btn_themLopHoc.Name = "btn_themLopHoc";
            this.btn_themLopHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_themLopHoc.TabIndex = 0;
            this.btn_themLopHoc.Text = "Thêm";
            this.btn_themLopHoc.Click += new System.EventHandler(this.btn_themLopHoc_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lke_maNhanVien);
            this.groupControl2.Controls.Add(this.txt_gioKetThuc);
            this.groupControl2.Controls.Add(this.txt_gioBatDau);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.cbo_maPhong);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.lke_makh);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txt_maLop);
            this.groupControl2.Controls.Add(this.txt_tenLop);
            this.groupControl2.Controls.Add(this.cbo_lichHoc);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(413, 17);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(734, 147);
            this.groupControl2.TabIndex = 28;
            this.groupControl2.Text = "Chi tiết lớp học";
            // 
            // txt_gioKetThuc
            // 
            this.txt_gioKetThuc.Location = new System.Drawing.Point(475, 112);
            this.txt_gioKetThuc.Name = "txt_gioKetThuc";
            this.txt_gioKetThuc.Size = new System.Drawing.Size(199, 20);
            this.txt_gioKetThuc.TabIndex = 34;
            // 
            // txt_gioBatDau
            // 
            this.txt_gioBatDau.Location = new System.Drawing.Point(475, 86);
            this.txt_gioBatDau.Name = "txt_gioBatDau";
            this.txt_gioBatDau.Size = new System.Drawing.Size(199, 20);
            this.txt_gioBatDau.TabIndex = 33;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(384, 37);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 13);
            this.labelControl10.TabIndex = 32;
            this.labelControl10.Text = "Mã phòng";
            // 
            // cbo_maPhong
            // 
            this.cbo_maPhong.Location = new System.Drawing.Point(475, 34);
            this.cbo_maPhong.Name = "cbo_maPhong";
            this.cbo_maPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_maPhong.Properties.MaxLength = 8;
            this.cbo_maPhong.Size = new System.Drawing.Size(199, 20);
            this.cbo_maPhong.TabIndex = 31;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(384, 63);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 13);
            this.labelControl9.TabIndex = 30;
            this.labelControl9.Text = "Lịch học";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(44, 63);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Mã khóa học";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 115);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 13);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "Mã nhân viên";
            // 
            // lke_makh
            // 
            this.lke_makh.Location = new System.Drawing.Point(135, 60);
            this.lke_makh.Name = "lke_makh";
            this.lke_makh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_makh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKH", "Mã khóa học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKH", "Tên khóa học")});
            this.lke_makh.Properties.NullText = "";
            this.lke_makh.Size = new System.Drawing.Size(199, 20);
            this.lke_makh.TabIndex = 27;
            this.lke_makh.EditValueChanged += new System.EventHandler(this.lke_makh_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(384, 63);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 13);
            this.labelControl5.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(44, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Mã lớp học";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(384, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Giờ kết thúc";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(384, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Giờ bắt đầu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Tên lớp học";
            // 
            // txt_maLop
            // 
            this.txt_maLop.Location = new System.Drawing.Point(135, 34);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Properties.ReadOnly = true;
            this.txt_maLop.Size = new System.Drawing.Size(199, 20);
            this.txt_maLop.TabIndex = 16;
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(135, 86);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Properties.ReadOnly = true;
            this.txt_tenLop.Size = new System.Drawing.Size(199, 20);
            this.txt_tenLop.TabIndex = 17;
            // 
            // cbo_lichHoc
            // 
            this.cbo_lichHoc.Location = new System.Drawing.Point(475, 60);
            this.cbo_lichHoc.Name = "cbo_lichHoc";
            this.cbo_lichHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_lichHoc.Properties.Items.AddRange(new object[] {
            "T2-T4-T6",
            "T3-T5-T7",
            "T7-CN"});
            this.cbo_lichHoc.Properties.MaxLength = 8;
            this.cbo_lichHoc.Size = new System.Drawing.Size(199, 20);
            this.cbo_lichHoc.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(321, 42);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "DANH SÁCH LỚP HỌC";
            // 
            // lke_maNhanVien
            // 
            this.lke_maNhanVien.Location = new System.Drawing.Point(135, 112);
            this.lke_maNhanVien.Name = "lke_maNhanVien";
            this.lke_maNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_maNhanVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNV", "Mã giáo viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoNV", "Họ giáo viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNV", "Tên giáo viên")});
            this.lke_maNhanVien.Properties.NullText = "";
            this.lke_maNhanVien.Size = new System.Drawing.Size(199, 20);
            this.lke_maNhanVien.TabIndex = 30;
            // 
            // frmQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 552);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dgcontrol_lopHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyLopHoc";
            this.Text = "frmQuanLyLopHoc";
            this.Load += new System.EventHandler(this.frmQuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_lopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_lopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gioKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gioBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_maPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_makh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_lichHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_maNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_lopHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_lopHoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoiLopHoc;
        private DevExpress.XtraEditors.SimpleButton btn_suaLopHoc;
        private DevExpress.XtraEditors.SimpleButton btn_xoaLopHoc;
        private DevExpress.XtraEditors.SimpleButton btn_themLopHoc;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_maLop;
        private DevExpress.XtraEditors.TextEdit txt_tenLop;
        private DevExpress.XtraGrid.Columns.GridColumn cl_malop;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tenlop;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_maphg;
        private DevExpress.XtraGrid.Columns.GridColumn cl_makhoahoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_lichhoc;
        private DevExpress.XtraGrid.Columns.GridColumn cl_giobatdau;
        private DevExpress.XtraGrid.Columns.GridColumn cl_gioketthuc;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_maPhong;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lke_makh;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_lichHoc;
        private DevExpress.XtraEditors.TextEdit txt_gioKetThuc;
        private DevExpress.XtraEditors.TextEdit txt_gioBatDau;
        private DevExpress.XtraEditors.LookUpEdit lke_maNhanVien;
    }
}