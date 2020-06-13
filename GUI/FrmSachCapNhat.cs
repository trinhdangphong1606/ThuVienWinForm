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
using DAL;
using DTO;

namespace GUI
{
    public partial class FrmSachCapNhat : Form
    {
        public FrmSachCapNhat()
        {
            InitializeComponent();
        }

        private void lvDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhMuc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhMuc.SelectedItems[0];
                string iddanhmuccc = lvi.SubItems[0].Text;
                string tendanhmuccc = lvi.SubItems[1].Text;
                TxtMaDanhMuc.Text = iddanhmuccc;
            }
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

        private void FrmSachCapNhat_Load(object sender, EventArgs e)
        {
            HienThiDSDanhMuc();
            //txtMa.Text = FrmDanhMucQL.PassMa;
            txtMaSach.Text = FrmSachQL.PassMaSach;
            txtTenSach.Text = FrmSachQL.PassTen;
            txtNgonNgu.Text = FrmSachQL.PassNgonNgu;
            txtTenDanhMuc.Text = FrmSachQL.PassTenDanhMuc;
            txtNamXuatBan.Text = FrmSachQL.PassNamSanXuat;
            richNoiDung.Text = FrmSachQL.PassNoiDung;
            txtTacGia.Text = FrmSachQL.PassTacGia;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorMaDanhMuc.SetError(TxtMaDanhMuc, "");
            if(TxtMaDanhMuc.Text == "")
            {
                errorMaDanhMuc.SetError(TxtMaDanhMuc, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            errorTenSach.SetError(txtTenSach, "");
            if (txtTenSach.Text == "")
            {
                errorTenSach.SetError(txtTenSach, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            errorTacGia.SetError(txtTacGia, "");
            if (txtTacGia.Text == "")
            {
                errorTacGia.SetError(txtTacGia, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            errorNoiDung.SetError(richNoiDung, "");
            if (richNoiDung.Text == "")
            {
                errorNoiDung.SetError(richNoiDung, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            errorMaSach.SetError(txtMaSach, "");
            if (txtMaSach.Text == "")
            {
                errorMaSach.SetError(txtMaSach, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            errorNamXuatBan.SetError(txtNamXuatBan, "");
            if (txtNamXuatBan.Text == "")
            {
                errorNamXuatBan.SetError(txtNamXuatBan, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            errorNgonNgu.SetError(txtNgonNgu, "");
            if (txtNgonNgu.Text == "")
            {
                errorNgonNgu.SetError(txtNgonNgu, "Xin chọn Danh Mục cần thay đổi");
                return;
            }

            Sach s = new Sach();
            //s.ID = int.Parse(txt)
            s.ID = int.Parse(txtMaSach.Text);
            s.TacGia = txtTacGia.Text;
            s.NgonNgu = txtNgonNgu.Text;
            s.NamXuatBan = int.Parse(txtNamXuatBan.Text);
            s.NoiDungSach = richNoiDung.Text;
            s.TenSach = txtTenSach.Text;
            s.DanhMucID = int.Parse(TxtMaDanhMuc.Text);

            SachBLL sabll = new SachBLL();
            bool capnhat = sabll.SuaSach(s);
            if(capnhat)
            {
                MessageBox.Show("Đã Thay Đổi Thành Công, Nhấn Cập Nhật Nhé ...", "Thông Báo");
                this.Close();
            }

        }
    }
}
