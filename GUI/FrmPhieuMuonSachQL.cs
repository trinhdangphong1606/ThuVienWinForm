using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DAO;

namespace GUI
{
    public partial class FrmPhieuMuonSachQL : Form
    {
        private void FrmPhieuMuonSachQL_Load(object sender, EventArgs e)
        {
            HienThiDSPhieuMuonSach();
        }
        public FrmPhieuMuonSachQL()
        {
            InitializeComponent();
        }

        private void BtnPMSMo_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonSachMo frm1 = new FrmPhieuMuonSachMo();
            frm1.Show();
        }

        private void BtnPMSDong_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonSachDong frm1 = new FrmPhieuMuonSachDong();
            frm1.Show();
        }
        private void HienThiDSPhieuMuonSach()
        {
            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.LayToanBoPhieuMuon();
            lvDSPhieuMuon.Items.Clear();
            foreach(PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvDSPhieuMuon.Items.Add(lvi);
            }
        }

    }
}
