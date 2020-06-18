namespace GUI
{
    partial class FrmTongThe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnTrịViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cÁNHÂNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemSáchToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.phiếuMượnSáchToolStripMenuItem,
            this.danhMụcSáchToolStripMenuItem,
            this.ngườiMượnSáchToolStripMenuItem,
            this.quảnTrịViênToolStripMenuItem,
            this.cÁNHÂNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemSáchToolStripMenuItem
            // 
            this.xemSáchToolStripMenuItem.Name = "xemSáchToolStripMenuItem";
            this.xemSáchToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.xemSáchToolStripMenuItem.Text = "Tìm Sách";
            this.xemSáchToolStripMenuItem.Click += new System.EventHandler(this.xemSáchToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // phiếuMượnSáchToolStripMenuItem
            // 
            this.phiếuMượnSáchToolStripMenuItem.Name = "phiếuMượnSáchToolStripMenuItem";
            this.phiếuMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.phiếuMượnSáchToolStripMenuItem.Text = "Phiếu Mượn Sách";
            this.phiếuMượnSáchToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnSáchToolStripMenuItem_Click);
            // 
            // danhMụcSáchToolStripMenuItem
            // 
            this.danhMụcSáchToolStripMenuItem.Name = "danhMụcSáchToolStripMenuItem";
            this.danhMụcSáchToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.danhMụcSáchToolStripMenuItem.Text = "Danh Mục Sách";
            this.danhMụcSáchToolStripMenuItem.Click += new System.EventHandler(this.danhMụcSáchToolStripMenuItem_Click);
            // 
            // ngườiMượnSáchToolStripMenuItem
            // 
            this.ngườiMượnSáchToolStripMenuItem.Name = "ngườiMượnSáchToolStripMenuItem";
            this.ngườiMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ngườiMượnSáchToolStripMenuItem.Text = "Đọc Giả";
            this.ngườiMượnSáchToolStripMenuItem.Click += new System.EventHandler(this.ngườiMượnSáchToolStripMenuItem_Click);
            // 
            // quảnTrịViênToolStripMenuItem
            // 
            this.quảnTrịViênToolStripMenuItem.Name = "quảnTrịViênToolStripMenuItem";
            this.quảnTrịViênToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.quảnTrịViênToolStripMenuItem.Text = "Quản Trị Viên";
            this.quảnTrịViênToolStripMenuItem.Click += new System.EventHandler(this.quảnTrịViênToolStripMenuItem_Click);
            // 
            // cÁNHÂNToolStripMenuItem
            // 
            this.cÁNHÂNToolStripMenuItem.Name = "cÁNHÂNToolStripMenuItem";
            this.cÁNHÂNToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.cÁNHÂNToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.cÁNHÂNToolStripMenuItem.Click += new System.EventHandler(this.cÁNHÂNToolStripMenuItem_Click);
            // 
            // FrmTongThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTongThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý Thông Tin Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Leave += new System.EventHandler(this.FrmTongThe_Leave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cÁNHÂNToolStripMenuItem;
    }
}