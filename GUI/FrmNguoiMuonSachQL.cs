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
using BLL;
using DAL.DAO;

namespace GUI
{
    public partial class FrmNguoiMuonSachQL : Form
    {
        public static string PassMa="";
        public static string PassTen = "";
        public static string PassSoDienThoai = "";
        public static string PassNamSinh = "";
        public static string PassDiaChi = "";
        public static string PassEmail = "";
        public FrmNguoiMuonSachQL()
        {
            InitializeComponent();
        }
        private void FrmNguoiMuonSachQL_Load(object sender, EventArgs e)
        {
            HienThiNguoiMuonSachDS();
        }
        private void btnCapNhatForm_Click(object sender, EventArgs e)
        {
            HienThiNguoiMuonSachDS();
        }
        private void BtnNguoiMuonCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNMSMa.Text == "")
            {
                MessageBox.Show("Chọn Đọc Giả Cần Thay Đổi Thông Tin", "Thông Báp");
            }
            else
            {
                PassMa = txtNMSMa.Text;
                PassTen = TxtNMSTen.Text;
                PassSoDienThoai = TxtNMSSoDienThoai.Text;
                PassNamSinh = TxtNMSNamSinh.Text;
                PassEmail = TxtNMSEmail.Text;
                PassDiaChi = TxtNMSDiaChi.Text;
                FrmNguoiMuonSachCapNhat Frm2 = new FrmNguoiMuonSachCapNhat();
                Frm2.Show();
            }
        }
        private void BtnNguoiMuonThem_Click(object sender, EventArgs e)
        {
            FrmNguoiMuonSachThemMoi Frm1 = new FrmNguoiMuonSachThemMoi();
            Frm1.Show();
        }
         
        private void HienThiNguoiMuonSachDS()
        {
           
            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.LayToanBoNguoiMuonSach();
            lvNguoiMuonSachDS.Items.Clear();
            foreach (NguoiMuonSach nms in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nms.Id+"");
                lvi.SubItems.Add(nms.HoTen);
                lvi.SubItems.Add(nms.SoDienThoai);
                //lvi.SubItems.Add(nms.BieuHien);
                lvi.SubItems.Add(nms.DiaChi);
                lvi.SubItems.Add(nms.Email);
                lvi.SubItems.Add(nms.NamSinh+"");
                lvNguoiMuonSachDS.Items.Add(lvi);
            }
        }

        private void lvNguoiMuonSachDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNguoiMuonSachDS.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvNguoiMuonSachDS.SelectedItems[0];
                string ma = lvi.SubItems[0].Text;
                string hoten = lvi.SubItems[1].Text;
                string sodienthoai = lvi.SubItems[2].Text;
                string diachi = lvi.SubItems[3].Text;
                string email = lvi.SubItems[4].Text;
                string namsinh = lvi.SubItems[5].Text;
                txtNMSMa.Text = ma;
                TxtNMSTen.Text = hoten;
                TxtNMSSoDienThoai.Text = sodienthoai;
                TxtNMSDiaChi.Text = diachi;
                TxtNMSEmail.Text = email;
                TxtNMSNamSinh.Text = namsinh;

                PhieuMuonSachDAO pms = new PhieuMuonSachDAO();
                pms.TenNguoiMuonSach = TxtNMSTen.Text;

                PhieuMuonSachBLL phieumsBLL = new PhieuMuonSachBLL();
                List<PhieuMuonSachDAO> dsphieumuon = phieumsBLL.TimPhieuChuaDongTheoTen(pms);
                lvDSPhieuMuonMo.Items.Clear();
                foreach (PhieuMuonSachDAO pmsBLL in dsphieumuon)
                {
                    ListViewItem lvii = new ListViewItem(pmsBLL.MaPhieuMuon + "");
                    lvii.SubItems.Add(pmsBLL.NgayMuon.ToString());
                    lvii.SubItems.Add(pmsBLL.NgayDuKienTra.ToString());
                    lvDSPhieuMuonMo.Items.Add(lvii);
                }
            }
        }

        private void txtNMSMa_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void lvDSPhieuMuonMo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSPhieuMuonMo.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDSPhieuMuonMo.SelectedItems[0];
                string maphieumuon = lvi.SubItems[0].Text;
                string ngaymuon = lvi.SubItems[1].Text;
                string ngaydukientra = lvi.SubItems[2].Text;
                dtNgayMuon.Value = Convert.ToDateTime(ngaymuon);
                dtDuKienTra.Value = Convert.ToDateTime(ngaydukientra);


            }
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            errorTimTen.SetError(txtTimMa, "");
            if (txtTimTen.Text == "")
            {
                errorTimTen.SetError(txtTimTen, "Vui lòng nhập tên càn tìm");
                return;
            }
            NguoiMuonSach nms = new NguoiMuonSach();
            nms.HoTen = txtTimTen.Text;

            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.TimTenNguoiMuon(nms);
            lvNguoiMuonSachDS.Items.Clear();
            foreach (NguoiMuonSach nmsbll in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nmsbll.Id + "");
                lvi.SubItems.Add(nmsbll.HoTen);
                lvi.SubItems.Add(nmsbll.SoDienThoai);
                //lvi.SubItems.Add(nms.BieuHien);
                lvi.SubItems.Add(nmsbll.DiaChi);
                lvi.SubItems.Add(nmsbll.Email);
                lvi.SubItems.Add(nmsbll.NamSinh + "");
                lvNguoiMuonSachDS.Items.Add(lvi);
            }
        }

        private void btnTimMa_Click(object sender, EventArgs e)
        {
            errorTimMa.SetError(txtTimMa, "");
            if(txtTimMa.Text == "")
            {
                errorTimMa.SetError(txtTimMa, "Vui lòng nhập mã càn tìm");
                return;
            }
            NguoiMuonSach nms = new NguoiMuonSach();
            nms.Id = int.Parse(txtTimMa.Text);

            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.TimNguoiMuonTheoMa(nms);
            lvNguoiMuonSachDS.Items.Clear();
            foreach (NguoiMuonSach nmsbll in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nmsbll.Id + "");
                lvi.SubItems.Add(nmsbll.HoTen);
                lvi.SubItems.Add(nmsbll.SoDienThoai);
                //lvi.SubItems.Add(nms.BieuHien);
                lvi.SubItems.Add(nmsbll.DiaChi);
                lvi.SubItems.Add(nmsbll.Email);
                lvi.SubItems.Add(nmsbll.NamSinh + "");
                lvNguoiMuonSachDS.Items.Add(lvi);
            }
        }
    }
}
