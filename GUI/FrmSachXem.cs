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
using System.Runtime.CompilerServices;

namespace GUI
{
    public partial class FrmSachXem : Form
    {
        string iddg = "";
        public FrmSachXem(string id)
        {
            InitializeComponent();
            this.iddg = id;
        }
        private void FrmSachXem_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSach();
            
        }
        public void HienThiDanhSachSach()
        {
            SachBLL sacBLL = new SachBLL();
            List<SachDAO> dssach = sacBLL.LayToanBoSachTrong(); //call sachbll để trả về dssach
            LvSachQL.Items.Clear();
            foreach (SachDAO scBLL in dssach)
            //duyệt tuần tự các phần tử trong mảng dssach
            {
                ListViewItem lvi = new ListViewItem(scBLL.TenSach + "");
                lvi.SubItems.Add(scBLL.TacGia);
                lvi.SubItems.Add(scBLL.TheLoai);
                lvi.SubItems.Add(scBLL.NgonNgu);
                lvi.SubItems.Add(scBLL.NamXuatBan + "");
                lvi.SubItems.Add(scBLL.TrangThai + "");
                lvi.SubItems.Add(scBLL.NoiDungSach + "");
                lvi.SubItems.Add(scBLL.ID + "");
                LvSachQL.Items.Add(lvi);
                
            }
        }
        private void LvSachQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvSachQL.SelectedItems.Count > 0)
            {
                ListViewItem lvi = LvSachQL.SelectedItems[0];
                string tensach = lvi.SubItems[0].Text;
                string tacgia = lvi.SubItems[1].Text;
                string danhmuc = lvi.SubItems[2].Text;
                string ngonngu = lvi.SubItems[3].Text;
                string namxuatban = lvi.SubItems[4].Text;
                string trangthai = lvi.SubItems[5].Text;
                string noidung = lvi.SubItems[6].Text;
                string id = lvi.SubItems[7].Text;
                TxtTenSach.Text = tensach;
                TxtTenTacGia.Text = tacgia;
                TxtTenDanhMuc.Text = danhmuc;
                TxtNgonNgu.Text = ngonngu;
                TxtNamXuatBan.Text = namxuatban;
                richNoiDungSach.Text = noidung;
                txtMaSach.Text = id;
            }
        }
        private void txtTimTenSach_Click(object sender, EventArgs e)
        {
            txtTimTenSach.Clear();
        }
        private void btnTimTenSach_Click(object sender, EventArgs e)
        {
            SachDAO tims = new SachDAO();
            tims.TenSach = txtTimTenSach.Text;

            SachBLL sacBLL = new SachBLL();
            List<SachDAO> dssach = sacBLL.TimSachTrongTheoTen(tims); //call sachbll để trả về dssach
            LvSachQL.Items.Clear();
            foreach (SachDAO scBLL in dssach)
            //duyệt tuần tự các phần tử trong mảng dssach
            {
                ListViewItem lvi = new ListViewItem(scBLL.TenSach + "");
                lvi.SubItems.Add(scBLL.TacGia);
                lvi.SubItems.Add(scBLL.TheLoai);
                lvi.SubItems.Add(scBLL.NgonNgu);
                lvi.SubItems.Add(scBLL.NamXuatBan + "");
                lvi.SubItems.Add(scBLL.TrangThai + "");
                lvi.SubItems.Add(scBLL.NoiDungSach + "");
                lvi.SubItems.Add(scBLL.ID + "");
                LvSachQL.Items.Add(lvi);

            }
        }
        private void UserTaoPhieu()
        {
            PhieuMuonSach pms = new PhieuMuonSach();
            pms.NguoiMuonSachId = int.Parse(iddg);
            pms.SachId = int.Parse(txtMaSach.Text);
            pms.NgayMuon = dateNgayMuon.Value;
            pms.NgayDuKienTra = dateDuKienTra.Value;

            PhieuMuonSachBLL pmsbll = new PhieuMuonSachBLL();
            bool phieumoi = pmsbll.DocGiaTaoPhieu(pms);
            if (phieumoi)
            {
                MessageBox.Show("Nhấn nút cập nhật nhé!!!", "Thông Báo");
                this.Close();
            }
        }

        private void btnUserTaoPhieu_Click(object sender, EventArgs e)
        {
            erDuKienTra.SetError(dateDuKienTra, "");
            if (dateDuKienTra.Value <= dateNgayMuon.Value)
            {
                erDuKienTra.SetError(dateDuKienTra, "Ngày dự kiến trả sau ngày bắt đầu mượn ...");
                return;
            }
            UserTaoPhieu();
        }
    }
}
