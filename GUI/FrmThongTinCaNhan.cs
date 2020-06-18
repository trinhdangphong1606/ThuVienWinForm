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
using DAL;
using BLL;

namespace GUI
{
    public partial class FrmThongTinCaNhan : Form
    {
        string id = "";
        string quyen = "";
        public FrmThongTinCaNhan(string id, string quyen)
        {
            InitializeComponent();
            this.id = id ;
            this.quyen = quyen;
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            txtMa.Text = id;
            txtQuyen.Text = quyen;

            QuanTriVien qtv = new QuanTriVien();
            qtv.ID = int.Parse(txtMa.Text);

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            List<QuanTriVien> qtvien = qtvbll.LayThongTinCaNhan(qtv);
            foreach(QuanTriVien qtvtt in qtvien)
            {
                txtAccount.Text = qtvtt.TenDangNhap;
                txtTen.Text = qtvtt.HoTen;
                txtSoDienThoai.Text = qtvtt.SoDienThoai;
                txtNamSinh.Text = qtvtt.NamSinh+"";
                txtDiaChi.Text = qtvtt.DiaChi;
                txtEmail.Text = qtvtt.Email;
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorTen.SetError(txtTen, "");
            if (txtTen.Text == "")
            {
                errorTen.SetError(txtTen, "Xin Nhập Tên");
                return;
            }
            errorSoDienThoai.SetError(txtSoDienThoai, "");
            if (txtSoDienThoai.Text == "")
            {
                errorSoDienThoai.SetError(txtSoDienThoai, "Xin Nhập Số Điện Thoại");
                return;
            }
            errorNamSinh.SetError(txtNamSinh, "");
            if (txtNamSinh.Text == "")
            {
                errorNamSinh.SetError(txtNamSinh, "Xin Nhập Năm Sinh");
                return;
            }
            errorEmail.SetError(txtEmail, "");
            if (txtEmail.Text == "")
            {
                errorEmail.SetError(txtEmail, "Xin Nhập Email");
                return;
            }
            errorAccount.SetError(txtAccount, "");
            if (txtAccount.Text == "")
            {
                errorAccount.SetError(txtAccount, "Xin Nhập Account ");
                return;
            }
            errorDiaChi.SetError(txtDiaChi, "");
            if (txtDiaChi.Text == "")
            {
                errorDiaChi.SetError(txtDiaChi, "Xin Nhập Địa Chỉ ");
                return;
            }
            errorIntNamSinh.SetError(txtNamSinh, "");
            if (!txtNamSinh.Text.All(char.IsDigit))
            {
                errorIntNamSinh.SetError(txtNamSinh, "Năm Sinh Là Số ");
                return;
            }

            QuanTriVien qtv = new QuanTriVien();
            qtv.ID = int.Parse(txtMa.Text);
            qtv.HoTen = txtTen.Text;
            qtv.TenDangNhap = txtAccount.Text;
            qtv.SoDienThoai = txtSoDienThoai.Text;
            qtv.NamSinh = int.Parse(txtNamSinh.Text);
            qtv.DiaChi = txtDiaChi.Text;
            qtv.Email = txtEmail.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            bool update = qtvbll.DoiThongTinCaNhan(qtv);
            if(update)
            {
                MessageBox.Show("Thay Đổi Thông Tin Thành Công", "Thông Báo");
                
            }    
            else
            {
                MessageBox.Show("Tèo", "Thông Báo");
            }    
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhanDoiMK frm1 = new FrmThongTinCaNhanDoiMK(id,txtAccount.Text);
            frm1.Show();
        }

        private void btnDoiKey_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhanDoiKey frm1 = new FrmThongTinCaNhanDoiKey(id, txtAccount.Text);
            frm1.Show();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
