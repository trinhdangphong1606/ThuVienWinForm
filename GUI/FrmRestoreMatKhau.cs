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
    public partial class FrmRestoreMatKhau : Form
    {
        public FrmRestoreMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorTenDangNhap.SetError(txtTenDangNhap, "");
            if(txtTenDangNhap.Text=="")
            {
                errorTenDangNhap.SetError(txtTenDangNhap, "Nhập Tên Đăng Nhập");
                return;
            }
            errorSoDienThoai.SetError(txtSoDienThoai, "");
            if(txtSoDienThoai.Text=="")
            {
                errorSoDienThoai.SetError(txtSoDienThoai, "Nhập Số Điện Thoại");
                return;
            }
            errorEmail.SetError(txtEmail, "");
            if(txtEmail.Text=="")
            {
                errorEmail.SetError(txtEmail, "Nhập Email");
                return;
            }
            errorKey.SetError(txtKey, "");
            if(txtKey.Text=="")
            {
                errorKey.SetError(txtKey, "Nhập Key Restore Mật Khẩu");
                return;
            }
            errorMatKhau1.SetError(txtMatKhau1, "");
            if(txtMatKhau1.Text=="")
            {
                errorMatKhau1.SetError(txtMatKhau1, "Nhập Mật Khẩu Mới");
                return;
            }
            errorMatKhau2.SetError(txtMatKhau2, "");
            if (txtMatKhau2.Text == "")
            {
                errorMatKhau2.SetError(txtMatKhau2, "Nhập Lại Mật Khẩu Mới");
                return;
            }
            errorMatKhauRepeat.SetError(txtMatKhau2, "");
            if(txtMatKhau1.Text!=txtMatKhau2.Text)
            {
                errorMatKhauRepeat.SetError(txtMatKhau2, "Hai Mật Khẩu Bắt Buộc Giống Nhau");
                return;
            }
            RestoreMatKhau();
        }

        private void RestoreMatKhau()
        {
            QuanTriVien qtvien = new QuanTriVien();
            qtvien.TenDangNhap = txtTenDangNhap.Text;
            qtvien.SoDienThoai = txtSoDienThoai.Text;
            qtvien.Email = txtEmail.Text;
            qtvien.KeyRestore = txtKey.Text;
            qtvien.MatKhau = txtMatKhau1.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            bool qtvres = qtvbll.RestoreMatKhau(qtvien);
            if(qtvres)
            {
                MessageBox.Show("Đổi Mật Khẩu Thành Công ", "Thông Báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi Mật Khẩu Không Thành Công \n Bạn Kiểm Tra Lại Thông Tin Nhé", "Thông Báo");
            }    
        }
    }
}
