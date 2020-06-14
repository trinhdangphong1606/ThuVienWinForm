namespace GUI
{
    partial class FrmPhieuMuonSachDong
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
            this.dtpReadyNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpReadyNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhanThongTinDong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadyMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuyThaoTac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmMaPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpConfirmNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpConfirmNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtReadyTenSach = new System.Windows.Forms.TextBox();
            this.txtReadyTenDocGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmTenSach = new System.Windows.Forms.TextBox();
            this.txtConfirmTenDocGia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDongPhieuMuon = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpReadyNgayTra
            // 
            this.dtpReadyNgayTra.CustomFormat = "dd-MM-yyyy";
            this.dtpReadyNgayTra.Enabled = false;
            this.dtpReadyNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadyNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReadyNgayTra.Location = new System.Drawing.Point(188, 176);
            this.dtpReadyNgayTra.Name = "dtpReadyNgayTra";
            this.dtpReadyNgayTra.Size = new System.Drawing.Size(103, 23);
            this.dtpReadyNgayTra.TabIndex = 108;
            // 
            // dtpReadyNgayMuon
            // 
            this.dtpReadyNgayMuon.CustomFormat = "dd-MM-yyyy";
            this.dtpReadyNgayMuon.Enabled = false;
            this.dtpReadyNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadyNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReadyNgayMuon.Location = new System.Drawing.Point(188, 147);
            this.dtpReadyNgayMuon.Name = "dtpReadyNgayMuon";
            this.dtpReadyNgayMuon.Size = new System.Drawing.Size(103, 23);
            this.dtpReadyNgayMuon.TabIndex = 107;
            // 
            // btnXacNhanThongTinDong
            // 
            this.btnXacNhanThongTinDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThongTinDong.Location = new System.Drawing.Point(12, 205);
            this.btnXacNhanThongTinDong.Name = "btnXacNhanThongTinDong";
            this.btnXacNhanThongTinDong.Size = new System.Drawing.Size(355, 25);
            this.btnXacNhanThongTinDong.TabIndex = 100;
            this.btnXacNhanThongTinDong.Text = "Xác Nhận Thông Tin Phiếu";
            this.btnXacNhanThongTinDong.UseVisualStyleBackColor = true;
            this.btnXacNhanThongTinDong.Click += new System.EventHandler(this.btnXacNhanThongTinDong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "Mã Phiếu";
            // 
            // txtReadyMaPhieu
            // 
            this.txtReadyMaPhieu.Enabled = false;
            this.txtReadyMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyMaPhieu.Location = new System.Drawing.Point(131, 52);
            this.txtReadyMaPhieu.Name = "txtReadyMaPhieu";
            this.txtReadyMaPhieu.Size = new System.Drawing.Size(236, 23);
            this.txtReadyMaPhieu.TabIndex = 106;
            this.txtReadyMaPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Ngày Trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 102;
            this.label7.Text = "Ngày Mượn";
            // 
            // btnHuyThaoTac
            // 
            this.btnHuyThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThaoTac.Location = new System.Drawing.Point(12, 236);
            this.btnHuyThaoTac.Name = "btnHuyThaoTac";
            this.btnHuyThaoTac.Size = new System.Drawing.Size(357, 25);
            this.btnHuyThaoTac.TabIndex = 92;
            this.btnHuyThaoTac.Text = "Hủy Thao Tác";
            this.btnHuyThaoTac.UseVisualStyleBackColor = true;
            this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Đóng Phiếu Mượn Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 129;
            this.label9.Text = "Mã Phiếu";
            // 
            // txtConfirmMaPhieu
            // 
            this.txtConfirmMaPhieu.Enabled = false;
            this.txtConfirmMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmMaPhieu.Location = new System.Drawing.Point(507, 52);
            this.txtConfirmMaPhieu.Name = "txtConfirmMaPhieu";
            this.txtConfirmMaPhieu.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmMaPhieu.TabIndex = 130;
            this.txtConfirmMaPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 128;
            this.label10.Text = "Ngày Trả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(385, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 126;
            this.label12.Text = "Ngày Mượn";
            // 
            // dtpConfirmNgayTra
            // 
            this.dtpConfirmNgayTra.CustomFormat = "dd-MM-yyyy";
            this.dtpConfirmNgayTra.Enabled = false;
            this.dtpConfirmNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpConfirmNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConfirmNgayTra.Location = new System.Drawing.Point(572, 176);
            this.dtpConfirmNgayTra.Name = "dtpConfirmNgayTra";
            this.dtpConfirmNgayTra.Size = new System.Drawing.Size(103, 23);
            this.dtpConfirmNgayTra.TabIndex = 138;
            // 
            // dtpConfirmNgayMuon
            // 
            this.dtpConfirmNgayMuon.CustomFormat = "dd-MM-yyyy";
            this.dtpConfirmNgayMuon.Enabled = false;
            this.dtpConfirmNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpConfirmNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConfirmNgayMuon.Location = new System.Drawing.Point(572, 145);
            this.dtpConfirmNgayMuon.Name = "dtpConfirmNgayMuon";
            this.dtpConfirmNgayMuon.Size = new System.Drawing.Size(103, 23);
            this.dtpConfirmNgayMuon.TabIndex = 137;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtReadyTenSach
            // 
            this.txtReadyTenSach.Enabled = false;
            this.txtReadyTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyTenSach.Location = new System.Drawing.Point(131, 112);
            this.txtReadyTenSach.Name = "txtReadyTenSach";
            this.txtReadyTenSach.Size = new System.Drawing.Size(204, 23);
            this.txtReadyTenSach.TabIndex = 146;
            this.txtReadyTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadyTenDocGia
            // 
            this.txtReadyTenDocGia.Enabled = false;
            this.txtReadyTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyTenDocGia.Location = new System.Drawing.Point(131, 83);
            this.txtReadyTenDocGia.Name = "txtReadyTenDocGia";
            this.txtReadyTenDocGia.Size = new System.Drawing.Size(236, 23);
            this.txtReadyTenDocGia.TabIndex = 145;
            this.txtReadyTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 140;
            this.label4.Text = "Tên Sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 139;
            this.label8.Text = "Tên Đọc Giả";
            // 
            // txtConfirmTenSach
            // 
            this.txtConfirmTenSach.Enabled = false;
            this.txtConfirmTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmTenSach.Location = new System.Drawing.Point(507, 109);
            this.txtConfirmTenSach.Name = "txtConfirmTenSach";
            this.txtConfirmTenSach.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmTenSach.TabIndex = 154;
            this.txtConfirmTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfirmTenDocGia
            // 
            this.txtConfirmTenDocGia.Enabled = false;
            this.txtConfirmTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmTenDocGia.Location = new System.Drawing.Point(507, 80);
            this.txtConfirmTenDocGia.Name = "txtConfirmTenDocGia";
            this.txtConfirmTenDocGia.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmTenDocGia.TabIndex = 153;
            this.txtConfirmTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(385, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 148;
            this.label14.Text = "Tên Sách";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(385, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 17);
            this.label15.TabIndex = 147;
            this.label15.Text = "Tên Đọc Giả";
            // 
            // btnDongPhieuMuon
            // 
            this.btnDongPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongPhieuMuon.Location = new System.Drawing.Point(386, 205);
            this.btnDongPhieuMuon.Name = "btnDongPhieuMuon";
            this.btnDongPhieuMuon.Size = new System.Drawing.Size(355, 56);
            this.btnDongPhieuMuon.TabIndex = 155;
            this.btnDongPhieuMuon.Text = "Đóng Phiếu Mượn";
            this.btnDongPhieuMuon.UseVisualStyleBackColor = true;
            this.btnDongPhieuMuon.Click += new System.EventHandler(this.btnDongPhieuMuon_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(339, 112);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(28, 23);
            this.txtMaSach.TabIndex = 156;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPhieuMuonSachDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.btnDongPhieuMuon);
            this.Controls.Add(this.txtConfirmTenSach);
            this.Controls.Add(this.txtConfirmTenDocGia);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtReadyTenSach);
            this.Controls.Add(this.txtReadyTenDocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpConfirmNgayTra);
            this.Controls.Add(this.dtpConfirmNgayMuon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtConfirmMaPhieu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpReadyNgayTra);
            this.Controls.Add(this.dtpReadyNgayMuon);
            this.Controls.Add(this.btnXacNhanThongTinDong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReadyMaPhieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHuyThaoTac);
            this.Controls.Add(this.label1);
            this.Name = "FrmPhieuMuonSachDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NguoiMuonSachQL";
            this.Load += new System.EventHandler(this.FrmPhieuMuonSachDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpReadyNgayTra;
        private System.Windows.Forms.DateTimePicker dtpReadyNgayMuon;
        private System.Windows.Forms.Button btnXacNhanThongTinDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadyMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConfirmMaPhieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpConfirmNgayTra;
        private System.Windows.Forms.DateTimePicker dtpConfirmNgayMuon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtConfirmTenSach;
        private System.Windows.Forms.TextBox txtConfirmTenDocGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtReadyTenSach;
        private System.Windows.Forms.TextBox txtReadyTenDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDongPhieuMuon;
        private System.Windows.Forms.TextBox txtMaSach;
    }
}