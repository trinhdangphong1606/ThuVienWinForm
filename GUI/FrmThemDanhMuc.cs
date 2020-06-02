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
using DAL;
using BLL;

namespace GUI
{
    public partial class FrmThemDanhMuc : Form
    {

        public FrmThemDanhMuc()
        {
            InitializeComponent();
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucBLL bll = new DanhMucBLL();
            string TenDanhMuc = txtDanhMuc.Text;
            string NoiDungDanhMuc = richNoiDung.Text;
            if(bll.InsertDanhMuc(TenDanhMuc, NoiDungDanhMuc))
            {
                MessageBox.Show("Thêm Danh Mục Thành Công");
                //LvDanhMucDS();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dữ liệu");
            }
        }

        private void btnHuyThemMoi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
