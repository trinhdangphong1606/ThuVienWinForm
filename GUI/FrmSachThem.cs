using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DAL;


namespace GUI
{
    public partial class FrmSachThem : Form
    {
        public FrmSachThem()
        {
            InitializeComponent();
        }
        private void HienThiDSDanhMuc()
        {
            DanhMucBLL damuBLL = new DanhMucBLL();
            List<DanhMuc> dsdanhmuc = damuBLL.LayToanBoDanhMuc();
            lvDanhMuc.Items.Clear();
            foreach (DanhMuc damuc in dsdanhmuc)
            {
                ListViewItem lvi = new ListViewItem(damuc.IdDanhMuc + "");
                lvi.SubItems.Add(damuc.TenDanhMuc);
                lvi.SubItems.Add(damuc.NoiDungDanhMuc);
                lvDanhMuc.Items.Add(lvi);
            }
        }
        private void lvDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhMuc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhMuc.SelectedItems[0];
                string iddanhmuccc = lvi.SubItems[0].Text;
                
                TxtMaDanhMuc.Text = iddanhmuccc;
            }

        }

        private void FrmSachThem_Load(object sender, EventArgs e)
        {
            HienThiDSDanhMuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errorTenSach.SetError(TxtTenSach, "");
            if (TxtTenSach.Text == "")
            {
                errorTenSach.SetError(TxtTenSach, "Xin nhập tên sách");
                return;
            }
            errorTacGia.SetError(TxtTenTacGia, "");
            if (TxtTenTacGia.Text == "")
            {
                errorTacGia.SetError(TxtTenTacGia, "Xin nhập tên tác giả");
                return;
            }
            errorNgonNgu.SetError(TxtNgonNgu, "");
            if (TxtNgonNgu.Text == "")
            {
                errorNgonNgu.SetError(TxtNgonNgu, "Xin nhập ngôn ngữ ");
                return;
            }
            errorNamXuatBan.SetError(TxtNamXuatBan, "");
            if (TxtNamXuatBan.Text == "")
            {
                errorNamXuatBan.SetError(TxtNamXuatBan, "Xin nhập năm xuất bản ");
                return;
            }
            errorMaDanhMuc.SetError(TxtMaDanhMuc, "");
            if (TxtMaDanhMuc.Text == "")
            {
                errorMaDanhMuc.SetError(TxtMaDanhMuc, "Xin nhập mã danh mục ");
                return;
            }
            errorNoiDung.SetError(richNoiDungSach, "");
            if (richNoiDungSach.Text == "")
            {
                errorNoiDung.SetError(richNoiDungSach, "Xin nhập nội dung sách ");
                return;
            }
            ThemSach();
        }
        private void ThemSach()
        {
            Sach s = new Sach();
            s.DanhMucID = int.Parse(TxtMaDanhMuc.Text);
            s.TenSach = TxtTenSach.Text;
            s.TacGia = TxtTenTacGia.Text;
            s.NgonNgu = TxtNgonNgu.Text;
            s.NoiDungSach = richNoiDungSach.Text;
            s.NamXuatBan = int.Parse(TxtNamXuatBan.Text);

            SachBLL sbll = new SachBLL();
            bool sachnew = sbll.ThemSach(s);
            if (sachnew)
            {
                MessageBox.Show("Thêm thành công..Nhấn Nút Cập Nhật Nhé.", "Thông Báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSachThem_Load_1(object sender, EventArgs e)
        {
            HienThiDSDanhMuc();
        }
    }
}
