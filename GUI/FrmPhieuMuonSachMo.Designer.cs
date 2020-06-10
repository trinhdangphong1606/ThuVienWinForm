namespace GUI
{
    partial class FrmPhieuMuonSachMo
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
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnHuyTao = new System.Windows.Forms.Button();
            this.lvPMSTSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPMSTDocGia = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.btnTimTenSach = new System.Windows.Forms.Button();
            this.btnTimTenDocGia = new System.Windows.Forms.Button();
            this.txtTimTenNMS = new System.Windows.Forms.TextBox();
            this.btnXacNhanThongTin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadyMaDocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetimeReadyNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.datetimeReadyNgayDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReadyMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmTenDocGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConfirmTenSach = new System.Windows.Forms.TextBox();
            this.txtConfirmMaSach = new System.Windows.Forms.TextBox();
            this.txtConfirmMaDocGia = new System.Windows.Forms.TextBox();
            this.txtReadyTenSach = new System.Windows.Forms.TextBox();
            this.txtReadyTenDocGia = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datetimeConfirmNgayDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.datetimeConfirmNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.errorTimDocGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTimTenSach = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimTenSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tạo Phiếu Mượn Sách";
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieu.Location = new System.Drawing.Point(12, 413);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(360, 25);
            this.btnTaoPhieu.TabIndex = 24;
            this.btnTaoPhieu.Text = "Tạo Phiếu";
            this.btnTaoPhieu.UseVisualStyleBackColor = true;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // btnHuyTao
            // 
            this.btnHuyTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTao.Location = new System.Drawing.Point(390, 414);
            this.btnHuyTao.Name = "btnHuyTao";
            this.btnHuyTao.Size = new System.Drawing.Size(319, 25);
            this.btnHuyTao.TabIndex = 25;
            this.btnHuyTao.Text = "Hủy Tạo";
            this.btnHuyTao.UseVisualStyleBackColor = true;
            this.btnHuyTao.Click += new System.EventHandler(this.btnHuyTao_Click);
            // 
            // lvPMSTSach
            // 
            this.lvPMSTSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPMSTSach.FullRowSelect = true;
            this.lvPMSTSach.GridLines = true;
            this.lvPMSTSach.HideSelection = false;
            this.lvPMSTSach.Location = new System.Drawing.Point(390, 269);
            this.lvPMSTSach.Name = "lvPMSTSach";
            this.lvPMSTSach.Size = new System.Drawing.Size(319, 139);
            this.lvPMSTSach.TabIndex = 39;
            this.lvPMSTSach.UseCompatibleStateImageBehavior = false;
            this.lvPMSTSach.View = System.Windows.Forms.View.Details;
            this.lvPMSTSach.SelectedIndexChanged += new System.EventHandler(this.lvPMSTSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 245;
            // 
            // lvPMSTDocGia
            // 
            this.lvPMSTDocGia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvPMSTDocGia.FullRowSelect = true;
            this.lvPMSTDocGia.GridLines = true;
            this.lvPMSTDocGia.HideSelection = false;
            this.lvPMSTDocGia.Location = new System.Drawing.Point(390, 79);
            this.lvPMSTDocGia.Name = "lvPMSTDocGia";
            this.lvPMSTDocGia.Size = new System.Drawing.Size(319, 149);
            this.lvPMSTDocGia.TabIndex = 40;
            this.lvPMSTDocGia.UseCompatibleStateImageBehavior = false;
            this.lvPMSTDocGia.View = System.Windows.Forms.View.Details;
            this.lvPMSTDocGia.SelectedIndexChanged += new System.EventHandler(this.lvPMSTDocGia_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Đọc Giả";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Đọc Giả";
            this.columnHeader4.Width = 225;
            // 
            // txtTimSach
            // 
            this.txtTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSach.Location = new System.Drawing.Point(470, 240);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(162, 23);
            this.txtTimSach.TabIndex = 41;
            this.txtTimSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTimTenSach
            // 
            this.btnTimTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTenSach.Location = new System.Drawing.Point(653, 240);
            this.btnTimTenSach.Name = "btnTimTenSach";
            this.btnTimTenSach.Size = new System.Drawing.Size(56, 25);
            this.btnTimTenSach.TabIndex = 42;
            this.btnTimTenSach.Text = "Tìm";
            this.btnTimTenSach.UseVisualStyleBackColor = true;
            this.btnTimTenSach.Click += new System.EventHandler(this.btnTimTenSach_Click);
            // 
            // btnTimTenDocGia
            // 
            this.btnTimTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTenDocGia.Location = new System.Drawing.Point(653, 50);
            this.btnTimTenDocGia.Name = "btnTimTenDocGia";
            this.btnTimTenDocGia.Size = new System.Drawing.Size(56, 25);
            this.btnTimTenDocGia.TabIndex = 44;
            this.btnTimTenDocGia.Text = "Tìm";
            this.btnTimTenDocGia.UseVisualStyleBackColor = true;
            this.btnTimTenDocGia.Click += new System.EventHandler(this.btnTimTenDocGia_Click);
            // 
            // txtTimTenNMS
            // 
            this.txtTimTenNMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenNMS.Location = new System.Drawing.Point(490, 50);
            this.txtTimTenNMS.Name = "txtTimTenNMS";
            this.txtTimTenNMS.Size = new System.Drawing.Size(142, 23);
            this.txtTimTenNMS.TabIndex = 43;
            this.txtTimTenNMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXacNhanThongTin
            // 
            this.btnXacNhanThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThongTin.Location = new System.Drawing.Point(17, 220);
            this.btnXacNhanThongTin.Name = "btnXacNhanThongTin";
            this.btnXacNhanThongTin.Size = new System.Drawing.Size(355, 25);
            this.btnXacNhanThongTin.TabIndex = 56;
            this.btnXacNhanThongTin.Text = "Xác Nhận Thông Tin Phiếu Mượn";
            this.btnXacNhanThongTin.UseVisualStyleBackColor = true;
            this.btnXacNhanThongTin.Click += new System.EventHandler(this.btnXacNhanThongTin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Mã Đọc Giả";
            // 
            // txtReadyMaDocGia
            // 
            this.txtReadyMaDocGia.Enabled = false;
            this.txtReadyMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyMaDocGia.Location = new System.Drawing.Point(136, 52);
            this.txtReadyMaDocGia.Name = "txtReadyMaDocGia";
            this.txtReadyMaDocGia.Size = new System.Drawing.Size(236, 23);
            this.txtReadyMaDocGia.TabIndex = 66;
            this.txtReadyMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Dự Kiến Trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tên Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ngày Mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tên Đọc Giả";
            // 
            // datetimeReadyNgayMuon
            // 
            this.datetimeReadyNgayMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimeReadyNgayMuon.CustomFormat = "dd-MM-yyyy";
            this.datetimeReadyNgayMuon.Enabled = false;
            this.datetimeReadyNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeReadyNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeReadyNgayMuon.Location = new System.Drawing.Point(206, 160);
            this.datetimeReadyNgayMuon.Name = "datetimeReadyNgayMuon";
            this.datetimeReadyNgayMuon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datetimeReadyNgayMuon.Size = new System.Drawing.Size(104, 23);
            this.datetimeReadyNgayMuon.TabIndex = 68;
            // 
            // datetimeReadyNgayDuKienTra
            // 
            this.datetimeReadyNgayDuKienTra.CustomFormat = "dd-MM-yyyy";
            this.datetimeReadyNgayDuKienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeReadyNgayDuKienTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeReadyNgayDuKienTra.Location = new System.Drawing.Point(206, 188);
            this.datetimeReadyNgayDuKienTra.Name = "datetimeReadyNgayDuKienTra";
            this.datetimeReadyNgayDuKienTra.Size = new System.Drawing.Size(104, 23);
            this.datetimeReadyNgayDuKienTra.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Mã Sách";
            // 
            // txtReadyMaSach
            // 
            this.txtReadyMaSach.Enabled = false;
            this.txtReadyMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyMaSach.Location = new System.Drawing.Point(136, 105);
            this.txtReadyMaSach.Name = "txtReadyMaSach";
            this.txtReadyMaSach.Size = new System.Drawing.Size(236, 23);
            this.txtReadyMaSach.TabIndex = 71;
            this.txtReadyMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Mã Sách";
            // 
            // txtConfirmTenDocGia
            // 
            this.txtConfirmTenDocGia.Enabled = false;
            this.txtConfirmTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmTenDocGia.Location = new System.Drawing.Point(136, 280);
            this.txtConfirmTenDocGia.Name = "txtConfirmTenDocGia";
            this.txtConfirmTenDocGia.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmTenDocGia.TabIndex = 79;
            this.txtConfirmTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Mã Đọc Giả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Tên Sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 72;
            this.label11.Text = "Tên Đọc Giả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 81;
            this.label12.Text = "Dự Kiến Trả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 80;
            this.label13.Text = "Ngày Mượn";
            // 
            // txtConfirmTenSach
            // 
            this.txtConfirmTenSach.Enabled = false;
            this.txtConfirmTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmTenSach.Location = new System.Drawing.Point(136, 332);
            this.txtConfirmTenSach.Name = "txtConfirmTenSach";
            this.txtConfirmTenSach.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmTenSach.TabIndex = 83;
            this.txtConfirmTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfirmMaSach
            // 
            this.txtConfirmMaSach.Enabled = false;
            this.txtConfirmMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmMaSach.Location = new System.Drawing.Point(136, 306);
            this.txtConfirmMaSach.Name = "txtConfirmMaSach";
            this.txtConfirmMaSach.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmMaSach.TabIndex = 87;
            this.txtConfirmMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfirmMaDocGia
            // 
            this.txtConfirmMaDocGia.Enabled = false;
            this.txtConfirmMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmMaDocGia.Location = new System.Drawing.Point(136, 254);
            this.txtConfirmMaDocGia.Name = "txtConfirmMaDocGia";
            this.txtConfirmMaDocGia.Size = new System.Drawing.Size(236, 23);
            this.txtConfirmMaDocGia.TabIndex = 86;
            this.txtConfirmMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadyTenSach
            // 
            this.txtReadyTenSach.Enabled = false;
            this.txtReadyTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyTenSach.Location = new System.Drawing.Point(136, 131);
            this.txtReadyTenSach.Name = "txtReadyTenSach";
            this.txtReadyTenSach.Size = new System.Drawing.Size(236, 23);
            this.txtReadyTenSach.TabIndex = 90;
            this.txtReadyTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadyTenDocGia
            // 
            this.txtReadyTenDocGia.Enabled = false;
            this.txtReadyTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyTenDocGia.Location = new System.Drawing.Point(136, 79);
            this.txtReadyTenDocGia.Name = "txtReadyTenDocGia";
            this.txtReadyTenDocGia.Size = new System.Drawing.Size(236, 23);
            this.txtReadyTenDocGia.TabIndex = 89;
            this.txtReadyTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // datetimeConfirmNgayDuKienTra
            // 
            this.datetimeConfirmNgayDuKienTra.CustomFormat = "dd-MM-yyyy";
            this.datetimeConfirmNgayDuKienTra.Enabled = false;
            this.datetimeConfirmNgayDuKienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeConfirmNgayDuKienTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeConfirmNgayDuKienTra.Location = new System.Drawing.Point(206, 382);
            this.datetimeConfirmNgayDuKienTra.Name = "datetimeConfirmNgayDuKienTra";
            this.datetimeConfirmNgayDuKienTra.Size = new System.Drawing.Size(104, 23);
            this.datetimeConfirmNgayDuKienTra.TabIndex = 92;
            // 
            // datetimeConfirmNgayMuon
            // 
            this.datetimeConfirmNgayMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimeConfirmNgayMuon.CustomFormat = "dd-MM-yyyy";
            this.datetimeConfirmNgayMuon.Enabled = false;
            this.datetimeConfirmNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeConfirmNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeConfirmNgayMuon.Location = new System.Drawing.Point(206, 356);
            this.datetimeConfirmNgayMuon.Name = "datetimeConfirmNgayMuon";
            this.datetimeConfirmNgayMuon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datetimeConfirmNgayMuon.Size = new System.Drawing.Size(104, 23);
            this.datetimeConfirmNgayMuon.TabIndex = 91;
            // 
            // errorTimDocGia
            // 
            this.errorTimDocGia.ContainerControl = this;
            // 
            // errorTimTenSach
            // 
            this.errorTimTenSach.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(387, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 93;
            this.label14.Text = "Tìm Đọc Giả";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(389, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 94;
            this.label15.Text = "Tìm Sách";
            // 
            // FrmPhieuMuonSachMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.datetimeConfirmNgayDuKienTra);
            this.Controls.Add(this.datetimeConfirmNgayMuon);
            this.Controls.Add(this.txtReadyTenSach);
            this.Controls.Add(this.txtReadyTenDocGia);
            this.Controls.Add(this.txtConfirmMaSach);
            this.Controls.Add(this.txtConfirmMaDocGia);
            this.Controls.Add(this.txtConfirmTenSach);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConfirmTenDocGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReadyMaSach);
            this.Controls.Add(this.datetimeReadyNgayDuKienTra);
            this.Controls.Add(this.datetimeReadyNgayMuon);
            this.Controls.Add(this.btnXacNhanThongTin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReadyMaDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimTenDocGia);
            this.Controls.Add(this.txtTimTenNMS);
            this.Controls.Add(this.btnTimTenSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.lvPMSTDocGia);
            this.Controls.Add(this.lvPMSTSach);
            this.Controls.Add(this.btnHuyTao);
            this.Controls.Add(this.btnTaoPhieu);
            this.Controls.Add(this.label1);
            this.Name = "FrmPhieuMuonSachMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mở Phiếu Mượn Sách";
            this.Load += new System.EventHandler(this.FrmPhieuMuonSachMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimTenSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnHuyTao;
        private System.Windows.Forms.ListView lvPMSTSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvPMSTDocGia;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Button btnTimTenSach;
        private System.Windows.Forms.Button btnTimTenDocGia;
        private System.Windows.Forms.TextBox txtTimTenNMS;
        private System.Windows.Forms.Button btnXacNhanThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadyMaDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimeReadyNgayMuon;
        private System.Windows.Forms.DateTimePicker datetimeReadyNgayDuKienTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReadyMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmTenDocGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConfirmTenSach;
        private System.Windows.Forms.TextBox txtConfirmMaSach;
        private System.Windows.Forms.TextBox txtConfirmMaDocGia;
        private System.Windows.Forms.TextBox txtReadyTenSach;
        private System.Windows.Forms.TextBox txtReadyTenDocGia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.DateTimePicker datetimeConfirmNgayDuKienTra;
        private System.Windows.Forms.DateTimePicker datetimeConfirmNgayMuon;
        private System.Windows.Forms.ErrorProvider errorTimDocGia;
        private System.Windows.Forms.ErrorProvider errorTimTenSach;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}