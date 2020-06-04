using BLL;
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

namespace GUI
{
    public partial class FrmQuanTriVienQL : Form
    {
        public FrmQuanTriVienQL()
        {
            InitializeComponent();
        }

        private void FrmQuanTriVienQL_Load(object sender, EventArgs e)
        {
            HienThiDanhSachQuanTriVien();
        }

        private void HienThiDanhSachQuanTriVien()
        {
            QuanTriVienBLL quantrivienBLL = new QuanTriVienBLL();
            List<QuanTriVien> dsquanntrivien = quantrivienBLL.LayToanBoQuanTriVien();
            lvQuanTriVienDS.Items.Clear();
            foreach (QuanTriVien qtvien in dsquanntrivien)
            {
                ListViewItem lvi = new ListViewItem(qtvien.ID + "");
                lvi.SubItems.Add(qtvien.TenDangNhap);
                lvi.SubItems.Add(qtvien.Email);
                lvi.SubItems.Add(qtvien.NamSinh + "");
                lvi.SubItems.Add(qtvien.MatKhau);
                lvi.SubItems.Add(qtvien.HoTen);
                lvi.SubItems.Add(qtvien.KeyRestore);
                lvi.SubItems.Add(qtvien.SoDienThoai);
                lvi.SubItems.Add(qtvien.DiaChi);

                lvQuanTriVienDS.Items.Add(lvi);
            }
        }

        private void btnQuanTriVienCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDanhSachQuanTriVien();
        }
    }
}
