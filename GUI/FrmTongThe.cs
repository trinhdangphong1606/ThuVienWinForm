﻿using System;
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

        public FrmTongThe(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSachQL frm1 = new FrmSachQL();
            frm1.MdiParent = this;
            frm1.Show();    
        }

        private void phiếuMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonSachQL frm1 = new FrmPhieuMuonSachQL();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucQL frm1 = new FrmDanhMucQL();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void ngườiMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguoiMuonSachQL frm1 = new FrmNguoiMuonSachQL();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
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

        }
    }
}
