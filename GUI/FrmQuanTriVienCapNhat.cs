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

namespace GUI
{
    public partial class FrmQuanTriVienCapNhat : Form
    {
        public FrmQuanTriVienCapNhat()
        {
            InitializeComponent();
        }

        private void FrmQuanTriVienCapNhat_Load(object sender, EventArgs e)
        {
            txtAccount.Text = FrmQuanTriVienQL.passAccount;
            txtDiaChi.Text = FrmQuanTriVienQL.passDiaChi;
            txtEmail.Text = FrmQuanTriVienQL.passEmail;
            txtMa.Text = FrmQuanTriVienQL.PassMa;
            txtNamSinh.Text = FrmQuanTriVienQL.passNamSinh;
            txtSoDienThoai.Text = FrmQuanTriVienQL.PassSoDT;
            txtTen.Text = FrmQuanTriVienQL.PassTen;
            txtQuyen.Text = FrmQuanTriVienQL.passQuyen;
        }
        private void ThayDoiThongTin()
        {
            QuanTriVien qtv = new QuanTriVien();
            qtv.TenDangNhap = txtAccount.Text;
            qtv.DiaChi = txtDiaChi.Text;
            qtv.Email = txtEmail.Text;
            qtv.ID = int.Parse(txtMa.Text);
            qtv.NamSinh = int.Parse(txtNamSinh.Text);
            qtv.SoDienThoai = txtSoDienThoai.Text;
            qtv.HoTen = txtTen.Text;
            qtv.Quyen = txtQuyen.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            bool capnhat = qtvbll.ChinhSuaQuanTriVien(qtv);
            if(capnhat)
            {
                MessageBox.Show("Đã thay đổi thông tin \n Nhấn nút cập nhật nhé.", "Thông Báo");
                this.Close();
            }    
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThayDoiThongTin();
        }

        private void btnQuyenAdmin_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "Admin";
        }

        private void btnQuyenStaff_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "Staff";
        }

        private void btnQuyenUser_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "User";
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
