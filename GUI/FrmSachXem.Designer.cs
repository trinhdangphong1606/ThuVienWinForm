﻿namespace GUI
{
    partial class FrmSachXem
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
            this.LvSachQL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.columnHeader3});
            this.LvSachQL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LvSachQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvSachQL.FullRowSelect = true;
            this.LvSachQL.GridLines = true;
            this.LvSachQL.HideSelection = false;
            this.LvSachQL.Location = new System.Drawing.Point(0, 279);
            this.LvSachQL.Name = "LvSachQL";
            this.LvSachQL.Size = new System.Drawing.Size(701, 176);
            this.LvSachQL.TabIndex = 13;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Xem Sách";
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.button2);
            this.GrBChiTiet.Controls.Add(this.textBox2);
            this.GrBChiTiet.Controls.Add(this.button1);
            this.GrBChiTiet.Controls.Add(this.textBox1);
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
            this.GrBChiTiet.Controls.Add(this.label2);
            this.GrBChiTiet.Location = new System.Drawing.Point(0, 38);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(700, 235);
            this.GrBChiTiet.TabIndex = 14;
            this.GrBChiTiet.TabStop = false;
            // 
            // TxtNgonNgu
            // 
            this.TxtNgonNgu.Enabled = false;
            this.TxtNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNgonNgu.Location = new System.Drawing.Point(561, 71);
            this.TxtNgonNgu.Name = "TxtNgonNgu";
            this.TxtNgonNgu.Size = new System.Drawing.Size(132, 23);
            this.TxtNgonNgu.TabIndex = 20;
            this.TxtNgonNgu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngôn Ngữ";
            // 
            // TxtTenDanhMuc
            // 
            this.TxtTenDanhMuc.Enabled = false;
            this.TxtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenDanhMuc.Location = new System.Drawing.Point(87, 71);
            this.TxtTenDanhMuc.Name = "TxtTenDanhMuc";
            this.TxtTenDanhMuc.Size = new System.Drawing.Size(351, 23);
            this.TxtTenDanhMuc.TabIndex = 18;
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
            this.TxtNamXuatBan.Enabled = false;
            this.TxtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamXuatBan.Location = new System.Drawing.Point(561, 42);
            this.TxtNamXuatBan.Name = "TxtNamXuatBan";
            this.TxtNamXuatBan.Size = new System.Drawing.Size(132, 23);
            this.TxtNamXuatBan.TabIndex = 16;
            this.TxtNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // TxtTenTacGia
            // 
            this.TxtTenTacGia.Enabled = false;
            this.TxtTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenTacGia.Location = new System.Drawing.Point(87, 42);
            this.TxtTenTacGia.Name = "TxtTenTacGia";
            this.TxtTenTacGia.Size = new System.Drawing.Size(351, 23);
            this.TxtTenTacGia.TabIndex = 14;
            this.TxtTenTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTenSach
            // 
            this.TxtTenSach.Enabled = false;
            this.TxtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenSach.Location = new System.Drawing.Point(87, 13);
            this.TxtTenSach.Name = "TxtTenSach";
            this.TxtTenSach.Size = new System.Drawing.Size(606, 23);
            this.TxtTenSach.TabIndex = 13;
            this.TxtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richNoiDungSach
            // 
            this.richNoiDungSach.Enabled = false;
            this.richNoiDungSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNoiDungSach.Location = new System.Drawing.Point(88, 100);
            this.richNoiDungSach.Name = "richNoiDungSach";
            this.richNoiDungSach.Size = new System.Drawing.Size(606, 97);
            this.richNoiDungSach.TabIndex = 12;
            this.richNoiDungSach.Text = "";
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(655, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(404, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 24);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Nhập tên danh mục cần tìm";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 24);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Nhập tên sách cần tìm";
            // 
            // FrmSachXem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 455);
            this.Controls.Add(this.LvSachQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrBChiTiet);
            this.Name = "FrmSachXem";
            this.Text = "FrmSachXem";
            this.Load += new System.EventHandler(this.FrmSachXem_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}