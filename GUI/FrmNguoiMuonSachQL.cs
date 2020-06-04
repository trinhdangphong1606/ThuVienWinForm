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

namespace GUI
{
    public partial class FrmNguoiMuonSachQL : Form
    {
        public FrmNguoiMuonSachQL()
        {
            InitializeComponent();
        }
        private void FrmNguoiMuonSachQL_Load(object sender, EventArgs e)
        {
            HienThiNguoiMuonSachDS();
        }
        private void BtnNguoiMuonCapNhat_Click(object sender, EventArgs e)
        {
            FrmNguoiMuonSachCapNhat Frm1 = new FrmNguoiMuonSachCapNhat();
            Frm1.Show();
        }
        private void BtnNguoiMuonThem_Click(object sender, EventArgs e)
        {
            FrmNguoiMuonSachThemMoi Frm1 = new FrmNguoiMuonSachThemMoi();
            Frm1.Show();
        }
        private void HienThiNguoiMuonSachDS()
        {
            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.LayToanBoNguoiMuonSach();
            lvNguoiMuonSachDS.Items.Clear();
            foreach (NguoiMuonSach nms in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nms.Id+"");
                lvi.SubItems.Add(nms.HoTen);
                lvi.SubItems.Add(nms.SoDienThoai);
                //lvi.SubItems.Add(nms.BieuHien);
                lvi.SubItems.Add(nms.DiaChi);
                lvi.SubItems.Add(nms.Email);
                lvi.SubItems.Add(nms.NamSinh+"");
                lvNguoiMuonSachDS.Items.Add(lvi);
            }
        }

        private void lvNguoiMuonSachDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNguoiMuonSachDS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvNguoiMuonSachDS.SelectedItems[0];
                string ma = lvi.SubItems[0].Text;
                string hoten = lvi.SubItems[1].Text;
                string sodienthoai = lvi.SubItems[2].Text;
                string diachi = lvi.SubItems[3].Text;
                string email = lvi.SubItems[4].Text;
                string namsinh = lvi.SubItems[5].Text;
                txtNMSMa.Text = ma;
                TxtNMSTen.Text = hoten;
                TxtNMSSoDienThoai.Text = sodienthoai;
                TxtNMSDiaChi.Text = diachi;
                TxtNMSEmail.Text = email;
                TxtNMSNamSinh.Text = namsinh;

            }
        }

        
    }
}
