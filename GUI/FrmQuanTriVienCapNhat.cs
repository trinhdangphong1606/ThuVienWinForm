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
        public string quyen = "";
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
            if(FrmQuanTriVienQL.passQuyen=="Admin")
            {
                txtQuyen.Text = "Thủ Thư";
            }
            else
            {
                txtQuyen.Text = "Đọc Giả";
            }
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
            if(txtQuyen.Text=="Thủ Thư")
            {
                this.quyen = "Admin";
            }    
            else
            {
                this.quyen = "User";
            }    
            qtv.Quyen = this.quyen ;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            bool capnhatqtv = qtvbll.ChinhSuaQuanTriVien(qtv);

            NguoiMuonSach nms = new NguoiMuonSach();
            nms.Id = int.Parse(txtMa.Text);
            nms.HoTen = txtTen.Text;
            nms.NamSinh = int.Parse(txtNamSinh.Text);
            nms.SoDienThoai = txtSoDienThoai.Text;
            nms.DiaChi = txtDiaChi.Text;
            nms.Email = txtEmail.Text;

            NguoiMuonSachBLL nmsbll = new NguoiMuonSachBLL();
            bool capnhatnms = nmsbll.CapNhatDocGia(nms);

            if (capnhatqtv && capnhatnms)
            {
                MessageBox.Show("Đã thay đổi thông tin \n Nhấn nút cập nhật nhé.", "Thông Báo");
                this.Close();
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
            ThayDoiThongTin();
        }

        private void btnQuyenAdmin_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "Thủ Thư";
            this.quyen = "Admin";
        }

        private void btnQuyenStaff_Click(object sender, EventArgs e)
        {
            //txtQuyen.Text = "Staff";
        }

        private void btnQuyenUser_Click(object sender, EventArgs e)
        {
            txtQuyen.Text = "Đọc Giả";
            this.quyen = "User";
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
