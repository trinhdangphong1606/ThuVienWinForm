using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

namespace GUI
{
    public partial class FrmThongTinCaNhanDoiMK : Form
    {
        string ma = "";
        string account = "";
        public FrmThongTinCaNhanDoiMK(string ma, string account)
        {
            InitializeComponent();
            this.ma = ma;
            this.account = account;
        }

        private void FrmThongTinCaNhanDoiMK_Load(object sender, EventArgs e)
        {
            txtMa.Text = ma;
            txtAccount.Text = account;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            KiemTraMatKhauCu();
        }
        private void KiemTraMatKhauCu()
        {
            QuanTriVien qtv = new QuanTriVien();
            qtv.TenDangNhap = txtAccount.Text;
            qtv.MatKhau = txtMatKhauCu.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            List<QuanTriVien> dsqtv = qtvbll.DangNhap(qtv);
            foreach (QuanTriVien qtvien in dsqtv)
            {
                lbOK.Text = "Nhập Mật Khẩu Mới và Đổi Nhé";
            }
            if (lbOK.Text == "Nhập Và Kiểm Tra Mật Khẩu Cũ")
            {
                MessageBox.Show("Kiểm Tra Lại Mật Khẩu Cũ Nhé");
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            DoiKey();


        }
        private void DoiKey()
        {
            if (lbOK.Text == "Nhập Mật Khẩu Mới và Đổi Nhé")
            {
                errorMatKhau1.SetError(txtMatKhauMoi1, "");
                if (txtMatKhauMoi1.Text == "")
                {
                    errorMatKhau1.SetError(txtMatKhauMoi1, "Nhập Mật Khẩu Mới Nhé");
                    return;
                }
                errorMatKhau2.SetError(txtMatKhauMoi2, "");
                if (txtMatKhauMoi2.Text != txtMatKhauMoi1.Text)
                {
                    errorMatKhau2.SetError(txtMatKhauMoi2, "Kiểm Tra Nhập Lại Mật Khẩu");
                    return;
                }
                QuanTriVien qtvbll = new QuanTriVien();
                qtvbll.ID = int.Parse(txtMa.Text);
                qtvbll.TenDangNhap = txtAccount.Text;
                qtvbll.MatKhau = txtMatKhauMoi1.Text;

                QuanTriVienBLL qtvienbll = new QuanTriVienBLL();
                bool resetpass = qtvienbll.ResetMatKhau(qtvbll);
                if (resetpass)
                {
                    MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thông Báo");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kiểm Tra Mật Khẩu Cũ Trước Nhé", "Thông Báo");
            }
        }
        
    }
}
