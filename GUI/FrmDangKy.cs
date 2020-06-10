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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorTen.SetError(txtTen, "");
            if(txtTen.Text =="")
            {
                errorTen.SetError(txtTen, "Xin Nhập Tên");
                return;
            }
            errorNamSinh.SetError(txtNamSinh, "");
            if (txtNamSinh.Text == "")
            {
                errorNamSinh.SetError(txtNamSinh, "Xin Nhập Năm Sinh");
                return;
            }
            errorTenDangNhap.SetError(txtTenDangNhap, "");
            if(txtTenDangNhap.Text=="")
            {
                errorTenDangNhap.SetError(txtTenDangNhap, "Xin Nhập Tên Đăng Nhập");
                return;
            }
            errorSoDienThoai.SetError(txtSoDienThoai, "");
            if(txtSoDienThoai.Text=="")
            {
                errorSoDienThoai.SetError(txtSoDienThoai, "Xin Nhập Số Điện Thoại");
                return;
            }
            errorEmail.SetError(txtEmail, "");
            if(txtEmail.Text=="")
            {
                errorEmail.SetError(txtEmail, "Xin Nhập Email");
                return;
            }
            errorDiaChi.SetError(txtDiaChi, "");
            if(txtDiaChi.Text=="")
            {
                errorDiaChi.SetError(txtDiaChi, "Xin Nhập Địa Chỉ");
                return;
            }
            errorMatKhau1.SetError(txtMatKhau1, "");
            if(txtMatKhau1.Text=="")
            {
                errorMatKhau1.SetError(txtMatKhau1, "Xin Nhập Mật Khẩu");
                return;
            }
            errorMatKhau2.SetError(txtMatKhau2, "");
            if(txtMatKhau2.Text=="")
            {
                errorMatKhau2.SetError(txtMatKhau2, "Xin Nhập Lại Mật Khẩu");
                return;
            }
            errorKey1.SetError(txtKey1, "");
            if(txtKey1.Text=="")
            {
                errorKey1.SetError(txtKey1, "Xin Nhập Key Restore Mật Khẩu");
                return;
            }
            errorKey2.SetError(txtKey2, "");
            if (txtKey2.Text == "")
            {
                errorKey2.SetError(txtKey2, "Xin Nhập Key Restore Mật Khẩu");
                return;
            }
            errorMatKhauRepeat.SetError(txtMatKhau2, "");
            if(txtMatKhau1.Text!=txtMatKhau2.Text)
            {
                errorMatKhauRepeat.SetError(txtMatKhau2, "Mật Khẩu Phải Giống Nhau");
                return;
            }
            errorKeyRepeat.SetError(txtKey2, "");
            if (txtKey1.Text != txtKey2.Text)
            {
                errorKeyRepeat.SetError(txtKey2,"Key Restore Phải Giống Nhau");
                return;
            }
        }
    }
}
