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
            
            errorKey1.SetError(txtKey1, "");
            if (txtKey1.Text == "")
            {
                errorKey1.SetError(txtKey1, "Xin Nhập Key Restore Mật Khẩu:");
                return;
            }
            
            errorQuyen.SetError(txtQuyen, "");
            if(txtQuyen.Text=="")
            {
                errorQuyen.SetError(txtQuyen, "Chọn Quyền Cho Nhân Viên");
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
                this.Close();
            }    
        }
    }
}
