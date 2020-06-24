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
        public string tendm = "";
        public string trangthai = "";
        public FrmSachXem(string id)
        {
            InitializeComponent();
            this.iddg = id;
        }
        private void FrmSachXem_Load(object sender, EventArgs e)
        {
            txtMaDG.Text = iddg + "";
            HienThiDanhSachSach();
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

        public void HienThiDanhSachSach()
        {
            SachBLL sacBLL = new SachBLL();
            //List<SachDAO> dssach = sacBLL.LayToanBoSachTrong();
            List<SachDAO> dssach = sacBLL.LayToanBoSachOderTrong(); //call sachbll để trả về dssach
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
                this.trangthai = trangthai;
            }
        }
        private void txtTimTenSach_Click(object sender, EventArgs e)
        {
            txtTimTenSach.Clear();
        }
        private void btnTimTenSach_Click(object sender, EventArgs e)
        {
            if (txtTimTenSach.Text == "")
            {
                HienThiDanhSachSach();
            }
            else
            {

                SachDAO tims = new SachDAO();
                tims.TenSach = txtTimTenSach.Text;

                SachBLL sacBLL = new SachBLL();
                //List<SachDAO> dssach = sacBLL.TimSachTrongTheoTen(tims);
                List<SachDAO> dssach = sacBLL.TimTenSach(tims);//call sachbll để trả về dssach
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
                MessageBox.Show("Mượn thành công, vui lòng chờ duyệt và đến thư viện nhận sách nhé." +
                    "\n Bạn có thể kiểm tra trạng thái ở tab Sách Mượn Của Tôi", "Thông Báo");
                
            }
        }

        private void btnUserTaoPhieu_Click(object sender, EventArgs e)
        {
            if (trangthai != "Trống")
            {
                MessageBox.Show("Sách đã được cho mượn. \n" +
                    "Bạn vui lòng mượn sách khác hoặc đợi sách được trả nhé");
            }
            else
            {
                erDuKienTra.SetError(dateDuKienTra, "");
                if (dateDuKienTra.Value <= dateNgayMuon.Value)
                {
                    erDuKienTra.SetError(dateDuKienTra, "Ngày dự kiến trả sau ngày bắt đầu mượn ...");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn mượn sách này?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UserTaoPhieu();
                    HienThiDanhSachSach();
                    TxtTenSach.Text = "";
                    TxtTenTacGia.Text = "";
                    TxtNamXuatBan.Text = "";
                    txtMaSach.Text = "";
                    TxtTenDanhMuc.Text = "";
                    TxtNgonNgu.Text = "";
                    richNoiDungSach.Text = "";
                }
            }
        }

        private void LvDanhMucDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvDanhMucDS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = LvDanhMucDS.SelectedItems[0];
                this.tendm = lvi.SubItems[1].Text;
            }
            SachDAO timdmc = new SachDAO();
            timdmc.TheLoai = this.tendm;
            SachBLL sacbll = new SachBLL();
            List<SachDAO> dssach = sacbll.TimSachTheoDanhMuc(timdmc);
            LvSachQL.Items.Clear();
            foreach (SachDAO scbll in dssach)
            {
                ListViewItem lvi = new ListViewItem(scbll.TenSach + "");
                lvi.SubItems.Add(scbll.TacGia);
                lvi.SubItems.Add(scbll.TheLoai);
                lvi.SubItems.Add(scbll.NgonNgu);
                lvi.SubItems.Add(scbll.NamXuatBan + "");
                lvi.SubItems.Add(scbll.TrangThai);
                lvi.SubItems.Add(scbll.NoiDungSach);
                lvi.SubItems.Add(scbll.ID + "");

                LvSachQL.Items.Add(lvi);
            }
        }

        private void GrBChiTiet_Enter(object sender, EventArgs e)
        {

        }
    }
}
