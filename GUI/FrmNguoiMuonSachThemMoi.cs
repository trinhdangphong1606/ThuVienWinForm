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
    public partial class FrmNguoiMuonSachThemMoi : Form
    {
        public FrmNguoiMuonSachThemMoi()
        {
            InitializeComponent();
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
