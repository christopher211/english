﻿namespace EnglishCenterManagement
{
    partial class ucQLNV_GiaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLNV_GiaoVien));
            this.dgcontrol_giaoVien = new DevExpress.XtraGrid.GridControl();
            this.dgview_giaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngayLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_chucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaGiaoVien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themGiaoVien = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_timGVSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_timGVSDT = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timGVHoTen = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timGVHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timGVMaGV = new DevExpress.XtraEditors.TextEdit();
            this.btn_timGVMaGV = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_giaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_giaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timGVSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timGVHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timGVMaGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcontrol_giaoVien
            // 
            this.dgcontrol_giaoVien.Location = new System.Drawing.Point(3, 230);
            this.dgcontrol_giaoVien.MainView = this.dgview_giaoVien;
            this.dgcontrol_giaoVien.Name = "dgcontrol_giaoVien";
            this.dgcontrol_giaoVien.Size = new System.Drawing.Size(989, 301);
            this.dgcontrol_giaoVien.TabIndex = 4;
            this.dgcontrol_giaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_giaoVien});
            // 
            // dgview_giaoVien
            // 
            this.dgview_giaoVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_manv,
            this.cl_ho,
            this.cl_ten,
            this.cl_gioiTinh,
            this.cl_ngaySinh,
            this.cl_ngayLamViec,
            this.cl_sdt,
            this.cl_email,
            this.cl_diaChi,
            this.cl_chucVu});
            this.dgview_giaoVien.GridControl = this.dgcontrol_giaoVien;
            this.dgview_giaoVien.Name = "dgview_giaoVien";
            this.dgview_giaoVien.OptionsFind.FindFilterColumns = "*ID;MaNV;HoNV;TenNV;GioiTinh;NgaySinh;NgayLamViec;SDT;Email;DiaChi;ChucVu;";
            this.dgview_giaoVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // cl_manv
            // 
            this.cl_manv.Caption = "Mã nhân viên";
            this.cl_manv.FieldName = "MaNV";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.OptionsColumn.AllowEdit = false;
            this.cl_manv.Visible = true;
            this.cl_manv.VisibleIndex = 0;
            this.cl_manv.Width = 94;
            // 
            // cl_ho
            // 
            this.cl_ho.Caption = "Họ";
            this.cl_ho.FieldName = "HoNV";
            this.cl_ho.Name = "cl_ho";
            this.cl_ho.OptionsColumn.AllowEdit = false;
            this.cl_ho.Visible = true;
            this.cl_ho.VisibleIndex = 1;
            this.cl_ho.Width = 90;
            // 
            // cl_ten
            // 
            this.cl_ten.Caption = "Tên";
            this.cl_ten.FieldName = "TenNV";
            this.cl_ten.Name = "cl_ten";
            this.cl_ten.OptionsColumn.AllowEdit = false;
            this.cl_ten.Visible = true;
            this.cl_ten.VisibleIndex = 2;
            this.cl_ten.Width = 93;
            // 
            // cl_gioiTinh
            // 
            this.cl_gioiTinh.Caption = "Giới tính";
            this.cl_gioiTinh.FieldName = "GioiTinh";
            this.cl_gioiTinh.Name = "cl_gioiTinh";
            this.cl_gioiTinh.OptionsColumn.AllowEdit = false;
            this.cl_gioiTinh.Visible = true;
            this.cl_gioiTinh.VisibleIndex = 3;
            this.cl_gioiTinh.Width = 93;
            // 
            // cl_ngaySinh
            // 
            this.cl_ngaySinh.Caption = "Ngày sinh";
            this.cl_ngaySinh.FieldName = "NgaySinh";
            this.cl_ngaySinh.Name = "cl_ngaySinh";
            this.cl_ngaySinh.OptionsColumn.AllowEdit = false;
            this.cl_ngaySinh.Visible = true;
            this.cl_ngaySinh.VisibleIndex = 4;
            this.cl_ngaySinh.Width = 93;
            // 
            // cl_ngayLamViec
            // 
            this.cl_ngayLamViec.Caption = "Ngảy làm việc";
            this.cl_ngayLamViec.FieldName = "NgayLamViec";
            this.cl_ngayLamViec.Name = "cl_ngayLamViec";
            this.cl_ngayLamViec.OptionsColumn.AllowEdit = false;
            this.cl_ngayLamViec.Visible = true;
            this.cl_ngayLamViec.VisibleIndex = 5;
            this.cl_ngayLamViec.Width = 93;
            // 
            // cl_sdt
            // 
            this.cl_sdt.Caption = "SĐT";
            this.cl_sdt.FieldName = "SDT";
            this.cl_sdt.Name = "cl_sdt";
            this.cl_sdt.OptionsColumn.AllowEdit = false;
            this.cl_sdt.Visible = true;
            this.cl_sdt.VisibleIndex = 6;
            this.cl_sdt.Width = 93;
            // 
            // cl_email
            // 
            this.cl_email.Caption = "Email";
            this.cl_email.FieldName = "Email";
            this.cl_email.Name = "cl_email";
            this.cl_email.OptionsColumn.AllowEdit = false;
            this.cl_email.Visible = true;
            this.cl_email.VisibleIndex = 7;
            this.cl_email.Width = 93;
            // 
            // cl_diaChi
            // 
            this.cl_diaChi.Caption = "Địa chỉ";
            this.cl_diaChi.FieldName = "DiaChi";
            this.cl_diaChi.Name = "cl_diaChi";
            this.cl_diaChi.OptionsColumn.AllowEdit = false;
            this.cl_diaChi.Visible = true;
            this.cl_diaChi.VisibleIndex = 8;
            this.cl_diaChi.Width = 93;
            // 
            // cl_chucVu
            // 
            this.cl_chucVu.Caption = "Chức vụ";
            this.cl_chucVu.FieldName = "ChucVu";
            this.cl_chucVu.Name = "cl_chucVu";
            this.cl_chucVu.OptionsColumn.AllowEdit = false;
            this.cl_chucVu.Width = 129;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_lamMoi);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_xoaGiaoVien);
            this.groupControl1.Controls.Add(this.btn_themGiaoVien);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(162, 90);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(203, 118);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.ImageOptions.Image")));
            this.btn_lamMoi.Location = new System.Drawing.Point(104, 73);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(5, 73);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 38);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoaGiaoVien
            // 
            this.btn_xoaGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaGiaoVien.ImageOptions.Image")));
            this.btn_xoaGiaoVien.Location = new System.Drawing.Point(104, 26);
            this.btn_xoaGiaoVien.Name = "btn_xoaGiaoVien";
            this.btn_xoaGiaoVien.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaGiaoVien.TabIndex = 1;
            this.btn_xoaGiaoVien.Text = "Xóa";
            this.btn_xoaGiaoVien.Click += new System.EventHandler(this.btn_xoaGiaoVien_Click);
            // 
            // btn_themGiaoVien
            // 
            this.btn_themGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themGiaoVien.ImageOptions.Image")));
            this.btn_themGiaoVien.Location = new System.Drawing.Point(5, 26);
            this.btn_themGiaoVien.Name = "btn_themGiaoVien";
            this.btn_themGiaoVien.Size = new System.Drawing.Size(93, 38);
            this.btn_themGiaoVien.TabIndex = 0;
            this.btn_themGiaoVien.Text = "Thêm";
            this.btn_themGiaoVien.Click += new System.EventHandler(this.btn_themGiaoVien_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_timGVSDT);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.btn_timGVSDT);
            this.groupControl2.Controls.Add(this.btn_timGVHoTen);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txt_timGVHoTen);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txt_timGVMaGV);
            this.groupControl2.Controls.Add(this.btn_timGVMaGV);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(463, 76);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(356, 148);
            this.groupControl2.TabIndex = 35;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // txt_timGVSDT
            // 
            this.txt_timGVSDT.Location = new System.Drawing.Point(85, 112);
            this.txt_timGVSDT.Name = "txt_timGVSDT";
            this.txt_timGVSDT.Properties.MaxLength = 10;
            this.txt_timGVSDT.Size = new System.Drawing.Size(167, 20);
            this.txt_timGVSDT.TabIndex = 2;
            this.txt_timGVSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timGVSDT_KeyDown);
            this.txt_timGVSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_timGVSDT_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(47, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 16);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "SĐT";
            // 
            // btn_timGVSDT
            // 
            this.btn_timGVSDT.Location = new System.Drawing.Point(258, 112);
            this.btn_timGVSDT.Name = "btn_timGVSDT";
            this.btn_timGVSDT.Size = new System.Drawing.Size(75, 20);
            this.btn_timGVSDT.TabIndex = 40;
            this.btn_timGVSDT.Text = "Tìm";
            this.btn_timGVSDT.Click += new System.EventHandler(this.btn_timGVSDT_Click);
            // 
            // btn_timGVHoTen
            // 
            this.btn_timGVHoTen.Location = new System.Drawing.Point(258, 74);
            this.btn_timGVHoTen.Name = "btn_timGVHoTen";
            this.btn_timGVHoTen.Size = new System.Drawing.Size(75, 20);
            this.btn_timGVHoTen.TabIndex = 37;
            this.btn_timGVHoTen.Text = "Tìm";
            this.btn_timGVHoTen.Click += new System.EventHandler(this.btn_timGVHoTen_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 17);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Họ tên";
            // 
            // txt_timGVHoTen
            // 
            this.txt_timGVHoTen.Location = new System.Drawing.Point(85, 74);
            this.txt_timGVHoTen.Name = "txt_timGVHoTen";
            this.txt_timGVHoTen.Size = new System.Drawing.Size(167, 20);
            this.txt_timGVHoTen.TabIndex = 1;
            this.txt_timGVHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timGVHoTen_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Mã NV";
            // 
            // txt_timGVMaGV
            // 
            this.txt_timGVMaGV.EditValue = "NV";
            this.txt_timGVMaGV.Location = new System.Drawing.Point(85, 36);
            this.txt_timGVMaGV.Name = "txt_timGVMaGV";
            this.txt_timGVMaGV.Properties.MaxLength = 4;
            this.txt_timGVMaGV.Size = new System.Drawing.Size(167, 20);
            this.txt_timGVMaGV.TabIndex = 0;
            this.txt_timGVMaGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timGVMaGV_KeyDown);
            // 
            // btn_timGVMaGV
            // 
            this.btn_timGVMaGV.Location = new System.Drawing.Point(258, 36);
            this.btn_timGVMaGV.Name = "btn_timGVMaGV";
            this.btn_timGVMaGV.Size = new System.Drawing.Size(75, 20);
            this.btn_timGVMaGV.TabIndex = 33;
            this.btn_timGVMaGV.Text = "Tìm";
            this.btn_timGVMaGV.Click += new System.EventHandler(this.btn_timGVMaGV_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(332, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(344, 41);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // ucQLNV_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgcontrol_giaoVien);
            this.Name = "ucQLNV_GiaoVien";
            this.Size = new System.Drawing.Size(995, 534);
            this.Load += new System.EventHandler(this.ucQLNV_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_giaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_giaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timGVSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timGVHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timGVMaGV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgcontrol_giaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_giaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ho;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ten;
        private DevExpress.XtraGrid.Columns.GridColumn cl_gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngayLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn cl_sdt;
        private DevExpress.XtraGrid.Columns.GridColumn cl_email;
        private DevExpress.XtraGrid.Columns.GridColumn cl_diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn cl_chucVu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoi;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoaGiaoVien;
        private DevExpress.XtraEditors.SimpleButton btn_themGiaoVien;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_timGVSDT;
        private DevExpress.XtraEditors.SimpleButton btn_timGVHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_timGVHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_timGVMaGV;
        private DevExpress.XtraEditors.SimpleButton btn_timGVMaGV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_timGVSDT;
    }
}
