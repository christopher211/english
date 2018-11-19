namespace EnglishCenterManagement
{
    partial class ucQLHV_Diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLHV_Diem));
            this.dgcontrol_diemHocVien = new DevExpress.XtraGrid.GridControl();
            this.dgview_diemHocVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_mahv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_maKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_diem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_gioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbo_khoaHoc = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbo_maLop = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoiDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_capNhatDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaDiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themDiem = new DevExpress.XtraEditors.SimpleButton();
            this.cl_tenhv = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_diemHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_diemHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_khoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_maLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcontrol_diemHocVien
            // 
            this.dgcontrol_diemHocVien.Location = new System.Drawing.Point(3, 143);
            this.dgcontrol_diemHocVien.MainView = this.dgview_diemHocVien;
            this.dgcontrol_diemHocVien.Name = "dgcontrol_diemHocVien";
            this.dgcontrol_diemHocVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbo_gioiTinh,
            this.cbo_khoaHoc,
            this.cbo_maLop});
            this.dgcontrol_diemHocVien.Size = new System.Drawing.Size(989, 388);
            this.dgcontrol_diemHocVien.TabIndex = 11;
            this.dgcontrol_diemHocVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_diemHocVien});
            // 
            // dgview_diemHocVien
            // 
            this.dgview_diemHocVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_mahv,
            this.cl_tenhv,
            this.cl_maKhoaHoc,
            this.cl_diem});
            this.dgview_diemHocVien.GridControl = this.dgcontrol_diemHocVien;
            this.dgview_diemHocVien.Name = "dgview_diemHocVien";
            this.dgview_diemHocVien.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.dgview_diemHocVien.OptionsFind.FindFilterColumns = "*ID;MaHV;MaKhoaHoc;DiemHV;";
            // 
            // cl_mahv
            // 
            this.cl_mahv.Caption = "Mã học viên";
            this.cl_mahv.FieldName = "MaHV";
            this.cl_mahv.Name = "cl_mahv";
            this.cl_mahv.OptionsColumn.AllowEdit = false;
            this.cl_mahv.OptionsColumn.ReadOnly = true;
            this.cl_mahv.Visible = true;
            this.cl_mahv.VisibleIndex = 0;
            this.cl_mahv.Width = 126;
            // 
            // cl_maKhoaHoc
            // 
            this.cl_maKhoaHoc.Caption = "Mã Khóa Học";
            this.cl_maKhoaHoc.FieldName = "MaKhoaHoc";
            this.cl_maKhoaHoc.Name = "cl_maKhoaHoc";
            this.cl_maKhoaHoc.Visible = true;
            this.cl_maKhoaHoc.VisibleIndex = 2;
            this.cl_maKhoaHoc.Width = 217;
            // 
            // cl_diem
            // 
            this.cl_diem.Caption = "Điểm";
            this.cl_diem.FieldName = "DiemHV";
            this.cl_diem.Name = "cl_diem";
            this.cl_diem.Visible = true;
            this.cl_diem.VisibleIndex = 3;
            this.cl_diem.Width = 307;
            // 
            // cbo_gioiTinh
            // 
            this.cbo_gioiTinh.AutoHeight = false;
            this.cbo_gioiTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioiTinh.Name = "cbo_gioiTinh";
            // 
            // cbo_khoaHoc
            // 
            this.cbo_khoaHoc.AutoHeight = false;
            this.cbo_khoaHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_khoaHoc.Name = "cbo_khoaHoc";
            // 
            // cbo_maLop
            // 
            this.cbo_maLop.AutoHeight = false;
            this.cbo_maLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_maLop.Name = "cbo_maLop";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(363, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(249, 35);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "DANH SÁCH ĐIỂM";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_lamMoiDiem);
            this.groupControl1.Controls.Add(this.btn_capNhatDiem);
            this.groupControl1.Controls.Add(this.btn_xoaDiem);
            this.groupControl1.Controls.Add(this.btn_themDiem);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(282, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(397, 70);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_lamMoiDiem
            // 
            this.btn_lamMoiDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoiDiem.ImageOptions.Image")));
            this.btn_lamMoiDiem.Location = new System.Drawing.Point(302, 24);
            this.btn_lamMoiDiem.Name = "btn_lamMoiDiem";
            this.btn_lamMoiDiem.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoiDiem.TabIndex = 3;
            this.btn_lamMoiDiem.Text = "Làm mới";
            // 
            // btn_capNhatDiem
            // 
            this.btn_capNhatDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_capNhatDiem.ImageOptions.Image")));
            this.btn_capNhatDiem.Location = new System.Drawing.Point(203, 24);
            this.btn_capNhatDiem.Name = "btn_capNhatDiem";
            this.btn_capNhatDiem.Size = new System.Drawing.Size(93, 38);
            this.btn_capNhatDiem.TabIndex = 2;
            this.btn_capNhatDiem.Text = "Cập nhật";
            // 
            // btn_xoaDiem
            // 
            this.btn_xoaDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaDiem.ImageOptions.Image")));
            this.btn_xoaDiem.Location = new System.Drawing.Point(104, 24);
            this.btn_xoaDiem.Name = "btn_xoaDiem";
            this.btn_xoaDiem.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaDiem.TabIndex = 1;
            this.btn_xoaDiem.Text = "Xóa";
            // 
            // btn_themDiem
            // 
            this.btn_themDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themDiem.ImageOptions.Image")));
            this.btn_themDiem.Location = new System.Drawing.Point(5, 24);
            this.btn_themDiem.Name = "btn_themDiem";
            this.btn_themDiem.Size = new System.Drawing.Size(93, 38);
            this.btn_themDiem.TabIndex = 0;
            this.btn_themDiem.Text = "Thêm";
            // 
            // cl_tenhv
            // 
            this.cl_tenhv.Caption = "Tên học viên";
            this.cl_tenhv.FieldName = "TenHV";
            this.cl_tenhv.Name = "cl_tenhv";
            this.cl_tenhv.Visible = true;
            this.cl_tenhv.VisibleIndex = 1;
            this.cl_tenhv.Width = 281;
            // 
            // ucQLHV_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgcontrol_diemHocVien);
            this.Name = "ucQLHV_Diem";
            this.Size = new System.Drawing.Size(995, 534);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_diemHocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_diemHocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_khoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_maLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_diemHocVien;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_diemHocVien;
        private DevExpress.XtraGrid.Columns.GridColumn cl_mahv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_maKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn cl_diem;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_gioiTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_khoaHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_maLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoiDiem;
        private DevExpress.XtraEditors.SimpleButton btn_capNhatDiem;
        private DevExpress.XtraEditors.SimpleButton btn_xoaDiem;
        private DevExpress.XtraEditors.SimpleButton btn_themDiem;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tenhv;
    }
}
