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
        public static int PassMa;
        public static string PassTenDanhMuc = "";
        public static string PassNoiDungDM = "";
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
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn Danh Mục Cần Thay Đổi Thông Tin", "Thông Báo");
            }
            else
            {
                PassMa = int.Parse(txtMa.Text);
                PassTenDanhMuc = txtTenDanhMuc.Text;
                PassNoiDungDM = richNoiDungDanhMuc.Text;
                FrmDanhMucUpdate frm1 = new FrmDanhMucUpdate();
                frm1.Show();
            }
            HienThiDSDanhMuc();
        }
        private void HienThiDSDanhMuc()
        {
            DanhMucBLL damuBLL = new DanhMucBLL();
            List<DanhMuc> dsdanhmuc = damuBLL.LayToanBoDanhMuc();
            LvDanhMucDS.Items.Clear();
            foreach (DanhMuc damuc in dsdanhmuc)
            {
                ListViewItem lvi = new ListViewItem(damuc.IdDanhMuc + "");
                lvi.SubItems.Add(damuc.TenDanhMuc);
                lvi.SubItems.Add(damuc.NoiDungDanhMuc);
                LvDanhMucDS.Items.Add(lvi);
            }
        }

        private void LvDanhMucDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvDanhMucDS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = LvDanhMucDS.SelectedItems[0];
                string iddanhmuccc = lvi.SubItems[0].Text;
                string tendanhmuccc = lvi.SubItems[1].Text;
                string noidungdanhmuccc = lvi.SubItems[2].Text;
                txtMa.Text = iddanhmuccc;
                txtTenDanhMuc.Text = tendanhmuccc;
                richNoiDungDanhMuc.Text = noidungdanhmuccc;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDanhMucThem frm1 = new FrmDanhMucThem();
            //frm1.MdiParent = this;
            frm1.Show();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            HienThiDSDanhMuc();
            MessageBox.Show("Dữ Liệu Đã Được Cập Nhật ");
        }
    }
}

