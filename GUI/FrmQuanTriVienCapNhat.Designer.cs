namespace GUI
{
    partial class FrmQuanTriVienCapNhat
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
            this.label2 = new System.Windows.Forms.Label();
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.btnQuyenStaff = new System.Windows.Forms.Button();
            this.btnQuyenAdmin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuyThaoTac = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuyenUser = new System.Windows.Forms.Button();
            this.GrBChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Tên";
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.btnQuyenUser);
            this.GrBChiTiet.Controls.Add(this.txtQuyen);
            this.GrBChiTiet.Controls.Add(this.btnQuyenStaff);
            this.GrBChiTiet.Controls.Add(this.btnQuyenAdmin);
            this.GrBChiTiet.Controls.Add(this.label11);
            this.GrBChiTiet.Controls.Add(this.txtAccount);
            this.GrBChiTiet.Controls.Add(this.label8);
            this.GrBChiTiet.Controls.Add(this.btnHuyThaoTac);
            this.GrBChiTiet.Controls.Add(this.btnCapNhat);
            this.GrBChiTiet.Controls.Add(this.txtMa);
            this.GrBChiTiet.Controls.Add(this.label3);
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
            this.GrBChiTiet.Location = new System.Drawing.Point(0, 37);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(677, 226);
            this.GrBChiTiet.TabIndex = 32;
            this.GrBChiTiet.TabStop = false;
            // 
            // txtQuyen
            // 
            this.txtQuyen.Enabled = false;
            this.txtQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.Location = new System.Drawing.Point(123, 130);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(216, 23);
            this.txtQuyen.TabIndex = 48;
            this.txtQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuyenStaff
            // 
            this.btnQuyenStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuyenStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyenStaff.Location = new System.Drawing.Point(453, 128);
            this.btnQuyenStaff.Name = "btnQuyenStaff";
            this.btnQuyenStaff.Size = new System.Drawing.Size(103, 25);
            this.btnQuyenStaff.TabIndex = 47;
            this.btnQuyenStaff.Text = "Staff";
            this.btnQuyenStaff.UseVisualStyleBackColor = true;
            this.btnQuyenStaff.Click += new System.EventHandler(this.btnQuyenStaff_Click);
            // 
            // btnQuyenAdmin
            // 
            this.btnQuyenAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuyenAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyenAdmin.Location = new System.Drawing.Point(562, 130);
            this.btnQuyenAdmin.Name = "btnQuyenAdmin";
            this.btnQuyenAdmin.Size = new System.Drawing.Size(95, 25);
            this.btnQuyenAdmin.TabIndex = 45;
            this.btnQuyenAdmin.Text = "Admin";
            this.btnQuyenAdmin.UseVisualStyleBackColor = true;
            this.btnQuyenAdmin.Click += new System.EventHandler(this.btnQuyenAdmin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Quyền";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(544, 72);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(113, 23);
            this.txtAccount.TabIndex = 35;
            this.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Account";
            // 
            // btnHuyThaoTac
            // 
            this.btnHuyThaoTac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThaoTac.Location = new System.Drawing.Point(338, 159);
            this.btnHuyThaoTac.Name = "btnHuyThaoTac";
            this.btnHuyThaoTac.Size = new System.Drawing.Size(319, 55);
            this.btnHuyThaoTac.TabIndex = 33;
            this.btnHuyThaoTac.Text = "Hủy Thao Tác";
            this.btnHuyThaoTac.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(15, 159);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(300, 55);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập Nhật Thông Tin ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(544, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(113, 23);
            this.txtMa.TabIndex = 30;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(123, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 23);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(123, 101);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(534, 23);
            this.txtDiaChi.TabIndex = 18;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(544, 43);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(113, 23);
            this.txtNamSinh.TabIndex = 16;
            this.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Năm Sinh";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(123, 43);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(329, 23);
            this.txtSoDienThoai.TabIndex = 14;
            this.txtSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(123, 14);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(329, 23);
            this.txtTen.TabIndex = 13;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cập Nhật Thông Tin Quản Trị Viên";
            // 
            // btnQuyenUser
            // 
            this.btnQuyenUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuyenUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyenUser.Location = new System.Drawing.Point(345, 128);
            this.btnQuyenUser.Name = "btnQuyenUser";
            this.btnQuyenUser.Size = new System.Drawing.Size(102, 25);
            this.btnQuyenUser.TabIndex = 49;
            this.btnQuyenUser.Text = "User";
            this.btnQuyenUser.UseVisualStyleBackColor = true;
            this.btnQuyenUser.Click += new System.EventHandler(this.btnQuyenUser_Click);
            // 
            // FrmQuanTriVienCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 264);
            this.Controls.Add(this.GrBChiTiet);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanTriVienCapNhat";
            this.Text = "FrmQuanTriVienCapNhat";
            this.Load += new System.EventHandler(this.FrmQuanTriVienCapNhat_Load);
            this.GrBChiTiet.ResumeLayout(false);
            this.GrBChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrBChiTiet;
        private System.Windows.Forms.Button btnHuyThaoTac;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Button btnQuyenStaff;
        private System.Windows.Forms.Button btnQuyenAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnQuyenUser;
    }
}