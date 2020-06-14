namespace GUI
{
    partial class FrmNguoiMuonSachQL
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
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
            this.btnCapNhatForm = new System.Windows.Forms.Button();
            this.txtNMSMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNMSEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnNguoiMuonThem = new System.Windows.Forms.Button();
            this.BtnNguoiMuonCapNhat = new System.Windows.Forms.Button();
            this.TxtNMSDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNMSNamSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNMSSoDienThoai = new System.Windows.Forms.TextBox();
            this.TxtNMSTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvNguoiMuonSachDS = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrBChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.btnCapNhatForm);
            this.GrBChiTiet.Controls.Add(this.txtNMSMa);
            this.GrBChiTiet.Controls.Add(this.label3);
            this.GrBChiTiet.Controls.Add(this.TxtNMSEmail);
            this.GrBChiTiet.Controls.Add(this.label6);
            this.GrBChiTiet.Controls.Add(this.BtnNguoiMuonThem);
            this.GrBChiTiet.Controls.Add(this.BtnNguoiMuonCapNhat);
            this.GrBChiTiet.Controls.Add(this.TxtNMSDiaChi);
            this.GrBChiTiet.Controls.Add(this.label7);
            this.GrBChiTiet.Controls.Add(this.TxtNMSNamSinh);
            this.GrBChiTiet.Controls.Add(this.label5);
            this.GrBChiTiet.Controls.Add(this.TxtNMSSoDienThoai);
            this.GrBChiTiet.Controls.Add(this.TxtNMSTen);
            this.GrBChiTiet.Controls.Add(this.label4);
            this.GrBChiTiet.Controls.Add(this.label2);
            this.GrBChiTiet.Location = new System.Drawing.Point(0, 36);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(673, 280);
            this.GrBChiTiet.TabIndex = 17;
            this.GrBChiTiet.TabStop = false;
            // 
            // btnCapNhatForm
            // 
            this.btnCapNhatForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatForm.Location = new System.Drawing.Point(555, 130);
            this.btnCapNhatForm.Name = "btnCapNhatForm";
            this.btnCapNhatForm.Size = new System.Drawing.Size(104, 43);
            this.btnCapNhatForm.TabIndex = 31;
            this.btnCapNhatForm.Text = "Cập Nhật";
            this.btnCapNhatForm.UseVisualStyleBackColor = true;
            this.btnCapNhatForm.Click += new System.EventHandler(this.btnCapNhatForm_Click);
            // 
            // txtNMSMa
            // 
            this.txtNMSMa.Enabled = false;
            this.txtNMSMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMSMa.Location = new System.Drawing.Point(555, 14);
            this.txtNMSMa.Name = "txtNMSMa";
            this.txtNMSMa.Size = new System.Drawing.Size(102, 23);
            this.txtNMSMa.TabIndex = 30;
            this.txtNMSMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã";
            // 
            // TxtNMSEmail
            // 
            this.TxtNMSEmail.Enabled = false;
            this.TxtNMSEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNMSEmail.Location = new System.Drawing.Point(87, 101);
            this.TxtNMSEmail.Name = "TxtNMSEmail";
            this.TxtNMSEmail.Size = new System.Drawing.Size(570, 23);
            this.TxtNMSEmail.TabIndex = 28;
            this.TxtNMSEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email";
            // 
            // BtnNguoiMuonThem
            // 
            this.BtnNguoiMuonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNguoiMuonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNguoiMuonThem.Location = new System.Drawing.Point(263, 130);
            this.BtnNguoiMuonThem.Name = "BtnNguoiMuonThem";
            this.BtnNguoiMuonThem.Size = new System.Drawing.Size(288, 43);
            this.BtnNguoiMuonThem.TabIndex = 25;
            this.BtnNguoiMuonThem.Text = "Thêm Mới Đọc Giả";
            this.BtnNguoiMuonThem.UseVisualStyleBackColor = true;
            this.BtnNguoiMuonThem.Click += new System.EventHandler(this.BtnNguoiMuonThem_Click);
            // 
            // BtnNguoiMuonCapNhat
            // 
            this.BtnNguoiMuonCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNguoiMuonCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNguoiMuonCapNhat.Location = new System.Drawing.Point(12, 129);
            this.BtnNguoiMuonCapNhat.Name = "BtnNguoiMuonCapNhat";
            this.BtnNguoiMuonCapNhat.Size = new System.Drawing.Size(247, 43);
            this.BtnNguoiMuonCapNhat.TabIndex = 24;
            this.BtnNguoiMuonCapNhat.Text = "Thay Đổi Thông Tin Đọc Giả";
            this.BtnNguoiMuonCapNhat.UseVisualStyleBackColor = true;
            this.BtnNguoiMuonCapNhat.Click += new System.EventHandler(this.BtnNguoiMuonCapNhat_Click);
            // 
            // TxtNMSDiaChi
            // 
            this.TxtNMSDiaChi.Enabled = false;
            this.TxtNMSDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNMSDiaChi.Location = new System.Drawing.Point(87, 72);
            this.TxtNMSDiaChi.Name = "TxtNMSDiaChi";
            this.TxtNMSDiaChi.Size = new System.Drawing.Size(570, 23);
            this.TxtNMSDiaChi.TabIndex = 18;
            this.TxtNMSDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Địa Chỉ";
            // 
            // TxtNMSNamSinh
            // 
            this.TxtNMSNamSinh.Enabled = false;
            this.TxtNMSNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNMSNamSinh.Location = new System.Drawing.Point(491, 43);
            this.TxtNMSNamSinh.Name = "TxtNMSNamSinh";
            this.TxtNMSNamSinh.Size = new System.Drawing.Size(166, 23);
            this.TxtNMSNamSinh.TabIndex = 16;
            this.TxtNMSNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Năm Sinh";
            // 
            // TxtNMSSoDienThoai
            // 
            this.TxtNMSSoDienThoai.Enabled = false;
            this.TxtNMSSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNMSSoDienThoai.Location = new System.Drawing.Point(123, 43);
            this.TxtNMSSoDienThoai.Name = "TxtNMSSoDienThoai";
            this.TxtNMSSoDienThoai.Size = new System.Drawing.Size(260, 23);
            this.TxtNMSSoDienThoai.TabIndex = 14;
            this.TxtNMSSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNMSTen
            // 
            this.TxtNMSTen.Enabled = false;
            this.TxtNMSTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNMSTen.Location = new System.Drawing.Point(123, 14);
            this.TxtNMSTen.Name = "TxtNMSTen";
            this.TxtNMSTen.Size = new System.Drawing.Size(362, 23);
            this.TxtNMSTen.TabIndex = 13;
            this.TxtNMSTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Đọc Giả";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ Tên";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Điện Thoại";
            this.columnHeader2.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản Lý Đọc Giả";
            // 
            // lvNguoiMuonSachDS
            // 
            this.lvNguoiMuonSachDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvNguoiMuonSachDS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvNguoiMuonSachDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNguoiMuonSachDS.FullRowSelect = true;
            this.lvNguoiMuonSachDS.GridLines = true;
            this.lvNguoiMuonSachDS.HideSelection = false;
            this.lvNguoiMuonSachDS.Location = new System.Drawing.Point(0, 214);
            this.lvNguoiMuonSachDS.Name = "lvNguoiMuonSachDS";
            this.lvNguoiMuonSachDS.Size = new System.Drawing.Size(669, 148);
            this.lvNguoiMuonSachDS.TabIndex = 16;
            this.lvNguoiMuonSachDS.UseCompatibleStateImageBehavior = false;
            this.lvNguoiMuonSachDS.View = System.Windows.Forms.View.Details;
            this.lvNguoiMuonSachDS.SelectedIndexChanged += new System.EventHandler(this.lvNguoiMuonSachDS_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Đọc Giả";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa Chỉ ";
            this.columnHeader3.Width = 450;
            // 
            // FrmNguoiMuonSachQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 362);
            this.Controls.Add(this.lvNguoiMuonSachDS);
            this.Controls.Add(this.GrBChiTiet);
            this.Controls.Add(this.label1);
            this.Name = "FrmNguoiMuonSachQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đọc Giả";
            this.Load += new System.EventHandler(this.FrmNguoiMuonSachQL_Load);
            this.GrBChiTiet.ResumeLayout(false);
            this.GrBChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBChiTiet;
        private System.Windows.Forms.TextBox TxtNMSEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnNguoiMuonThem;
        private System.Windows.Forms.Button BtnNguoiMuonCapNhat;
        private System.Windows.Forms.TextBox TxtNMSDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNMSNamSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNMSSoDienThoai;
        private System.Windows.Forms.TextBox TxtNMSTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvNguoiMuonSachDS;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtNMSMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhatForm;
    }
}