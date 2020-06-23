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
    public partial class FrmNguoiMuonSachCapNhat : Form
    {
        public FrmNguoiMuonSachCapNhat()
        {
            InitializeComponent();
        }
        private void FrmNguoiMuonSachCapNhat_Load(object sender, EventArgs e)
        {
            txtMa.Text = FrmNguoiMuonSachQL.PassMa;
            txtTen.Text = FrmNguoiMuonSachQL.PassTen;
            txtNamSinh.Text = FrmNguoiMuonSachQL.PassNamSinh;
            txtSoDienThoai.Text = FrmNguoiMuonSachQL.PassSoDienThoai;
            txtDiaChi.Text = FrmNguoiMuonSachQL.PassDiaChi;
            txtEmail.Text = FrmNguoiMuonSachQL.PassEmail;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NguoiMuonSach nms = new NguoiMuonSach();
            nms.Id = int.Parse(txtMa.Text);
            nms.HoTen = txtTen.Text;
            nms.NamSinh = int.Parse(txtNamSinh.Text);
            nms.SoDienThoai = txtSoDienThoai.Text;
            nms.DiaChi = txtDiaChi.Text;
            nms.Email = txtEmail.Text;
            NguoiMuonSachBLL nmsbll = new NguoiMuonSachBLL();
            bool capnhatnms = nmsbll.CapNhatDocGia(nms);

            QuanTriVien qtv = new QuanTriVien();
            qtv.DiaChi = txtDiaChi.Text;
            qtv.Email = txtEmail.Text;
            qtv.ID = int.Parse(txtMa.Text);
            qtv.NamSinh = int.Parse(txtNamSinh.Text);
            qtv.SoDienThoai = txtSoDienThoai.Text;
            qtv.HoTen = txtTen.Text;
            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            bool capnhatqtv = qtvbll.ChinhSuaQuanTriVien(qtv);

            
            if(capnhatnms&& capnhatqtv)
            {
                MessageBox.Show("Đã Thay Đổi Thành Công, Nhấn Cập Nhật Nhé ...", "Thông Báo");
                this.Close();
            }    
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
