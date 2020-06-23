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
using System.Security.Cryptography;

namespace GUI
{
    public partial class FrmPhieuMuonDG : Form
    {
        string iddg = "";//TimNguoiMuonTheoMa
        string ten = "";
        public FrmPhieuMuonDG(string id)
        {
            InitializeComponent();
            this.iddg = id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            HienThiPhieuUSer();
        }

        private void HienThiPhieuUSer()
        {
            NguoiMuonSach nms = new NguoiMuonSach();
            nms.Id = int.Parse(this.iddg);
            NguoiMuonSachBLL nmsbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = nmsbll.TimNguoiMuonTheoMa(nms);
            foreach (NguoiMuonSach tennms in dsngmsach)
            {
                this.ten = tennms.HoTen;
            }
            PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
            pms.TenNguoiMuonSach = ten;
            PhieuMuonSachBLL pmsdgbll = new PhieuMuonSachBLL();
            List<PhieuMuonSachDAO> dsphieu = pmsdgbll.PhieuCuaDG(pms);
            lvPhieuMuonUser.Items.Clear();
            foreach(PhieuMuonSachDAO ctpms in dsphieu)
            {
                ListViewItem lvi = new ListViewItem(ctpms.MaPhieuMuon + "");
                lvi.SubItems.Add(ctpms.TenSach);
                lvi.SubItems.Add(ctpms.TrangThai);
                lvi.SubItems.Add(ctpms.NgayMuon.ToString());
                lvi.SubItems.Add(ctpms.NgayDuKienTra.ToString());
                lvi.SubItems.Add(ctpms.NgayTraSach.ToString());
                lvPhieuMuonUser.Items.Add(lvi);

            }
            
        }

        private void lvPhieuMuonUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvPhieuMuonUser.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvPhieuMuonUser.SelectedItems[0];
                txtMaP.Text = lvi.SubItems[0].Text;
                txtTenSach.Text = lvi.SubItems[1].Text;
                txtTrangThai.Text = lvi.SubItems[2].Text;
                HienThiGhiChu();
            }    

        }
        private void HienThiGhiChu()
        {
            if(txtTrangThai.Text== "Đã Trả Sách")
            {
                txtGhiChu.Text = "Bạn đã trả sách. \n Xin cảm ơn bạn";
            }
            else if(txtTrangThai.Text=="Sách lỗi đã được xử lý")
            {
                txtGhiChu.Text = "Xin lỗi bạn về sự cố vừa qua. \n Thư viện đã thay sách mới. \n" +
                    "Bạn đã có thể mượn lại quyển sách này";
            }    
            else if(txtTrangThai.Text == "Đọc giả không đến")
            {
                txtGhiChu.Text = "Bạn đã không đến nhận sách này. \n " +
                    "Thư viện đã trả sách về vị trí cũ.\n" +
                    "Bạn vui lòng mượn lại nhé";
            }    
            else if(txtTrangThai.Text == "Sách bị lỗi")
            {
                txtGhiChu.Text = "Hiện tại sách này đang bị hư hỏng.\n " +
                    "Thư việc sẽ sớm thay sách mới. " +
                    "\n Mong quý đọc giả theo dõi thông tin để mượn sách nhé.";
            }
            else if (txtTrangThai.Text == "Chờ duyệt")
            {
                txtGhiChu.Text = "Sách đang được thủ thư chuẩn bị.\n " +
                    "Bạn vui lòng đợi chuẩn bị xong nhé";
            }
        }

        
    }
}
