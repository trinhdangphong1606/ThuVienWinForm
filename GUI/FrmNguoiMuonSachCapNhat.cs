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
            nms.DiaChi = txtSoDienThoai.Text;
            nms.Email = txtEmail.Text;

            NguoiMuonSachBLL nmsbll = new NguoiMuonSachBLL();
            bool capnhat = nmsbll.CapNhatDocGia(nms);
            if(capnhat)
            {
                MessageBox.Show("Ok", "Thông Báo");
                this.Close();
            }    
        }

        
    }
}
