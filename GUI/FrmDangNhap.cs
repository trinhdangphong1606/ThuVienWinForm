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
            CanhBaoDangNhap();
        }
        private void CanhBaoDangNhap()
        {
            errorUsername.SetError(txtUsername, "");
            if (txtUsername.Text == "")
            {
                errorUsername.SetError(txtUsername, "Nhập Tên Đăng Nhập");
                return;
            }
            errorPassword.SetError(txtPassword, "");
            if (txtPassword.Text == "")
            {
                errorPassword.SetError(txtPassword, "Nhập Mật Khẩu");
                return;
            }
            DangNhap();
        }
        private void DangNhap()
        {
            QuanTriVien qtv = new QuanTriVien();
            qtv.TenDangNhap = txtUsername.Text;
            qtv.MatKhau = txtPassword.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            List<QuanTriVien> dsqtv = qtvbll.DangNhap(qtv);
            foreach (QuanTriVien qtvlogin in dsqtv)
            {
                lbTenDangNhap.Text = qtvlogin.TenDangNhap;
                lbQuyen.Text = qtvlogin.Quyen;
                lbId.Text = "" +qtvlogin.ID;

            }
            if (lbTenDangNhap.Text != "...")
            {
                lbChao.Text = "Xin Chào";
                lbChao2.Text = "Mã     :";
                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo");
                this.Hide();
                if (lbQuyen.Text=="Admin" || lbQuyen.Text == "Staff")
                {
                    FrmTongThe frm1 = new FrmTongThe(lbQuyen.Text, lbId.Text);
                    frm1.ShowDialog();
                    this.Close();
                }    
                else
                {
                    FrmTongTheUser frm1 = new FrmTongTheUser(lbId.Text);
                    frm1.ShowDialog();
                    this.Close();
                }    
                
            }
            else
            {
                MessageBox.Show("Kiểm Tra Lại Tài Khoản và Mật Khẩu nhé,...", "Thông báo");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm1 = new FrmDangKy();
            frm1.Show();
        }

        private void btnRestoreMatKhau_Click(object sender, EventArgs e)
        {
            FrmRestoreMatKhau frm1 = new FrmRestoreMatKhau();
            frm1.Show();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            DangNhap();
        }
    }
}
