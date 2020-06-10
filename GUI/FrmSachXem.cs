﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DAO;
using BLL;

namespace GUI
{
    public partial class FrmSachXem : Form
    {
        public FrmSachXem()
        {
            InitializeComponent();
        }
        private void FrmSachXem_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSach();
        }
        public void HienThiDanhSachSach()
        {
            SachBLL sacBLL = new SachBLL();
            List<SachDAO> dssach = sacBLL.LayToanBoSach(); //call sachbll để trả về dssach
            LvSachQL.Items.Clear();
            foreach (SachDAO scBLL in dssach)
            //duyệt tuần tự các phần tử trong mảng dssach
            {
                ListViewItem lvi = new ListViewItem(scBLL.TenSach + "");
                lvi.SubItems.Add(scBLL.TacGia);
                lvi.SubItems.Add(scBLL.TheLoai);
                lvi.SubItems.Add(scBLL.NgonNgu);
                lvi.SubItems.Add(scBLL.NamXuatBan + "");
                //lvi.SubItems.Add(scBLL.TrangThai + "");
                lvi.SubItems.Add(scBLL.NoiDungSach + "");

                LvSachQL.Items.Add(lvi);
            }
        }
        private void LvSachQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvSachQL.SelectedItems.Count > 0)
            {
                ListViewItem lvi = LvSachQL.SelectedItems[0];
                string tensach = lvi.SubItems[0].Text;
                string tacgia = lvi.SubItems[1].Text;
                string danhmuc = lvi.SubItems[2].Text;
                string ngonngu = lvi.SubItems[3].Text;
                string namxuatban = lvi.SubItems[4].Text;
                string noidung = lvi.SubItems[5].Text;
                TxtTenSach.Text = tensach;
                TxtTenTacGia.Text = tacgia;
                TxtTenDanhMuc.Text = danhmuc;
                TxtNgonNgu.Text = ngonngu;
                TxtNamXuatBan.Text = namxuatban;
                richNoiDungSach.Text = noidung;
            }
        }

        
    }
}