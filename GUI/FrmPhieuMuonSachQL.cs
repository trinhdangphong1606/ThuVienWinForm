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
    public partial class FrmPhieuMuonSachQL : Form
    {
        public FrmPhieuMuonSachQL()
        {
            InitializeComponent();
        }

        private void BtnPMSMo_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonSachMo frm1 = new FrmPhieuMuonSachMo();
            frm1.Show();
        }

        private void BtnPMSDong_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonSachDong frm1 = new FrmPhieuMuonSachDong();
            frm1.Show();
        }
    }
}
