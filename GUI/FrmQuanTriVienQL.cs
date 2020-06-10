using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmQuanTriVienQL : Form
    {
        public static string PassMa = "";
        public static string PassTen = "";
        public static string PassSoDT = "";
        public static string passNamSinh = "";
        public static string passEmail = "";
        public static string passAccount = "";
        public static string passDiaChi = "";
        public static string passQuyen = "";

        public FrmQuanTriVienQL()
        {
            InitializeComponent();
        }

        private void FrmQuanTriVienQL_Load(object sender, EventArgs e)
        {
            HienThiDanhSachQuanTriVien();
        }
        private void btnQuanTriVienCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDanhSachQuanTriVien();
        }
        private void BtnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn quản trị viên muốn thay đổi thông tin", "Thông Báo");
            }
            else
            {
                ThayDoiThongTin();
            }
        }
        private void HienThiDanhSachQuanTriVien()
        {
            QuanTriVienBLL quantrivienBLL = new QuanTriVienBLL();
            List<QuanTriVien> dsquanntrivien = quantrivienBLL.LayToanBoQuanTriVien();
            lvQuanTriVienDS.Items.Clear();
            foreach (QuanTriVien qtvien in dsquanntrivien)
            {
                ListViewItem lvi = new ListViewItem(qtvien.HoTen);
                lvi.SubItems.Add(qtvien.SoDienThoai);
                lvi.SubItems.Add(qtvien.TenDangNhap);
                lvi.SubItems.Add(qtvien.Email);
                lvi.SubItems.Add(qtvien.NamSinh + "");
                lvi.SubItems.Add(qtvien.DiaChi);
                lvi.SubItems.Add(qtvien.ID+"");
                lvi.SubItems.Add(qtvien.KeyRestore);
                lvi.SubItems.Add(qtvien.MatKhau);
                lvi.SubItems.Add(qtvien.Quyen);
                lvQuanTriVienDS.Items.Add(lvi);
            }
        }
        private void lvQuanTriVienDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQuanTriVienDS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvQuanTriVienDS.SelectedItems[0];
                string hoten = lvi.SubItems[0].Text;
                string sodienthoai = lvi.SubItems[1].Text;
                string tendangnhap = lvi.SubItems[2].Text;
                string email = lvi.SubItems[3].Text;
                string namsinh = lvi.SubItems[4].Text;
                string diachi = lvi.SubItems[5].Text;
                string id = lvi.SubItems[6].Text;
                string keyrestore = lvi.SubItems[7].Text;
                string matkhau = lvi.SubItems[8].Text;
                string quyen = lvi.SubItems[9].Text;

                txtTen.Text = hoten;
                txtEmail.Text = email;
                txtDiaChi.Text = diachi;
                txtNamSinh.Text = namsinh;
                txtSoDienThoai.Text = sodienthoai;
                txtMa.Text = id;
                txtAccount.Text = tendangnhap;
                txtQuyen.Text = quyen;
            }
        }
        private void ThayDoiThongTin()
        {
            PassMa = txtMa.Text;
            passAccount = txtAccount.Text;
            passDiaChi = txtDiaChi.Text;
            passEmail = txtEmail.Text;
            passNamSinh = txtNamSinh.Text;
            PassSoDT = txtSoDienThoai.Text;
            PassTen = txtTen.Text;
            passQuyen = txtQuyen.Text;

            FrmQuanTriVienCapNhat frm1 = new FrmQuanTriVienCapNhat();
            frm1.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDanhSachQuanTriVien();
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            FrmQuanTriVienThemMoi frm1 = new FrmQuanTriVienThemMoi();
            frm1.Show();
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn quản trị viên muốn Reset Mật Khẩu", "Thông Báo");
            }
            else
            {
                ResetMatKhauQuanTriVien();
            }
        }

        private void ResetMatKhauQuanTriVien()
        {
            PassMa = txtMa.Text;
            passAccount = txtAccount.Text;

            FrmQuanTriVienResetMatKhau frm1 = new FrmQuanTriVienResetMatKhau();
            frm1.Show();
        }
    }
}
