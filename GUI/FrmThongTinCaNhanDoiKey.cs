using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;

namespace GUI
{
    public partial class FrmThongTinCaNhanDoiKey : Form
    {
        string ma = "";
        string account = "";
        public FrmThongTinCaNhanDoiKey(string ma, string account)
        {
            InitializeComponent();
            this.ma = ma;
            this.account = account;
        }

        private void FrmThongTinCaNhanDoiKey_Load(object sender, EventArgs e)
        {
            txtMa.Text = ma;
            txtAccount.Text = account;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            KiemTraKeyCu();
        }
        private void KiemTraKeyCu()
        {
            QuanTriVien qtv = new QuanTriVien();
            qtv.TenDangNhap = txtAccount.Text;
            qtv.MatKhau = txtKeyCu.Text;

            QuanTriVienBLL qtvbll = new QuanTriVienBLL();
            List<QuanTriVien> dsqtv = qtvbll.DangNhap(qtv);
            foreach (QuanTriVien qtvien in dsqtv)
            {
                lbOK.Text = "Nhập Key Mới và Đổi Nhé";
            }
            if (lbOK.Text == "Nhập Và Kiểm Tra Mật Khẩu")
            {
                MessageBox.Show("Kiểm Tra Lại Key Cũ Nhé");
            }
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            if (lbOK.Text != "Nhập Và Kiểm Tra Key Cũ")
            {
                errorKey1.SetError(txtKeyMoi1, "");
                if (txtKeyMoi1.Text == "")
                {
                    errorKey1.SetError(txtKeyMoi1, "Nhập Key Mới Nhé");
                    return;
                }
                errorKey2.SetError(txtKeyMoi2, "");
                if (txtKeyMoi2.Text != txtKeyMoi1.Text)
                {
                    errorKey2.SetError(txtKeyMoi2, "Kiểm Tra Nhập Lại Key Mới");
                    return;
                }
                QuanTriVien qtv = new QuanTriVien();
                qtv.ID = int.Parse(txtMa.Text);
                qtv.TenDangNhap = txtAccount.Text;
                qtv.KeyRestore = txtKeyMoi1.Text;

                QuanTriVienBLL qtvienbll = new QuanTriVienBLL();
                bool resetkey = qtvienbll.DoiKeyRestore(qtv);
                if (resetkey)
                {
                    MessageBox.Show("Đổi Key Thành Công", "Thông Báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kiểm Tra Lại Nhé", "Thông Báo");
                }    
            }
            else
            {
                MessageBox.Show("Kiểm Tra Key Cũ Trước Nhé", "Thông Báo");
            }    
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbOK_Click(object sender, EventArgs e)
        {

        }
    }
}
