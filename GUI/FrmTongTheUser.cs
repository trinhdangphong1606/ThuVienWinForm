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
        public FrmTongTheUser(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSachXem frm1 = new FrmSachXem(id);
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
