namespace GUI
{
    partial class FrmNguoiMuonSachThemMoi
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
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyThaoTac = new System.Windows.Forms.Button();
            this.btnThemMoiDG = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoDienThoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNamSinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrBChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Thêm Mới Đọc Giả";
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.txtTenDangNhap);
            this.GrBChiTiet.Controls.Add(this.label8);
            this.GrBChiTiet.Controls.Add(this.txtPass);
            this.GrBChiTiet.Controls.Add(this.label3);
            this.GrBChiTiet.Controls.Add(this.btnHuyThaoTac);
            this.GrBChiTiet.Controls.Add(this.btnThemMoiDG);
            this.GrBChiTiet.Controls.Add(this.txtEmail);
            this.GrBChiTiet.Controls.Add(this.label6);
            this.GrBChiTiet.Controls.Add(this.txtDiaChi);
            this.GrBChiTiet.Controls.Add(this.label7);
            this.GrBChiTiet.Controls.Add(this.txtNamSinh);
            this.GrBChiTiet.Controls.Add(this.label5);
            this.GrBChiTiet.Controls.Add(this.txtSoDienThoai);
            this.GrBChiTiet.Controls.Add(this.txtTen);
            this.GrBChiTiet.Controls.Add(this.label4);
            this.GrBChiTiet.Controls.Add(this.label2);
            this.GrBChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrBChiTiet.Location = new System.Drawing.Point(0, 50);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(684, 212);
            this.GrBChiTiet.TabIndex = 32;
            this.GrBChiTiet.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(140, 128);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(247, 23);
            this.txtTenDangNhap.TabIndex = 6;
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tên Đăng Nhập";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(491, 128);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(169, 23);
            this.txtPass.TabIndex = 7;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mật Khẩu";
            // 
            // btnHuyThaoTac
            // 
            this.btnHuyThaoTac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThaoTac.Location = new System.Drawing.Point(330, 157);
            this.btnHuyThaoTac.Name = "btnHuyThaoTac";
            this.btnHuyThaoTac.Size = new System.Drawing.Size(330, 33);
            this.btnHuyThaoTac.TabIndex = 33;
            this.btnHuyThaoTac.Text = "Hủy";
            this.btnHuyThaoTac.UseVisualStyleBackColor = true;
            this.btnHuyThaoTac.Click += new System.EventHandler(this.btnHuyThaoTac_Click);
            // 
            // btnThemMoiDG
            // 
            this.btnThemMoiDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoiDG.Location = new System.Drawing.Point(15, 157);
            this.btnThemMoiDG.Name = "btnThemMoiDG";
            this.btnThemMoiDG.Size = new System.Drawing.Size(309, 33);
            this.btnThemMoiDG.TabIndex = 32;
            this.btnThemMoiDG.Text = "Thêm Mới";
            this.btnThemMoiDG.UseVisualStyleBackColor = true;
            this.btnThemMoiDG.Click += new System.EventHandler(this.btnThemMoiDG_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(140, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(520, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(140, 72);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(520, 23);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(491, 43);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(169, 23);
            this.txtNamSinh.TabIndex = 3;
            this.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(140, 43);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(243, 23);
            this.txtSoDienThoai.TabIndex = 2;
            this.txtSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(140, 14);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(520, 23);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // errorTen
            // 
            this.errorTen.ContainerControl = this;
            // 
            // errorSoDienThoai
            // 
            this.errorSoDienThoai.ContainerControl = this;
            // 
            // errorNamSinh
            // 
            this.errorNamSinh.ContainerControl = this;
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.ContainerControl = this;
            // 
            // FrmNguoiMuonSachThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrBChiTiet);
            this.Name = "FrmNguoiMuonSachThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Mới Đọc Giả";
            this.GrBChiTiet.ResumeLayout(false);
            this.GrBChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBChiTiet;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Button btnThemMoiDG;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorTen;
        private System.Windows.Forms.ErrorProvider errorSoDienThoai;
        private System.Windows.Forms.ErrorProvider errorNamSinh;
        private System.Windows.Forms.ErrorProvider errorDiaChi;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label8;
    }
}