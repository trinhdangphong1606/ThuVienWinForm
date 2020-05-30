﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using BLL;
using DTO;


namespace GUI
{
    public partial class FrmPhieuMuonSachMo : Form //FrmSachQL
    {
        public FrmPhieuMuonSachMo()
        {
            InitializeComponent();
        }

        private void FrmPhieuMuonSachMo_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSach();
            HienThiNguoiMuonSachDS();
        }
        public void HienThiDanhSachSach()
        {
            SachBLL sacBLL = new SachBLL();
            List<Sach> dsdsach = sacBLL.LayAllToanBoSach();
            lvPMSTSach.Items.Clear();
            foreach (Sach scBLL in dsdsach)
            {
                ListViewItem lvi = new ListViewItem(scBLL.ID + "");
                lvi.SubItems.Add(scBLL.TenSach);
                lvPMSTSach.Items.Add(lvi);
            }
        }
        private void HienThiNguoiMuonSachDS()
        {
            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.LayToanBoNguoiMuonSach();
            lvPMSTDocGia.Items.Clear();
            foreach (NguoiMuonSach nms in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nms.Id+"");
                lvi.SubItems.Add(nms.HoTen);
                lvPMSTDocGia.Items.Add(lvi);
            }
        }

        private void lvPMSTDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPMSTDocGia.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvPMSTDocGia.SelectedItems[0];
                string id = lvi.SubItems[0].Text;
                string hoten = lvi.SubItems[1].Text;
                txtReadyMaDocGia.Text = id;
                txtReadyTenDocGia.Text = hoten;
            }
        }

        private void lvPMSTSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPMSTSach.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvPMSTSach.SelectedItems[0];
                string id = lvi.SubItems[0].Text;
                string tensach = lvi.SubItems[1].Text;
                txtReadyMaSach.Text = id;
                txtReadyTenSach.Text = tensach;
            }
        }

        private void btnHuyTao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanThongTin_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtReadyMaDocGia, "");
            errorProvider2.SetError(txtReadyMaSach, "");
            errorProvider3.SetError(datetimeReadyNgayDuKienTra, "");
            if (txtReadyMaDocGia.Text == "")
            {
                errorProvider1.SetError(txtReadyMaDocGia, "Xin chọn đọc giả ...");
                return;
            }
            if (txtReadyMaSach.Text == "")
            {
                errorProvider2.SetError(txtReadyMaSach, "Xin chọn sách mượn ...");
                return;
            }
            if(datetimeReadyNgayDuKienTra.Value<=datetimeReadyNgayMuon.Value)
            {
                errorProvider3.SetError(datetimeReadyNgayDuKienTra, "Ngày dự kiến trả sau ngày bắt đầu mượn ...");
                return;
            }    
            XacNhanThongTin();
               
            
            
        }
        private void XacNhanThongTin()
        {
            txtConfirmMaDocGia.Text = txtReadyMaDocGia.Text;
            txtConfirmTenDocGia.Text = txtReadyTenDocGia.Text;
            txtConfirmMaSach.Text = txtReadyMaSach.Text;
            txtConfirmTenSach.Text = txtReadyTenSach.Text;
            datetimeConfirmNgayDuKienTra.Value = datetimeReadyNgayDuKienTra.Value;
            datetimeConfirmNgayMuon.Value = datetimeReadyNgayMuon.Value;
            //txtConfirmNgayMuon.Text = 
        }
    }
}
