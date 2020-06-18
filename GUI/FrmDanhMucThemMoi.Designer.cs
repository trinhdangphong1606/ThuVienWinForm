namespace GUI
{
    partial class FrmDanhMucThem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.richNoiDung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.btnHuyThemMoi = new System.Windows.Forms.Button();
            this.errorTenDM = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoiDung = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTenDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thêm Mới Danh Mục Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nội Dung: ";
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhMuc.Location = new System.Drawing.Point(126, 40);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(489, 23);
            this.txtDanhMuc.TabIndex = 20;
            this.txtDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richNoiDung
            // 
            this.richNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNoiDung.Location = new System.Drawing.Point(126, 69);
            this.richNoiDung.Name = "richNoiDung";
            this.richNoiDung.Size = new System.Drawing.Size(489, 101);
            this.richNoiDung.TabIndex = 19;
            this.richNoiDung.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Danh Mục:";
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDanhMuc.Location = new System.Drawing.Point(126, 176);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(337, 25);
            this.btnThemDanhMuc.TabIndex = 23;
            this.btnThemDanhMuc.Text = "Thêm Danh Mục";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // btnHuyThemMoi
            // 
            this.btnHuyThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThemMoi.Location = new System.Drawing.Point(486, 176);
            this.btnHuyThemMoi.Name = "btnHuyThemMoi";
            this.btnHuyThemMoi.Size = new System.Drawing.Size(129, 25);
            this.btnHuyThemMoi.TabIndex = 24;
            this.btnHuyThemMoi.Text = "Hủy Thêm Mới";
            this.btnHuyThemMoi.UseVisualStyleBackColor = true;
            this.btnHuyThemMoi.Click += new System.EventHandler(this.btnHuyThemMoi_Click);
            // 
            // errorTenDM
            // 
            this.errorTenDM.ContainerControl = this;
            // 
            // errorNoiDung
            // 
            this.errorNoiDung.ContainerControl = this;
            // 
            // FrmDanhMucThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 212);
            this.Controls.Add(this.btnHuyThemMoi);
            this.Controls.Add(this.btnThemDanhMuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDanhMuc);
            this.Controls.Add(this.richNoiDung);
            this.Controls.Add(this.label2);
            this.Name = "FrmDanhMucThem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Mới Danh Mục";
            ((System.ComponentModel.ISupportInitialize)(this.errorTenDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.RichTextBox richNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.Button btnHuyThemMoi;
        private System.Windows.Forms.ErrorProvider errorTenDM;
        private System.Windows.Forms.ErrorProvider errorNoiDung;
    }
}