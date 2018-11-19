﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ECM_BUS;
using ECM_DTO;

namespace EnglishCenterManagement
{
    public partial class frmThemHocVien : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder

        private void frmThemHocVien_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmThemHocVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmThemHocVien_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
       
        #endregion

        List<HocVien_DTO> lsHocVien;
        List<Lop_DTO> lsLop;
        List<KhoaHoc_DTO> lsKhoaHoc;

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();
        
        public frmThemHocVien()
        {
            InitializeComponent();
        }
        private void frmThemHocVien_Load(object sender, EventArgs e)
        {
            string maTiepTheo = hvBUS.maHocVienTiepTheo();
            txt_mshv.Text = maTiepTheo;
            lke_lopHoc.Enabled = false;   
            LoadDSKhoaHoc();
        }
        private void LoadDSKhoaHoc()
        {
            lsKhoaHoc = new List<KhoaHoc_DTO>();
            lsKhoaHoc = khBUS.DanhSachKH();

            lke_khoaHoc.Properties.DataSource = lsKhoaHoc;
            lke_khoaHoc.Properties.DisplayMember = "MaKH";
            lke_khoaHoc.Properties.ValueMember = "MaKH";

            //lke_khoaHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKH", "Mã Khóa Học", 10));
            //lke_khoaHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKH", "Tên Khóa Học", 20));           
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ho.Text == "" || txt_ten.Text == "" || 
                cbo_gioiTinh.Text == "" || dt_ngaySinh.EditValue == null || 
                txt_sdt.Text == "" || txt_diaChi.Text == "" || 
                lke_khoaHoc.Text == "" || lke_lopHoc.Text == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (hvDTO != null)
                {
                    GetDetail();

                    int kq = hvBUS.AddHV(hvDTO);
                    if (kq == 1)
                    {                       
                        XtraMessageBox.Show(string.Format("Thêm học viên mã {0} thành công!", hvDTO.MSHV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        RefreshTextBox();
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }        
        }
        private void GetDetail()
        {
            if (hvDTO != null)
            {
                hvDTO = new HocVien_DTO();
            }
            hvDTO.MSHV = txt_mshv.Text;
            hvDTO.Ho = txt_ho.Text;
            hvDTO.Ten = txt_ten.Text;
            hvDTO.GioiTinh = cbo_gioiTinh.Text;
            hvDTO.NgaySinh = DateTime.Parse(dt_ngaySinh.EditValue.ToString());
            hvDTO.SDT = txt_sdt.Text;
            hvDTO.Email = txt_email.Text;
            hvDTO.DiaChi = txt_diaChi.Text;
            hvDTO.MaKH = lke_khoaHoc.Text;
            hvDTO.MaLop = lke_lopHoc.Text;
        }
        public void RefreshTextBox()
        {
            string maTiepTheo = hvBUS.maHocVienTiepTheo();
            txt_mshv.Text = maTiepTheo;
            txt_ho.Text = string.Empty;
            txt_ten.Text = string.Empty;
            cbo_gioiTinh.Text = string.Empty;
            dt_ngaySinh.EditValue = DateTime.Now;
            txt_sdt.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_diaChi.Text = string.Empty;
            lke_khoaHoc.EditValue = string.Empty;
            lke_lopHoc.EditValue = string.Empty;
        }
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
                //&& (e.KeyChar != '.' || (e.KeyChar == '.' &&
                //        (txt_sdt.Text.Length == 0 || txt_sdt.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
        }

        private void lke_khoaHoc_EditValueChanged(object sender, EventArgs e)
        {
            if(lke_khoaHoc.EditValue != null)
            {
                lke_lopHoc.Enabled = true;
                lsLop = lopBUS.DanhSachLop2(lke_khoaHoc.EditValue.ToString());
                lke_lopHoc.Properties.DataSource = lsLop;
                lke_lopHoc.Properties.DisplayMember = "MaLop";
                lke_lopHoc.Properties.ValueMember = "MaLop";             
            }
        }
    }
}