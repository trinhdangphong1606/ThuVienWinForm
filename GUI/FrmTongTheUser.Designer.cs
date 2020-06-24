namespace GUI
{
    partial class FrmTongTheUser
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
            this.tìmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGTINCÁNHÂNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmSáchToolStripMenuItem,
            this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem,
            this.tHÔNGTINCÁNHÂNToolStripMenuItem,
            this.đĂNGXUẤTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tìmSáchToolStripMenuItem
            // 
            this.tìmSáchToolStripMenuItem.Name = "tìmSáchToolStripMenuItem";
            this.tìmSáchToolStripMenuItem.Size = new System.Drawing.Size(153, 23);
            this.tìmSáchToolStripMenuItem.Text = "TÌM VÀ MƯỢN SÁCH";
            this.tìmSáchToolStripMenuItem.Click += new System.EventHandler(this.tìmSáchToolStripMenuItem_Click);
            // 
            // pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem
            // 
            this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem.Name = "pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem";
            this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem.Size = new System.Drawing.Size(161, 23);
            this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem.Text = "SÁCH MƯỢN CỦA TÔI";
            this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem.Click += new System.EventHandler(this.pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem_Click);
            // 
            // tHÔNGTINCÁNHÂNToolStripMenuItem
            // 
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Name = "tHÔNGTINCÁNHÂNToolStripMenuItem";
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Size = new System.Drawing.Size(159, 23);
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Text = "THÔNG TIN CÁ NHÂN";
            this.tHÔNGTINCÁNHÂNToolStripMenuItem.Click += new System.EventHandler(this.tHÔNGTINCÁNHÂNToolStripMenuItem_Click);
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // FrmTongTheUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTongTheUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý Thông Tin Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tìmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHIẾUMƯỢNSÁCHCỦATÔIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGTINCÁNHÂNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
    }
}