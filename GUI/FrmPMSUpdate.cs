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
using DTO;
using System.Reflection;

namespace GUI
{
    public partial class FrmPMSUpdate : Form
    {
        public int madg = 0;
        public int masach = 0;
        public int masachtra = 0;
        public FrmPMSUpdate()
        {
            InitializeComponent();
        }

        private void FrmPMSUpdate_Load(object sender, EventArgs e)
        {
            HienThiDSCanDuyet();
            HienThiDSChoDocGia();
            HienThiDSDocGia();
            HienThiDSSach();
            HienThiDSChuaTraSach();
        }

        // start tab chờ duyệt
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
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn duyệt?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChapThuanDuyet();
                    HienThiDSCanDuyet();
                    HienThiDSChoDocGia();
                }
            }
        }
        private void btnKhongDuyetPhieuMoi_Click(object sender, EventArgs e)
        {
            if (txtCDMaP.Text == "")
            {
                MessageBox.Show("Chọn Phiếu Không Duyệt", "Thông Báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn không duyệt?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TuChoiDuyet();
                    HienThiDSCanDuyet();
                    HienThiDSChoDocGia();
                }
            }    
        }
        private void ChapThuanDuyet()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.MaPhieuMuon = int.Parse(txtCDMaP.Text);

            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool chapthuan = pmsbll.ChapThuanPhieuDuyet(pms);
            if(chapthuan)
            {
                MessageBox.Show("Bạn Đã Chấp Thuận Phiếu \n Đợi Đọc Giả Đến Nhận Nhé", "Thông Báo");
            }
        }
        private void TuChoiDuyet()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.MaPhieuMuon = int.Parse(txtCDMaP.Text);
            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool tuchoi = pmsbll.TuChoiPhieuDuyet(pms);
            
            Sach sac = new Sach();
            sac.TenSach = txtCDS.Text;
            SachBLL sacbll = new SachBLL();
            bool capnhat = sacbll.CapNhatTrangThaiLoi(sac);
            if(capnhat && tuchoi)
            {
                MessageBox.Show("Bạn Đã Từ Chối Phiếu Duyệt \n Xử lý sách bị lỗi nhé", "Thông Báo");
                HienThiDSCanDuyet();
            }    
        }
        // end tab chờ duyệt


        // start tab chờ đọc giả mượn sách

        private void HienThiDSChoDocGia()
        {
            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.LayPhieuMuonChoDocGia ();
            lvCMPMS.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvi.SubItems.Add(pmsBLL.TrangThai);
                lvCMPMS.Items.Add(lvi);
            }
        }

        private void lvCMPMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvCMPMS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvCMPMS.SelectedItems[0];
                txtCMMaP.Text = lvi.SubItems[0].Text;
                txtCMDG.Text = lvi.SubItems[1].Text;
                txtCMS.Text = lvi.SubItems[2].Text;
                dtCMNgayMuon.Value = Convert.ToDateTime(lvi.SubItems[3].Text);
                dtCMDuKienTra.Value = Convert.ToDateTime(lvi.SubItems[4].Text);
            }
        }
        private void ChapThuanPhieuChoMuon()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.MaPhieuMuon = int.Parse(txtCMMaP.Text);
            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool chapthuanchomuon = pmsbll.ChapThuanPhieuChoMuon(pms);
            if(chapthuanchomuon)
            {
                MessageBox.Show("Đã lưu thông tin mượn sách của đọc giả", "Thông báo");
            }
        }
        private void TuChoiPhieuChoMuon()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.MaPhieuMuon = int.Parse(txtCMMaP.Text);
            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool tuchoichomuon = pmsbll.TuChoiPhieuChoMuon(pms);
            Sach sac = new Sach();
            sac.TenSach = txtCMS.Text;
            SachBLL sacbll = new SachBLL();
            bool dgkhongden = sacbll.CapNhatDocGiaKhongDen(sac);
            if (dgkhongden && tuchoichomuon)
            {
                MessageBox.Show("Đã cập nhật thông tin", "Thông báo");
            }
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            if(txtCMMaP.Text=="")
            {
                MessageBox.Show("Chọn đọc giả cần mượn sách", "Thông Báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn cho mượn sách?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChapThuanPhieuChoMuon();
                    HienThiDSChoDocGia();
                    HienThiDSChuaTraSach();
                }
            }

        }
        private void btnTuChoiChoMuon_Click(object sender, EventArgs e)
        {
            if (txtCMMaP.Text == "")
            {
                MessageBox.Show("Chọn đọc giả cần từ chối", "Thông Báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn từ chối?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TuChoiPhieuChoMuon();
                    HienThiDSChoDocGia();
                }
            }
        }
        // End tab chờ đọc giả nhận sách

        // Start tab cho đọc giả mượn tại chỗ
        private void HienThiDSDocGia()
        {
            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.LayToanBoNguoiMuonSach();
            lvCMTCDSDG.Items.Clear();
            foreach (NguoiMuonSach nms in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nms.Id + "");
                lvi.SubItems.Add(nms.HoTen);
                lvCMTCDSDG.Items.Add(lvi);
            }
        }

        private void lvCMTCDSDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvCMTCDSDG.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvCMTCDSDG.SelectedItems[0];
                this.madg = int.Parse(lvi.SubItems[0].Text);
                txtCMTCDG.Text = lvi.SubItems[1].Text;

            }    
        }
        private void HienThiDSSach()
        {
            SachBLL sacbll = new SachBLL();
            List<Sach> dsSach = sacbll.LayAllToanBoSachTrong();
            lvCMTCDSSach.Items.Clear();
            foreach(Sach sac in dsSach)
            {
                ListViewItem lvi = new ListViewItem(sac.ID + "");
                lvi.SubItems.Add(sac.TenSach);
                lvCMTCDSSach.Items.Add(lvi);
            }
        }

        private void lvCMTCDSSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvCMTCDSSach.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvCMTCDSSach.SelectedItems[0];
                this.masach = int.Parse(lvi.SubItems[0].Text);
                txtCMTCTS.Text = lvi.SubItems[1].Text;
            }
        }

        private void btnCMTC_Click(object sender, EventArgs e)
        {
            errCMTCTenDG.SetError(txtCMTCDG, "");
            errCMTCTenSach.SetError(txtCMTCTS, "");
            errDuKienTra.SetError(dtCMTCDuKienTra, "");
            if (txtCMTCDG.Text == "")
            {
                errCMTCTenDG.SetError(txtCMTCDG, "Xin chọn đọc giả ...");
                return;
            }
            if (txtCMTCTS.Text == "")
            {
                errCMTCTenSach.SetError(txtCMTCTS, "Xin chọn sách mượn ...");
                return;
            }
            if (dtCMTCDuKienTra.Value <= dtCMTCNgayMuon.Value)
            {
                errDuKienTra.SetError(dtCMTCDuKienTra, "Ngày dự kiến trả sau ngày bắt đầu mượn ...");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn cho mượn sách?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChoMuonSachTaiCho();
                HienThiDSSach();
                HienThiDSChuaTraSach();
            }
        }
        private void ChoMuonSachTaiCho()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.NguoiMuonSachId = this.madg;
            pms.SachId = this.masach;
            pms.NgayMuon = dtCMTCNgayMuon.Value;
            pms.NgayDuKienTra = dtCMTCDuKienTra.Value;

            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool phieumoi = pmsbll.ThemPhieuMuon(pms);
            if (phieumoi)
            {
                MessageBox.Show("Đã Lưu thông tin mượn sách của đọc giả", "Thông Báo");
            }
        }
        //End  tab Cho Mượn Tại Chỗ
        // start  tab trả sách
        private void HienThiDSChuaTraSach()
        {
            PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.LayPhieuDangMo();
            lvTSPMS.Items.Clear();
            foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
            {
                ListViewItem lvi = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                lvi.SubItems.Add(pmsBLL.TenNguoiMuonSach);
                lvi.SubItems.Add(pmsBLL.TenSach);
                lvi.SubItems.Add(pmsBLL.NgayMuon.ToString());
                lvi.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                lvi.SubItems.Add(pmsBLL.NgayTraSach.ToString());
                lvTSPMS.Items.Add(lvi);
            }
        }

        private void lvTSPMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvTSPMS.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvTSPMS.SelectedItems[0];
                txtTSMaP.Text = lvi.SubItems[0].Text;
                txtTSDG.Text = lvi.SubItems[1].Text;
                txtTSS.Text = lvi.SubItems[2].Text;
                dtTSDuKienTra.Value = Convert.ToDateTime(lvi.SubItems[4].Text);
                Sach sac = new Sach();
                sac.TenSach = txtTSS.Text;
                SachBLL sacbll = new SachBLL();
                List<Sach> dsSach = sacbll.TimMaSach(sac);
                foreach (Sach itemsach in dsSach)
                {
                    txtTSMaS.Text = itemsach.ID + "";
                }
            }    
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if(txtTSMaP.Text=="")
            {
                MessageBox.Show("Xin chọn mã phiếu của đọc giả", "Thông Báo");
            }    
            else
            {
                TraSach();
                HienThiDSChuaTraSach();
            }    
        }

        private void TraSach()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.MaPhieuMuon = int.Parse(txtTSMaP.Text);
            pms.NgayTraSach = dtTSNgayTra.Value;
            
            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool trasach = pmsbll.DongPhieuMuon(pms);
            Sach idtra = new Sach();
            idtra.ID = int.Parse(txtTSMaS.Text);
            SachBLL trasachbll = new SachBLL();
            bool capnhat = trasachbll.CapNhatPhieuMuon(idtra);

            if (trasach&&capnhat)
            {
                MessageBox.Show("Đã lưu thông tin", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Stuck");
            }    
        }
    }
}
