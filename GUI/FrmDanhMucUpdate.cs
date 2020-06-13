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
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmDanhMucUpdate : Form
    {
        public FrmDanhMucUpdate()
        {
            InitializeComponent();
        }

        private void FrmDanhMucUpdate_Load(object sender, EventArgs e)
        {
            txtMa.Text = FrmDanhMucQL.PassMa;
            txtTenDM.Text = FrmDanhMucQL.PassTenDanhMuc;
            richNoiDungDM.Text = FrmDanhMucQL.PassNoiDungDM;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            ErrorID.SetError(txtMa, "");
            if(txtMa.Text == "")
            {
                ErrorID.SetError(txtMa, "Xin nhập ID cần thay đổi");
                return;
            }
            errorTenDanhMuc.SetError(txtTenDM, "");
            if (txtTenDM.Text == "")
            {
                errorTenDanhMuc.SetError(txtTenDM, "Xin nhập tên Danh Mục cần thay đổi");
                return;
            }

            errorNoiDung.SetError(richNoiDungDM, "");
            if (richNoiDungDM.Text == "")
            {
                errorTenDanhMuc.SetError(richNoiDungDM, "Xin nhập nội dung cần thay đổi");
                return;
            }

            DanhMuc dm = new DanhMuc();
            dm.IdDanhMuc = int.Parse(txtMa.Text);
            dm.TenDanhMuc = txtTenDM.Text;
            dm.NoiDungDanhMuc = richNoiDungDM.Text;

            DanhMucBLL dmbll = new DanhMucBLL();
            bool capnhat = dmbll.CapNhatDanhMuc(dm);
            if(capnhat)
            {
                MessageBox.Show("Đã Thay Đổi Thành Công, Nhấn Cập Nhật Nhé ...", "Thông Báo");
                this.Close();
            }
        }
    }
}
