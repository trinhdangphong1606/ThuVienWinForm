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
    public partial class FrmQuanTriVienThemMoi : Form
    {
        public FrmQuanTriVienThemMoi()
        {
            InitializeComponent();
        }

        private void FrmQuanTriVienThemMoi_Load(object sender, EventArgs e)
        {

        }

        private void btnQuyenAdmin_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "Admin";
        }

        private void btnQuyenStaff_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "Staff";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            errorHoTen.SetError(txtTen, "");
            if (txtTen.Text == "")
            {
                errorHoTen.SetError(txtTen, "Xin Nhập Tên:");
                return;
            }
            errorNamSinh.SetError(txtNamSinh, "");
            if (txtNamSinh.Text == "")
            {
                errorNamSinh.SetError(txtNamSinh, "Xin Nhập Năm Sinh:");
                return;
            }
            errorEmail.SetError(txtAccount, "");
            if (txtAccount.Text == "")
            {
                errorEmail.SetError(txtAccount, "Xin Nhập Tên Đăng Nhập:");
                return;
            }
            errorSoDienThoai.SetError(txtSoDienThoai, "");
            if (txtSoDienThoai.Text == "")
            {
                errorSoDienThoai.SetError(txtSoDienThoai, "Xin Nhập Số Điện Thoại:");
                return;
            }
            errorTenDangNhap.SetError(txtEmail, "");
            if(txtEmail.Text=="")
            {
                errorTenDangNhap.SetError(txtEmail, "Xin Nhập Email:");
                return;
            }
            errorDiaChi.SetError(txtDiaChi, "");
            if (txtDiaChi.Text == "")
            {
                errorDiaChi.SetError(txtDiaChi, "Xin Nhập Địa Chỉ:");
                return;
            }
            errorMatKhau1.SetError(txtMatKhau1, "");
            if (txtMatKhau1.Text == "")
            {
                errorMatKhau1.SetError(txtMatKhau1, "Xin Nhập Mật Khẩu:");
                return;
            }
            errorMatKhau2.SetError(txtMatKhau2, "");
            if (txtMatKhau2.Text == "")
            {
                errorMatKhau2.SetError(txtMatKhau2, "Xin Nhập Lại Mật Khẩu:");
                return;
            }
            
            errorKey1.SetError(txtKey1, "");
            if (txtKey1.Text == "")
            {
                errorKey1.SetError(txtKey1, "Xin Nhập Key Restore Mật Khẩu:");
                return;
            }
            errorKey2.SetError(txtKey2, "");
            if (txtKey2.Text == "")
            {
                errorKey2.SetError(txtKey2, "Xin Nhập Lại Key:");
                return;
            }
            errorQuyen.SetError(txtQuyen, "");
            if(txtQuyen.Text=="")
            {
                errorQuyen.SetError(txtQuyen, "Chọn Quyền Cho Nhân Viên");
                return;
            }
            errorMatKhauRepeat.SetError(txtMatKhau2, "");
            if(txtMatKhau1.Text!=txtMatKhau2.Text)
            {
                errorMatKhauRepeat.SetError(txtMatKhau2, "Hai Mật Khẩu Bắt Buộc Giống Nhau");
                return;
            }
            errorKeyRepeat.SetError(txtKey2, "");
            if (txtKey1.Text != txtKey2.Text)
            {
                errorKeyRepeat.SetError(txtKey2, "Hai Mật Khẩu Bắt Buộc Giống Nhau");
                return;
            }
            QuanTriVien qtv = new QuanTriVien();
            qtv.HoTen = txtTen.Text;
            qtv.NamSinh = int.Parse(txtNamSinh.Text);
            qtv.TenDangNhap = txtAccount.Text;
            qtv.SoDienThoai = txtSoDienThoai.Text;
            qtv.Email = txtEmail.Text;
            qtv.DiaChi = txtDiaChi.Text;
            qtv.MatKhau = txtMatKhau1.Text;
            qtv.KeyRestore = txtKey1.Text;
            qtv.Quyen = txtQuyen.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            bool qtvnew = qtvbll.ThemQuanTriVien(qtv);
            if(qtvnew)
            {
                MessageBox.Show("Thêm Thành Công", "Thông báo");

            }    
        }
    }
}
