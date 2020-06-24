using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTongTheUser : Form
    {
        string id = "";
        string quyen= "";
        public FrmTongTheUser(string id, string quyen)
        {
            InitializeComponent();
            this.id = id;
            this.quyen = quyen;
        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSachXem frm1 = new FrmSachXem(id);
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonDG frm1 = new FrmPhieuMuonDG(id);
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void tHÔNGTINCÁNHÂNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhan frm1 = new FrmThongTinCaNhan(id, quyen);
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap form = new FrmDangNhap();
            form.Show();
        }
        private void FrmTongTheUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
