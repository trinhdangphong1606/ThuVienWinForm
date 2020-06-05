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
    public partial class FrmNguoiMuonSachThemMoi : Form
    {
        public FrmNguoiMuonSachThemMoi()
        {
            InitializeComponent();
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoiDG_Click(object sender, EventArgs e)
        {
            errorTen.SetError(txtTen,"");
            if(txtTen.Text=="")
            {
                errorTen.SetError(txtTen, "Xin Nhập Tên Đọc Giả");
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
            errorDiaChi.SetError(txtDiaChi, "");
            if(txtDiaChi.Text=="")
            {
                errorDiaChi.SetError(txtDiaChi, "Xin Nhập Địa Chỉ");
                return;
            }
            errorEmail.SetError(txtEmail, "");
            if(txtEmail.Text=="")
            {
                errorEmail.SetError(txtEmail, "Xin Nhập Email");
                return;
            }ThemMoiDG();
            

        }

        private void ThemMoiDG()
        {
            NguoiMuonSach nms = new NguoiMuonSach();
            nms.HoTen = txtTen.Text;
            nms.NamSinh = int.Parse(txtNamSinh.Text);
            nms.SoDienThoai = txtSoDienThoai.Text;
            nms.DiaChi = txtDiaChi.Text;
            nms.Email = txtEmail.Text;

            NguoiMuonSachBLL nmsbll = new NguoiMuonSachBLL();
            bool nmsnew = nmsbll.ThemDocGia(nms);
            if (nmsnew)
            {
                MessageBox.Show("Nhấn Nút Cập Nhật Nhé.", "Thông Báo");
                this.Close();

            }
        }
    }
}
