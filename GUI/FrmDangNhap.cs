using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorUsername.SetError(txtUsername,"");
            if(txtUsername.Text=="")
            {
                errorUsername.SetError(txtUsername, "Nhập");
                return;
            }
            errorPassword.SetError(txtPassword, "");
            if (txtPassword.Text == "")
            {
                errorPassword.SetError(txtPassword, "Nhập");
                return;
            }
            QuanTriVien qtv = new QuanTriVien();
            qtv.TenDangNhap = txtUsername.Text;
            qtv.MatKhau = txtPassword.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            List<QuanTriVien> dsqtv = qtvbll.DangNhap(qtv);
            foreach(QuanTriVien qtvlogin in dsqtv)
            {
                lbTenDangNhap.Text = qtvlogin.TenDangNhap;
                lbQuyen.Text = qtvlogin.Quyen;

            }
            if (lbTenDangNhap.Text != "...")
            {
                lbChao.Text = "Xin Chào";
                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo");
                this.Hide();
                FrmTongThe frm1 = new FrmTongThe(lbQuyen.Text);
                frm1.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Kiểm Tra Lại Tài Khoản và Mật Khẩu nhé,...", "Thông báo");
            }
            
        }
        /*private void FormTongThe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm1 = new FrmDangKy();
            frm1.Show();
        }
    }
}
