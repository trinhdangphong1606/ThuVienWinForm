using System;
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
            SachBLL2 sacbll = new SachBLL2();
            List<SachDAO> dssach = sacbll.LayToanBoSach();
            lvSach.Items.Clear();
            foreach(SachDAO sac in dssach)
            {
                ListViewItem lvi = new ListViewItem(sac.ID + "");
                lvi.SubItems.Add(sac.TenSach);
                lvi.SubItems.Add(sac.NamXuatBan+"");
                lvi.SubItems.Add(sac.TheLoai + "");
                lvi.SubItems.Add(sac.TacGia);
                lvi.SubItems.Add(sac.NgonNgu);
                lvi.SubItems.Add(sac.NoiDungSach);
                lvi.SubItems.Add(sac.SoLuong+"");
                //lvi.SubItems.Add(sac.TrangThai + "");

                lvSach.Items.Add(lvi);
            }
           
        }

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
