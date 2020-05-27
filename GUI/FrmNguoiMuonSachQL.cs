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
using DAL;

namespace GUI
{
    public partial class FrmNguoiMuonSachQL : Form
    {
        public FrmNguoiMuonSachQL()
        {
            InitializeComponent();
        }

        private void BtnNguoiMuonCapNhat_Click(object sender, EventArgs e)
        {
            HienThiNguoiMuonSachDS();
        }

        private void HienThiNguoiMuonSachDS()
        {
            NguoiMuonSachBLL ngmsachbll = new NguoiMuonSachBLL();
            List<NguoiMuonSach> dsngmsach = ngmsachbll.LayToanBoNguoiMuonSach();
            lvNguoiMuonSachDS.Items.Clear();
            foreach(NguoiMuonSach nms in dsngmsach)
            {
                ListViewItem lvi = new ListViewItem(nms.Id + "");
                lvi.SubItems.Add(nms.HoTen);
                lvi.SubItems.Add(nms.SoDienThoai);
                lvi.SubItems.Add(nms.DiaChi);
                lvi.SubItems.Add(nms.BieuHien);
                lvNguoiMuonSachDS.Items.Add(lvi);
            }    
        }
    }
}
