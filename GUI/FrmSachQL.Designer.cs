namespace GUI
{
    partial class FrmSachQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSachQL));
            this.LvSachQL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnCapNhatThongTinSach = new System.Windows.Forms.Button();
            this.cbboxSachDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbboxSachNXB = new System.Windows.Forms.ComboBox();
            this.cbboxSachNgonNgu = new System.Windows.Forms.ComboBox();
            this.TxtNgonNgu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNamXuatBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTenTacGia = new System.Windows.Forms.TextBox();
            this.TxtTenSach = new System.Windows.Forms.TextBox();
            this.richNoiDungSach = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbboxSachTacGia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrBChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvSachQL
            // 
            this.LvSachQL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader6});
            this.LvSachQL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LvSachQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSachQL.FullRowSelect = true;
            this.LvSachQL.GridLines = true;
            this.LvSachQL.HideSelection = false;
            this.LvSachQL.Location = new System.Drawing.Point(0, 313);
            this.LvSachQL.Name = "LvSachQL";
            this.LvSachQL.Size = new System.Drawing.Size(706, 216);
            this.LvSachQL.TabIndex = 10;
            this.LvSachQL.UseCompatibleStateImageBehavior = false;
            this.LvSachQL.View = System.Windows.Forms.View.Details;
            this.LvSachQL.SelectedIndexChanged += new System.EventHandler(this.LvSachQL_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Sách";
            this.columnHeader1.Width = 227;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tác Giả";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Danh Mục";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngôn Ngữ";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Năm Xuất Bản";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng Thái";
            this.columnHeader6.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản Lý Sách Thư Viện";
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.button4);
            this.GrBChiTiet.Controls.Add(this.button3);
            this.GrBChiTiet.Controls.Add(this.BtnCapNhatThongTinSach);
            this.GrBChiTiet.Controls.Add(this.cbboxSachDanhMuc);
            this.GrBChiTiet.Controls.Add(this.cbboxSachNXB);
            this.GrBChiTiet.Controls.Add(this.cbboxSachNgonNgu);
            this.GrBChiTiet.Controls.Add(this.TxtNgonNgu);
            this.GrBChiTiet.Controls.Add(this.label6);
            this.GrBChiTiet.Controls.Add(this.TxtTenDanhMuc);
            this.GrBChiTiet.Controls.Add(this.label7);
            this.GrBChiTiet.Controls.Add(this.TxtNamXuatBan);
            this.GrBChiTiet.Controls.Add(this.label5);
            this.GrBChiTiet.Controls.Add(this.TxtTenTacGia);
            this.GrBChiTiet.Controls.Add(this.TxtTenSach);
            this.GrBChiTiet.Controls.Add(this.richNoiDungSach);
            this.GrBChiTiet.Controls.Add(this.label4);
            this.GrBChiTiet.Controls.Add(this.label3);
            this.GrBChiTiet.Controls.Add(this.cbboxSachTacGia);
            this.GrBChiTiet.Controls.Add(this.button1);
            this.GrBChiTiet.Controls.Add(this.textBox1);
            this.GrBChiTiet.Controls.Add(this.label2);
            this.GrBChiTiet.Location = new System.Drawing.Point(0, 42);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(699, 265);
            this.GrBChiTiet.TabIndex = 11;
            this.GrBChiTiet.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(565, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 28);
            this.button4.TabIndex = 26;
            this.button4.Text = "Xóa Sách";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(345, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 28);
            this.button3.TabIndex = 25;
            this.button3.Text = "Thêm Sách Mới Vào Thư Viện";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnCapNhatThongTinSach
            // 
            this.BtnCapNhatThongTinSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCapNhatThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapNhatThongTinSach.Location = new System.Drawing.Point(87, 201);
            this.BtnCapNhatThongTinSach.Name = "BtnCapNhatThongTinSach";
            this.BtnCapNhatThongTinSach.Size = new System.Drawing.Size(252, 28);
            this.BtnCapNhatThongTinSach.TabIndex = 24;
            this.BtnCapNhatThongTinSach.Text = "Cập Nhật Thông Tin Sách";
            this.BtnCapNhatThongTinSach.UseVisualStyleBackColor = true;
            this.BtnCapNhatThongTinSach.Click += new System.EventHandler(this.BtnCapNhatThongTinSach_Click);
            // 
            // cbboxSachDanhMuc
            // 
            this.cbboxSachDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxSachDanhMuc.FormattingEnabled = true;
            this.cbboxSachDanhMuc.Location = new System.Drawing.Point(373, 235);
            this.cbboxSachDanhMuc.Name = "cbboxSachDanhMuc";
            this.cbboxSachDanhMuc.Size = new System.Drawing.Size(89, 26);
            this.cbboxSachDanhMuc.TabIndex = 23;
            this.cbboxSachDanhMuc.Text = "Thể Loại";
            // 
            // cbboxSachNXB
            // 
            this.cbboxSachNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxSachNXB.FormattingEnabled = true;
            this.cbboxSachNXB.Location = new System.Drawing.Point(568, 235);
            this.cbboxSachNXB.Name = "cbboxSachNXB";
            this.cbboxSachNXB.Size = new System.Drawing.Size(125, 26);
            this.cbboxSachNXB.TabIndex = 22;
            this.cbboxSachNXB.Text = "Năm Xuất Bản";
            // 
            // cbboxSachNgonNgu
            // 
            this.cbboxSachNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxSachNgonNgu.FormattingEnabled = true;
            this.cbboxSachNgonNgu.Location = new System.Drawing.Point(468, 234);
            this.cbboxSachNgonNgu.Name = "cbboxSachNgonNgu";
            this.cbboxSachNgonNgu.Size = new System.Drawing.Size(97, 26);
            this.cbboxSachNgonNgu.TabIndex = 21;
            this.cbboxSachNgonNgu.Text = "Ngôn Ngữ";
            // 
            // TxtNgonNgu
            // 
            this.TxtNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNgonNgu.Location = new System.Drawing.Point(525, 71);
            this.TxtNgonNgu.Name = "TxtNgonNgu";
            this.TxtNgonNgu.Size = new System.Drawing.Size(132, 23);
            this.TxtNgonNgu.TabIndex = 20;
            this.TxtNgonNgu.Text = "Việt Nam";
            this.TxtNgonNgu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngôn Ngữ";
            // 
            // TxtTenDanhMuc
            // 
            this.TxtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenDanhMuc.Location = new System.Drawing.Point(87, 71);
            this.TxtTenDanhMuc.Name = "TxtTenDanhMuc";
            this.TxtTenDanhMuc.Size = new System.Drawing.Size(296, 23);
            this.TxtTenDanhMuc.TabIndex = 18;
            this.TxtTenDanhMuc.Text = "Truyện";
            this.TxtTenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Danh Mục";
            // 
            // TxtNamXuatBan
            // 
            this.TxtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamXuatBan.Location = new System.Drawing.Point(525, 42);
            this.TxtNamXuatBan.Name = "TxtNamXuatBan";
            this.TxtNamXuatBan.Size = new System.Drawing.Size(132, 23);
            this.TxtNamXuatBan.TabIndex = 16;
            this.TxtNamXuatBan.Text = "XXX";
            this.TxtNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // TxtTenTacGia
            // 
            this.TxtTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenTacGia.Location = new System.Drawing.Point(87, 42);
            this.TxtTenTacGia.Name = "TxtTenTacGia";
            this.TxtTenTacGia.Size = new System.Drawing.Size(296, 23);
            this.TxtTenTacGia.TabIndex = 14;
            this.TxtTenTacGia.Text = "Tô Hoài";
            this.TxtTenTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTenSach
            // 
            this.TxtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenSach.Location = new System.Drawing.Point(87, 13);
            this.TxtTenSach.Name = "TxtTenSach";
            this.TxtTenSach.Size = new System.Drawing.Size(570, 23);
            this.TxtTenSach.TabIndex = 13;
            this.TxtTenSach.Text = "Dế Mèn phiêu lưu ký";
            this.TxtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richNoiDungSach
            // 
            this.richNoiDungSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNoiDungSach.Location = new System.Drawing.Point(87, 100);
            this.richNoiDungSach.Name = "richNoiDungSach";
            this.richNoiDungSach.Size = new System.Drawing.Size(583, 97);
            this.richNoiDungSach.TabIndex = 12;
            this.richNoiDungSach.Text = resources.GetString("richNoiDungSach.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nội Dung";
            // 
            // cbboxSachTacGia
            // 
            this.cbboxSachTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxSachTacGia.FormattingEnabled = true;
            this.cbboxSachTacGia.Location = new System.Drawing.Point(229, 235);
            this.cbboxSachTacGia.Name = "cbboxSachTacGia";
            this.cbboxSachTacGia.Size = new System.Drawing.Size(138, 26);
            this.cbboxSachTacGia.TabIndex = 3;
            this.cbboxSachTacGia.Text = "Tác Giả";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Nhập tên sách cần tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Sách ";
            // 
            // FrmSachQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.LvSachQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrBChiTiet);
            this.Name = "FrmSachQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSachQL";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSachQL_Load);
            this.GrBChiTiet.ResumeLayout(false);
            this.GrBChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvSachQL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBChiTiet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnCapNhatThongTinSach;
        private System.Windows.Forms.ComboBox cbboxSachDanhMuc;
        private System.Windows.Forms.ComboBox cbboxSachNXB;
        private System.Windows.Forms.ComboBox cbboxSachNgonNgu;
        private System.Windows.Forms.TextBox TxtNgonNgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTenDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNamXuatBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTenTacGia;
        private System.Windows.Forms.TextBox TxtTenSach;
        private System.Windows.Forms.RichTextBox richNoiDungSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbboxSachTacGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}