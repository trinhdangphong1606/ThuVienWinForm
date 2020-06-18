using DAL;
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

namespace GUI
{
    public partial class FrmDanhMucThem : Form
    {

        public FrmDanhMucThem()
        {
            InitializeComponent();
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {

            errorTenDM.SetError(txtDanhMuc, "");
            {
                if (txtDanhMuc.Text == "")
                {
                    errorTenDM.SetError(txtDanhMuc, "Xin Nhập Tên Nội Dung");
                    return;
                }
            }

            errorNoiDung.SetError(richNoiDung, "");
            if (richNoiDung.Text == "")
            {
                errorNoiDung.SetError(richNoiDung, "Xin Nhập Nội Dung");
                return;
            }

            DanhMucBLL bll = new DanhMucBLL();
            string TenDanhMuc = txtDanhMuc.Text;
            string NoiDungDanhMuc = richNoiDung.Text;
            if (bll.InsertDanhMuc(TenDanhMuc, NoiDungDanhMuc))
            {
                MessageBox.Show("Thêm Danh Mục Thành Công \n Nhấn Nút Cập Nhật Nhé");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dữ liệu");
            }
        }

        private void btnHuyThemMoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
