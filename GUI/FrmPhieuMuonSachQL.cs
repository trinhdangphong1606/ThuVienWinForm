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
        public static string PassMaPhieuMuon = "";
        public static string PassTenDocGia = "";
        public static string PassTenSach = "";
        public static DateTime PassNgayMuon ;
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
            if(txtMaPhieuMuon.Text=="")
            {
                MessageBox.Show("Chọn Phiếu Muốn Đóng", "Thông báo");
            }    
            else
            {
                if(txtTrangThaiPhieu.Text=="Phiếu Đã Đóng")
                {
                    MessageBox.Show("Phiếu này đã đóng", "Thông báo");
                }
                else
                {
                    DongPhieuMuon();
                }    
            }    
            
        }

        private void DongPhieuMuon()
        {
            PassMaPhieuMuon = txtMaPhieuMuon.Text;
            PassTenDocGia = txtTenDocGia.Text;
            PassTenSach = txtTenSach.Text;
            PassNgayMuon = dtpickerNgayMuon.Value;

            FrmPhieuMuonSachDong frm2 = new FrmPhieuMuonSachDong();
            frm2.Show();
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

        private void lvDSPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDSPhieuMuon.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvDSPhieuMuon.SelectedItems[0];
                string maphieumuon = lvi.SubItems[0].Text;
                string tendocgia = lvi.SubItems[1].Text;
                string tensach = lvi.SubItems[2].Text;
                string ngaymuon = lvi.SubItems[3].Text;
                string ngaydukientra = lvi.SubItems[4].Text;
                if(lvi.SubItems[5].Text=="")
                {
                    txtTrangThaiPhieu.Text = "Phiếu Đang Mở";
                }
                else
                {
                    string ngaytra = lvi.SubItems[5].Text;
                    dtpickerNgayTra.Value = Convert.ToDateTime(ngaytra);
                    txtTrangThaiPhieu.Text = "Phiếu Đã Đóng";
                }
                txtMaPhieuMuon.Text = maphieumuon;
                txtTenDocGia.Text = tendocgia;
                txtTenSach.Text = tensach;
                dtpickerNgayMuon.Value = Convert.ToDateTime(ngaymuon);
                dtpickerNgayDuKienTra.Value = Convert.ToDateTime(ngaydukientra);
                
                
            }    
        }

        private void btnCapNhatTrangThaiPhieu_Click(object sender, EventArgs e)
        {
            HienThiDSPhieuMuonSach();
        }
    }
}
