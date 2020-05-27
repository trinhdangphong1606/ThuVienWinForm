using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FrmDanhMucQL : Form
    {
        public FrmDanhMucQL()
        {
            InitializeComponent();
        }
        private void FrmDanhMucQL_Load(object sender, EventArgs e)
        {
            HienThiDSDanhMuc();
        }

        private void BtnCapNhatDanhMuc_Click(object sender, EventArgs e)
        {
            HienThiDSDanhMuc();

        }
        private void HienThiDSDanhMuc()
        {
            DanhMucBLL damuBLL = new DanhMucBLL();
            List<DanhMuc> dsdanhmuc = damuBLL.LayToanBoDanhMuc();
            LvDanhMucDS.Items.Clear();
            foreach (DanhMuc damuc in dsdanhmuc)
            {
                ListViewItem lvi = new ListViewItem(damuc.TenDanhMuc+"");
                lvi.SubItems.Add(damuc.NoiDungDanhMuc);
                LvDanhMucDS.Items.Add(lvi);
            }
        }

        private void LvDanhMucDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LvDanhMucDS.SelectedItems.Count>0)
            {
                ListViewItem lvi = LvDanhMucDS.SelectedItems[0];
                string tendanhmuccc = lvi.SubItems[0].Text;
                string noidungdanhmuccc = lvi.SubItems[1].Text;
                txtTenDanhMuc.Text = tendanhmuccc;
                richNoiDungDanhMuc.Text = noidungdanhmuccc;
            }    
        }
    }
}

