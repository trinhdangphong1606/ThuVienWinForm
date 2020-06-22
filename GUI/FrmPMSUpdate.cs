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
using BLL;
namespace GUI
{
    public partial class FrmPMSUpdate : Form
    {
        public FrmPMSUpdate()
        {
            InitializeComponent();
        }

        private void FrmPMSUpdate_Load(object sender, EventArgs e)
        {
            HienThiDSCanDuyet();

        }
        private void HienThiDSCanDuyet()
        {
            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.LayPhieuMuonChoDuyet();
            lvCDPMS.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvi.SubItems.Add(pmsBLL.TrangThai);
                lvCDPMS.Items.Add(lvi);
            }
        }

        private void lvPMSCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvCDPMS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvCDPMS.SelectedItems[0];
                txtCDMaP.Text = lvi.SubItems[0].Text;
                txtCDDG.Text = lvi.SubItems[1].Text;
                txtCDS.Text = lvi.SubItems[2].Text;
                dtNgayMuon.Value = Convert.ToDateTime(lvi.SubItems[3].Text);
                dtDuKienTra.Value = Convert.ToDateTime(lvi.SubItems[4].Text);
            }    
        }

        private void btnDuyetPhieuMoi_Click(object sender, EventArgs e)
        {
            if(txtCDMaP.Text=="")
            {
                MessageBox.Show("Chọn Phiếu Cần Duyệt", "Thông Báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Đã Chuẩn Bị Xong Sách Cho Đọc Giả?", "Thông Báo", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
        }
    }
}
