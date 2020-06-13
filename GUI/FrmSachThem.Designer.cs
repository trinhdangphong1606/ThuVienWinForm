namespace GUI
{
    partial class FrmSachThem
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.TxtNgonNgu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNamXuatBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTenTacGia = new System.Windows.Forms.TextBox();
            this.TxtTenSach = new System.Windows.Forms.TextBox();
            this.richNoiDungSach = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDanhMuc = new System.Windows.Forms.ListView();
            this.errorTenSach = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTacGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNamXuatBan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgonNgu = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaDanhMuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoiDung = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTenSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNgonNgu
            // 
            this.TxtNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNgonNgu.Location = new System.Drawing.Point(470, 113);
            this.TxtNgonNgu.Name = "TxtNgonNgu";
            this.TxtNgonNgu.Size = new System.Drawing.Size(221, 23);
            this.TxtNgonNgu.TabIndex = 34;
            this.TxtNgonNgu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngôn Ngữ";
            // 
            // TxtMaDanhMuc
            // 
            this.TxtMaDanhMuc.Enabled = false;
            this.TxtMaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaDanhMuc.Location = new System.Drawing.Point(470, 146);
            this.TxtMaDanhMuc.Name = "TxtMaDanhMuc";
            this.TxtMaDanhMuc.Size = new System.Drawing.Size(221, 23);
            this.TxtMaDanhMuc.TabIndex = 32;
            this.TxtMaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Danh Mục";
            // 
            // TxtNamXuatBan
            // 
            this.TxtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamXuatBan.Location = new System.Drawing.Point(470, 81);
            this.TxtNamXuatBan.Name = "TxtNamXuatBan";
            this.TxtNamXuatBan.Size = new System.Drawing.Size(221, 23);
            this.TxtNamXuatBan.TabIndex = 30;
            this.TxtNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // TxtTenTacGia
            // 
            this.TxtTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenTacGia.Location = new System.Drawing.Point(94, 113);
            this.TxtTenTacGia.Name = "TxtTenTacGia";
            this.TxtTenTacGia.Size = new System.Drawing.Size(234, 23);
            this.TxtTenTacGia.TabIndex = 28;
            this.TxtTenTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTenSach
            // 
            this.TxtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenSach.Location = new System.Drawing.Point(94, 84);
            this.TxtTenSach.Name = "TxtTenSach";
            this.TxtTenSach.Size = new System.Drawing.Size(234, 23);
            this.TxtTenSach.TabIndex = 27;
            this.TxtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richNoiDungSach
            // 
            this.richNoiDungSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNoiDungSach.Location = new System.Drawing.Point(94, 240);
            this.richNoiDungSach.Name = "richNoiDungSach";
            this.richNoiDungSach.Size = new System.Drawing.Size(606, 82);
            this.richNoiDungSach.TabIndex = 25;
            this.richNoiDungSach.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nội Dung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã Danh Mục :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Sách ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "THÊM SÁCH";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(199, 328);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 45);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(454, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 45);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            // lvDanhMuc
            // 
            this.lvDanhMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDanhMuc.FullRowSelect = true;
            this.lvDanhMuc.GridLines = true;
            this.lvDanhMuc.HideSelection = false;
            this.lvDanhMuc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvDanhMuc.Location = new System.Drawing.Point(94, 142);
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(234, 92);
            this.lvDanhMuc.TabIndex = 37;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lvDanhMuc.View = System.Windows.Forms.View.Details;
            this.lvDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lvDanhMuc_SelectedIndexChanged);
            // 
            // errorTenSach
            // 
            this.errorTenSach.ContainerControl = this;
            // 
            // errorTacGia
            // 
            this.errorTacGia.ContainerControl = this;
            // 
            // errorNamXuatBan
            // 
            this.errorNamXuatBan.ContainerControl = this;
            // 
            // errorNgonNgu
            // 
            this.errorNgonNgu.ContainerControl = this;
            // 
            // errorMaDanhMuc
            // 
            this.errorMaDanhMuc.ContainerControl = this;
            // 
            // errorNoiDung
            // 
            this.errorNoiDung.ContainerControl = this;
            // 
            // FrmSachThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 403);
            this.Controls.Add(this.lvDanhMuc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNgonNgu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMaDanhMuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNamXuatBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTenTacGia);
            this.Controls.Add(this.TxtTenSach);
            this.Controls.Add(this.richNoiDungSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "FrmSachThem";
            this.Text = "FrmSachThem";
            this.Load += new System.EventHandler(this.FrmSachThem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorTenSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNgonNgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMaDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNamXuatBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTenTacGia;
        private System.Windows.Forms.TextBox TxtTenSach;
        private System.Windows.Forms.RichTextBox richNoiDungSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.ErrorProvider errorTenSach;
        private System.Windows.Forms.ErrorProvider errorTacGia;
        private System.Windows.Forms.ErrorProvider errorNamXuatBan;
        private System.Windows.Forms.ErrorProvider errorNgonNgu;
        private System.Windows.Forms.ErrorProvider errorMaDanhMuc;
        private System.Windows.Forms.ErrorProvider errorNoiDung;
    }
}