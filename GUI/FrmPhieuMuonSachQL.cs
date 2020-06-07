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
            txtTimNgay.Text= dtpickerNgayMuon.Value.ToString("dd");
            txtTimThang.Text = dtpickerNgayMuon.Value.ToString("MM");
            txtTimNam.Text = dtpickerNgayMuon.Value.ToString("yyyy");
        }
        private void txtTimThang_Click(object sender, EventArgs e)
        {
            txtTimThang.Text = "";
        }
        private void txtTimNgay_Click(object sender, EventArgs e)
        {
            txtTimNgay.Text = "";
        }
        private void txtTimNam_Click(object sender, EventArgs e)
        {
            txtTimNam.Text = "";
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
        private void btnCapNhatTrangThaiPhieu_Click(object sender, EventArgs e)
        {
            HienThiDSPhieuMuonSach();
        }
        private void btnPhieuDangMo_Click(object sender, EventArgs e)
        {
            HienThiDSPhieuMuonSachDangMo();
        }
        private void btnPhieuDaDong_Click(object sender, EventArgs e)
        {
            HienThiDSPhieuMuonSachDaDong();
        }
        private void BtnXemTatCa_Click(object sender, EventArgs e)
        {
            HienThiDSPhieuMuonSach();
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
            txtTimMaPhieu.Text = "";
            txtTimPhieuTheoTen.Text = "";
        }
        private void HienThiDSPhieuMuonSachDangMo()
        {
            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.LayPhieuDangMo();
            lvDSPhieuMuon.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvDSPhieuMuon.Items.Add(lvi);
            }
            txtTimMaPhieu.Text = "";
            txtTimPhieuTheoTen.Text = "";
        }
        private void HienThiDSPhieuMuonSachDaDong()
        {
            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.LayPhieuDaDong();
            lvDSPhieuMuon.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvDSPhieuMuon.Items.Add(lvi);
            }
            txtTimMaPhieu.Text = "";
            txtTimPhieuTheoTen.Text = "";
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
                    txtTrangThaiPhieu.Text = "Phiếu Đang Mở Chưa trả sách";
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
        private void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            errorTimMaPhieu.SetError(txtTimMaPhieu, "");
            if(txtTimMaPhieu.Text=="")
            {
                errorTimMaPhieu.SetError(txtTimMaPhieu, "Nhập Mã Phiếu Muốn Tìm");
                return;
            }    
            PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
            pms.MaPhieuMuon = int.Parse(txtTimMaPhieu.Text);

            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.TimPhieuTheoMa(pms);
            lvDSPhieuMuon.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvDSPhieuMuon.Items.Add(lvi);
            }
            txtTimPhieuTheoTen.Text = "";
        }
        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            errorTimTenDocGia.SetError(txtTimPhieuTheoTen, "");
            if(txtTimPhieuTheoTen.Text=="")
            {
                errorTimTenDocGia.SetError(txtTimPhieuTheoTen, "Nhập Tên Đọc Giả Của Phiếu Cần Tìm");
                return;
            }    
            PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
            pms.TenNguoiMuonSach = txtTimPhieuTheoTen.Text;

            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.TimPhieuTheoten(pms);
            lvDSPhieuMuon.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvDSPhieuMuon.Items.Add(lvi);
            }
            txtTimMaPhieu.Text = "";
        }
        private void btnTimThoiGianTao_Click(object sender, EventArgs e)
        {
            PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
            pms.ngay = int.Parse(txtTimNgay.Text);
            pms.thang = int.Parse(txtTimThang.Text);
            pms.nam = int.Parse(txtTimNam.Text);

            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.TimphieuTheoNgay(pms);
            lvDSPhieuMuon.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
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
