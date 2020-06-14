using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using DTO;
namespace GUI
{
    public partial class FrmPhieuMuonSachDong : Form
    {
        public FrmPhieuMuonSachDong()
        {
            InitializeComponent();
        }
        private void FrmPhieuMuonSachDong_Load(object sender, EventArgs e)
        {
            txtReadyMaPhieu.Text = FrmPhieuMuonSachQL.PassMaPhieuMuon;
            txtReadyTenDocGia.Text = FrmPhieuMuonSachQL.PassTenDocGia;
            txtReadyTenSach.Text = FrmPhieuMuonSachQL.PassTenSach;
            dtpReadyNgayMuon.Value = FrmPhieuMuonSachQL.PassNgayMuon;

            SachDAO sac = new SachDAO();
            sac.TenSach = txtReadyTenSach.Text;

            SachBLL sacbll = new SachBLL();
            List<SachDAO> dssachtim = sacbll.TimTenSach(sac);
            foreach (SachDAO sachtim in dssachtim)
            {
                txtMaSach.Text = sachtim.ID + "";

            }


        }
        
        private void btnXacNhanThongTinDong_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpReadyNgayTra, "");
            if (dtpReadyNgayTra.Value<=dtpReadyNgayMuon.Value)
            {
                errorProvider1.SetError(dtpReadyNgayTra, "Xin chọn ngày ...");
                return;
            }
            else
            {
                

                XacNhanThongTinDong();
            }
            
        }
        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongPhieuMuon_Click(object sender, EventArgs e)
        {
            if(txtConfirmMaPhieu.Text=="")
            {
                MessageBox.Show("Xác nhận thông tin phiếu trước khi đóng", "Thông Báo");
            }
            else
            {
                DongPhieuMuon();
            }    
            
        }
        private void XacNhanThongTinDong()
        {
            txtConfirmMaPhieu.Text= txtReadyMaPhieu.Text;
            txtConfirmTenDocGia.Text = txtReadyTenDocGia.Text;
            txtConfirmTenSach.Text = txtReadyTenSach.Text;
            dtpConfirmNgayMuon.Value = dtpReadyNgayMuon.Value;
            dtpConfirmNgayTra.Value = dtpReadyNgayTra.Value;

        }
        private void DongPhieuMuon()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.MaPhieuMuon = int.Parse(txtConfirmMaPhieu.Text);
            pms.NgayTraSach = dtpConfirmNgayTra.Value;

            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool closephieu = pmsbll.DongPhieuMuon(pms);

            Sach sac = new Sach();
            sac.ID = int.Parse(txtMaSach.Text) ;
            SachBLL scbll = new SachBLL();
            bool trangthai = scbll.CapNhatPhieuMuon(sac);

            if(closephieu && trangthai)
            {
                MessageBox.Show("Nhấn nút cập nhật nhé!!!", "Thông Báo");
                this.Close();
            }    
        }

        private void test_Click(object sender, EventArgs e)
        {
            
        }
    }
}
