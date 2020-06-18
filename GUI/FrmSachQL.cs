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
using DAL.DAO;
namespace GUI
{
    public partial class FrmSachQL : Form
    {
        public static string PassMaSach = "";
        public static string PassTen = "";
        public static string PassTacGia = "";
        public static string PassTenDanhMuc = "";
        public static string PassNamSanXuat = "";
        public static string PassNgonNgu = "";
        public static string PassNoiDung = "";
        public FrmSachQL()
        {
            InitializeComponent();
        }
        private void FrmSachQL_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSach();
            //CBBHienThiDSTacGia();
            //CBBHienThiDSDanhMuc();
        }

        

        private void BtnCapNhatThongTinSach_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn Danh Mục Cần Thay Đổi Thông Tin", "Thông Báo");
            }
            else
            {
                PassMaSach = txtMa.Text;
                PassTen = TxtTenSach.Text;
                PassTacGia = TxtTenTacGia.Text;
                PassNgonNgu = TxtNgonNgu.Text;
                PassNamSanXuat = TxtNamXuatBan.Text;
                PassNoiDung = richNoiDungSach.Text;
                PassTenDanhMuc = TxtTenDanhMuc.Text;
                FrmSachCapNhat frm5 = new FrmSachCapNhat();
                frm5.Show();
            }

        }

        public void HienThiDanhSachSach()
        {
            SachBLL sacBLL = new SachBLL();
            List<SachDAO> dssach = sacBLL.LayToanBoSach(); //call sachbll để trả về dssach
            LvSachQL.Items.Clear();
            foreach (SachDAO scBLL in dssach)
                //duyệt tuần tự các phần tử trong mảng dssach
            {
                ListViewItem lvi = new ListViewItem(scBLL.TenSach + "");
                lvi.SubItems.Add(scBLL.TacGia);
                lvi.SubItems.Add(scBLL.TheLoai);
                lvi.SubItems.Add(scBLL.NgonNgu);
                lvi.SubItems.Add(scBLL.NamXuatBan + "");
                lvi.SubItems.Add(scBLL.TrangThai + "");
                lvi.SubItems.Add(scBLL.NoiDungSach + "");
                lvi.SubItems.Add(scBLL.ID + "");
                LvSachQL.Items.Add(lvi);
            }
        }

        private void LvSachQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LvSachQL.SelectedItems.Count>0)
            {
                ListViewItem lvi = LvSachQL.SelectedItems[0];
                string tensach = lvi.SubItems[0].Text;
                string tacgia = lvi.SubItems[1].Text;
                string danhmuc = lvi.SubItems[2].Text;
                string ngonngu = lvi.SubItems[3].Text;
                string namxuatban = lvi.SubItems[4].Text;
                string trangthai = lvi.SubItems[5].Text;
                string noidung = lvi.SubItems[6].Text;
                string masach = lvi.SubItems[7].Text;
                TxtTenSach.Text = tensach;
                TxtTenTacGia.Text = tacgia;
                TxtTenDanhMuc.Text = danhmuc;
                TxtNgonNgu.Text = ngonngu;
                TxtNamXuatBan.Text = namxuatban;
                richNoiDungSach.Text = noidung;
                txtMa.Text = masach;
            }    
        }
        /*
        private void CBBHienThiDSDanhMuc()
        {
            DanhMucBLL damuBLL = new DanhMucBLL();
            List<DanhMuc> dsdanhmuc = damuBLL.LayToanBoDanhMuc();
            cbboxSachDanhMuc.Items.Clear();
            cbboxSachDanhMuc.DataSource = dsdanhmuc;
            cbboxSachDanhMuc.DisplayMember = "TenDanhMuc";
        }
        private void CBBHienThiDSTacGia()
        {
            SachBLL sacBLL = new SachBLL();
            List<Sach> dsdsach = sacBLL.LayAllToanBoSach();
            cbboxSachTacGia.Items.Clear();
            cbboxSachTacGia.DataSource = dsdsach;
            cbboxSachTacGia.DisplayMember = "NgonNgu";
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            SachDAO tims = new SachDAO();
            tims.TenSach = txtTimTenSach.Text;

            SachBLL sacBLL = new SachBLL();
            List<SachDAO> dssach = sacBLL.TimTenSach(tims); //call sachbll để trả về dssach
            LvSachQL.Items.Clear();
            foreach (SachDAO scBLL in dssach)
            //duyệt tuần tự các phần tử trong mảng dssach
            {
                ListViewItem lvi = new ListViewItem(scBLL.TenSach + "");
                lvi.SubItems.Add(scBLL.TacGia);
                lvi.SubItems.Add(scBLL.TheLoai);
                lvi.SubItems.Add(scBLL.NgonNgu);
                lvi.SubItems.Add(scBLL.NamXuatBan + "");
                lvi.SubItems.Add(scBLL.NoiDungSach + "");
                lvi.SubItems.Add(scBLL.TrangThai + "");

                LvSachQL.Items.Add(lvi);
            }
        }

        private void txtTimTenSach_Click(object sender, EventArgs e)
        {
            txtTimTenSach.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSach();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSachThem frm1 = new FrmSachThem();
            frm1.Show();
        }
    }
}
