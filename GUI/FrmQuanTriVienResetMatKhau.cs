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
using DAL;
using BLL;

namespace GUI
{
    public partial class FrmQuanTriVienResetMatKhau : Form
    {
        public string id = "";
        public string tendangnhap = "";
        public FrmQuanTriVienResetMatKhau(string id, string tendangnhap)
        {
            InitializeComponent();
            this.id = id;
            this.tendangnhap = tendangnhap;
        }

        private void FrmQuanTriVienResetMatKhau_Load(object sender, EventArgs e)
        {
            txtMa.Text = id;
            txtTenDangNhap.Text = tendangnhap;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QuanTriVien qtvbll = new QuanTriVien();
            qtvbll.ID = int.Parse(txtMa.Text);
            qtvbll.TenDangNhap = txtTenDangNhap.Text;
            qtvbll.MatKhau = txtMatKhauMoi.Text;

            QuanTriVienBLL qtvienbll = new QuanTriVienBLL();
            bool resetpass = qtvienbll.ResetMatKhau(qtvbll);
            if(resetpass)
            {
                MessageBox.Show("Reset Mật Khẩu Thành Công", "Thông Báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm Tra Lại Thông Tin Nhé", "Thông Báo");
            }    
        }
    }
}
