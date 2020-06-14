namespace GUI
{
    partial class FrmThemDanhMuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.btnHuyThemMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM MỚI DANH MỤC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richNoiDung);
            this.panel1.Controls.Add(this.txtDanhMuc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 228);
            this.panel1.TabIndex = 1;
            // 
            // richNoiDung
            // 
            this.richNoiDung.Location = new System.Drawing.Point(193, 79);
            this.richNoiDung.Name = "richNoiDung";
            this.richNoiDung.Size = new System.Drawing.Size(376, 121);
            this.richNoiDung.TabIndex = 2;
            this.richNoiDung.Text = "";
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Location = new System.Drawing.Point(193, 34);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(376, 30);
            this.txtDanhMuc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên danh mục :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nội dung:";
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDanhMuc.Location = new System.Drawing.Point(230, 323);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(180, 36);
            this.btnThemDanhMuc.TabIndex = 3;
            this.btnThemDanhMuc.Text = "Thêm Danh Mục";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // btnHuyThemMoi
            // 
            this.btnHuyThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemMoi.Location = new System.Drawing.Point(437, 323);
            this.btnHuyThemMoi.Name = "btnHuyThemMoi";
            this.btnHuyThemMoi.Size = new System.Drawing.Size(190, 36);
            this.btnHuyThemMoi.TabIndex = 3;
            this.btnHuyThemMoi.Text = "Hủy Thêm Mới";
            this.btnHuyThemMoi.UseVisualStyleBackColor = true;
            this.btnHuyThemMoi.Click += new System.EventHandler(this.btnHuyThemMoi_Click);
            // 
            // FrmThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 379);
            this.Controls.Add(this.btnHuyThemMoi);
            this.Controls.Add(this.btnThemDanhMuc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmThemDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Mới Danh Mục";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richNoiDung;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.Button btnHuyThemMoi;
    }
}