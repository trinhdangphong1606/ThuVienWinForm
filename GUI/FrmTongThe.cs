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
    public partial class FrmTongThe : Form
    {
        string quyen = "";
        string id = "";

        public FrmTongThe(string quyen,string id)
        {
            InitializeComponent();
            this.quyen = quyen;
            this.id = id;
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(quyen!="User")
            {
                FrmSachQL frm1 = new FrmSachQL();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông Báo");
            }    
               
        }

        private void phiếuMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "User")
            {
                FrmPhieuMuonSachQL frm1 = new FrmPhieuMuonSachQL();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông Báo");
            }
            
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "User")
            {
                FrmDanhMucQL frm1 = new FrmDanhMucQL();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông Báo");
            }
            
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void ngườiMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "User")
            {
                FrmNguoiMuonSachQL frm1 = new FrmNguoiMuonSachQL();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông Báo");
            }
            
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" )
            {
                FrmQuanTriVienQL frm1 = new FrmQuanTriVienQL();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông Báo");
            }
            
        }

        private void xemSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSachXem frm1 = new FrmSachXem();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void cÁNHÂNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhan frm1 = new FrmThongTinCaNhan(id,quyen);
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Run(new FrmDangNhap());
        }
    }
}
