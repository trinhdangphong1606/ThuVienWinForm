namespace GUI
{
    partial class FrmSachCapNhat
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorNoiDung = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvDanhMuc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorTenSach = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgonNgu = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorNamXuatBan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaSach = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaDanhMuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorTacGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.richNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDanhMuc);
            this.groupBox1.Controls.Add(this.TxtMaDanhMuc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTenDanhMuc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.richNoiDung);
            this.groupBox1.Controls.Add(this.txtNgonNgu);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtNamXuatBan);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // errorNoiDung
            // 
            this.errorNoiDung.ContainerControl = this;
            // 
            // lvDanhMuc
            // 
            this.lvDanhMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDanhMuc.FullRowSelect = true;
            this.lvDanhMuc.GridLines = true;
            this.lvDanhMuc.HideSelection = false;
            this.lvDanhMuc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvDanhMuc.Location = new System.Drawing.Point(387, 119);
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(264, 109);
            this.lvDanhMuc.TabIndex = 83;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lvDanhMuc.View = System.Windows.Forms.View.Details;
            this.lvDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lvDanhMuc_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Danh Mục";
            this.columnHeader2.Width = 180;
            // 
            // errorTenSach
            // 
            this.errorTenSach.ContainerControl = this;
            // 
            // errorNgonNgu
            // 
            this.errorNgonNgu.ContainerControl = this;
            // 
            // TxtMaDanhMuc
            // 
            this.TxtMaDanhMuc.Enabled = false;
            this.TxtMaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaDanhMuc.Location = new System.Drawing.Point(131, 122);
            this.TxtMaDanhMuc.Name = "TxtMaDanhMuc";
            this.TxtMaDanhMuc.Size = new System.Drawing.Size(216, 23);
            this.TxtMaDanhMuc.TabIndex = 82;
            this.TxtMaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Danh Mục Cần Đổi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Mã Danh Mục :";
            // 
            // errorNamXuatBan
            // 
            this.errorNamXuatBan.ContainerControl = this;
            // 
            // errorMaSach
            // 
            this.errorMaSach.ContainerControl = this;
            // 
            // errorMaDanhMuc
            // 
            this.errorMaDanhMuc.ContainerControl = this;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Enabled = false;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(470, 68);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(181, 23);
            this.txtTenDanhMuc.TabIndex = 81;
            this.txtTenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Danh Mục";
            // 
            // errorTacGia
            // 
            this.errorTacGia.ContainerControl = this;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(421, 364);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 37);
            this.btnThoat.TabIndex = 77;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(104, 363);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(182, 38);
            this.btnCapNhat.TabIndex = 76;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // richNoiDung
            // 
            this.richNoiDung.Location = new System.Drawing.Point(131, 234);
            this.richNoiDung.Name = "richNoiDung";
            this.richNoiDung.Size = new System.Drawing.Size(520, 114);
            this.richNoiDung.TabIndex = 75;
            this.richNoiDung.Text = "";
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Location = new System.Drawing.Point(131, 208);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(216, 20);
            this.txtNgonNgu.TabIndex = 74;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(131, 96);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(216, 20);
            this.txtTacGia.TabIndex = 73;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(131, 151);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(216, 20);
            this.txtMaSach.TabIndex = 72;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(131, 179);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(216, 20);
            this.txtNamXuatBan.TabIndex = 71;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(131, 70);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(216, 20);
            this.txtTenSach.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Tác Giả:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 65;
            this.label10.Text = "Mã Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Năm Xuất Bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Tên Sách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cập Nhật Thông Tin Sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Nội Dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Ngôn Ngữ";
            // 
            // FrmSachCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSachCapNhat";
            this.Text = "FrmSachCapNhat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox TxtMaDanhMuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.RichTextBox richNoiDung;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorNoiDung;
        private System.Windows.Forms.ErrorProvider errorTenSach;
        private System.Windows.Forms.ErrorProvider errorNgonNgu;
        private System.Windows.Forms.ErrorProvider errorNamXuatBan;
        private System.Windows.Forms.ErrorProvider errorMaSach;
        private System.Windows.Forms.ErrorProvider errorMaDanhMuc;
        private System.Windows.Forms.ErrorProvider errorTacGia;
    }
}