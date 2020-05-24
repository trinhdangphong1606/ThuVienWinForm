﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DAL.DAO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHienThiSach_Click(object sender, EventArgs e)
        {
            SachBLL sacbll = new SachBLL();
            List<Sach> dssach = sacbll.LayAllToanBoSach();
            lvSach.Items.Clear();
            foreach(Sach sac in dssach)
            {
                ListViewItem lvi = new ListViewItem(sac.ID + "");
                lvi.SubItems.Add(sac.TenSach);
                lvi.SubItems.Add(sac.NamXuatBan+"");
                lvi.SubItems.Add(sac.DanhMucID+"");
                lvi.SubItems.Add(sac.TacGia);
                lvi.SubItems.Add(sac.NgonNgu);
                lvi.SubItems.Add(sac.NoiDungSach);
                lvi.SubItems.Add(sac.SoLuong+"");
                lvi.SubItems.Add(sac.TrangThai + "");

                lvSach.Items.Add(lvi);
            }
           
        }
    }
}
