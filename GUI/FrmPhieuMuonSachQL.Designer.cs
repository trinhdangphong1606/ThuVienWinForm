namespace GUI
{
    partial class FrmPhieuMuonSachQL
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
            this.BtnPMSDong = new System.Windows.Forms.Button();
            this.BtnPMSMo = new System.Windows.Forms.Button();
            this.txtTimPhieuTheoTen = new System.Windows.Forms.TextBox();
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
            this.BtnXemTatCa = new System.Windows.Forms.Button();
            this.btnPhieuDaDong = new System.Windows.Forms.Button();
            this.btnPhieuDangMo = new System.Windows.Forms.Button();
            this.btnCapNhatTrangThaiPhieu = new System.Windows.Forms.Button();
            this.dtpickerNgayDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.dtpickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpickerNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTimNam = new System.Windows.Forms.TextBox();
            this.txtTimThang = new System.Windows.Forms.TextBox();
            this.btnTimThoiGianTao = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimNgay = new System.Windows.Forms.TextBox();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.btnTimTheoMa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimMaPhieu = new System.Windows.Forms.TextBox();
            this.txtTrangThaiPhieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDSPhieuMuon = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorTimMaPhieu = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTimTenDocGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorThang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNam = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrBChiTiet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimMaPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimTenDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNam)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPMSDong
            // 
            this.BtnPMSDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPMSDong.Location = new System.Drawing.Point(569, 14);
            this.BtnPMSDong.Name = "BtnPMSDong";
            this.BtnPMSDong.Size = new System.Drawing.Size(157, 51);
            this.BtnPMSDong.TabIndex = 2;
            this.BtnPMSDong.Text = "Đóng Phiếu Mượn";
            this.BtnPMSDong.UseVisualStyleBackColor = true;
            this.BtnPMSDong.Click += new System.EventHandler(this.BtnPMSDong_Click);
            // 
            // BtnPMSMo
            // 
            this.BtnPMSMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPMSMo.Location = new System.Drawing.Point(398, 14);
            this.BtnPMSMo.Name = "BtnPMSMo";
            this.BtnPMSMo.Size = new System.Drawing.Size(158, 51);
            this.BtnPMSMo.TabIndex = 1;
            this.BtnPMSMo.Text = "Mở Mới Phiếu";
            this.BtnPMSMo.UseVisualStyleBackColor = true;
            this.BtnPMSMo.Click += new System.EventHandler(this.BtnPMSMo_Click);
            // 
            // txtTimPhieuTheoTen
            // 
            this.txtTimPhieuTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimPhieuTheoTen.Location = new System.Drawing.Point(129, 59);
            this.txtTimPhieuTheoTen.Name = "txtTimPhieuTheoTen";
            this.txtTimPhieuTheoTen.Size = new System.Drawing.Size(144, 23);
            this.txtTimPhieuTheoTen.TabIndex = 6;
            this.txtTimPhieuTheoTen.Tag = "";
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.BtnXemTatCa);
            this.GrBChiTiet.Controls.Add(this.btnPhieuDaDong);
            this.GrBChiTiet.Controls.Add(this.btnPhieuDangMo);
            this.GrBChiTiet.Controls.Add(this.btnCapNhatTrangThaiPhieu);
            this.GrBChiTiet.Controls.Add(this.dtpickerNgayDuKienTra);
            this.GrBChiTiet.Controls.Add(this.dtpickerNgayTra);
            this.GrBChiTiet.Controls.Add(this.dtpickerNgayMuon);
            this.GrBChiTiet.Controls.Add(this.label9);
            this.GrBChiTiet.Controls.Add(this.groupBox1);
            this.GrBChiTiet.Controls.Add(this.BtnPMSMo);
            this.GrBChiTiet.Controls.Add(this.BtnPMSDong);
            this.GrBChiTiet.Controls.Add(this.txtTrangThaiPhieu);
            this.GrBChiTiet.Controls.Add(this.label6);
            this.GrBChiTiet.Controls.Add(this.label5);
            this.GrBChiTiet.Controls.Add(this.label3);
            this.GrBChiTiet.Controls.Add(this.txtTenSach);
            this.GrBChiTiet.Controls.Add(this.label7);
            this.GrBChiTiet.Controls.Add(this.txtTenDocGia);
            this.GrBChiTiet.Controls.Add(this.txtMaPhieuMuon);
            this.GrBChiTiet.Controls.Add(this.label4);
            this.GrBChiTiet.Controls.Add(this.label2);
            this.GrBChiTiet.Location = new System.Drawing.Point(-1, 42);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(737, 263);
            this.GrBChiTiet.TabIndex = 16;
            this.GrBChiTiet.TabStop = false;
            // 
            // BtnXemTatCa
            // 
            this.BtnXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemTatCa.Location = new System.Drawing.Point(569, 221);
            this.BtnXemTatCa.Name = "BtnXemTatCa";
            this.BtnXemTatCa.Size = new System.Drawing.Size(162, 35);
            this.BtnXemTatCa.TabIndex = 10;
            this.BtnXemTatCa.Text = "Xem Tất Cả Phiếu";
            this.BtnXemTatCa.UseVisualStyleBackColor = true;
            this.BtnXemTatCa.Click += new System.EventHandler(this.BtnXemTatCa_Click);
            // 
            // btnPhieuDaDong
            // 
            this.btnPhieuDaDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuDaDong.Location = new System.Drawing.Point(290, 222);
            this.btnPhieuDaDong.Name = "btnPhieuDaDong";
            this.btnPhieuDaDong.Size = new System.Drawing.Size(266, 35);
            this.btnPhieuDaDong.TabIndex = 9;
            this.btnPhieuDaDong.Text = "Phiếu Đã Đóng";
            this.btnPhieuDaDong.UseVisualStyleBackColor = true;
            this.btnPhieuDaDong.Click += new System.EventHandler(this.btnPhieuDaDong_Click);
            // 
            // btnPhieuDangMo
            // 
            this.btnPhieuDangMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuDangMo.Location = new System.Drawing.Point(18, 222);
            this.btnPhieuDangMo.Name = "btnPhieuDangMo";
            this.btnPhieuDangMo.Size = new System.Drawing.Size(266, 35);
            this.btnPhieuDangMo.TabIndex = 8;
            this.btnPhieuDangMo.Text = "Phiếu Đang Mở";
            this.btnPhieuDangMo.UseVisualStyleBackColor = true;
            this.btnPhieuDangMo.Click += new System.EventHandler(this.btnPhieuDangMo_Click);
            // 
            // btnCapNhatTrangThaiPhieu
            // 
            this.btnCapNhatTrangThaiPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTrangThaiPhieu.Location = new System.Drawing.Point(398, 71);
            this.btnCapNhatTrangThaiPhieu.Name = "btnCapNhatTrangThaiPhieu";
            this.btnCapNhatTrangThaiPhieu.Size = new System.Drawing.Size(328, 35);
            this.btnCapNhatTrangThaiPhieu.TabIndex = 3;
            this.btnCapNhatTrangThaiPhieu.Text = "Cập Nhật Thông Tin";
            this.btnCapNhatTrangThaiPhieu.UseVisualStyleBackColor = true;
            this.btnCapNhatTrangThaiPhieu.Click += new System.EventHandler(this.btnCapNhatTrangThaiPhieu_Click);
            // 
            // dtpickerNgayDuKienTra
            // 
            this.dtpickerNgayDuKienTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpickerNgayDuKienTra.CustomFormat = "dd-MM-yyyy";
            this.dtpickerNgayDuKienTra.Enabled = false;
            this.dtpickerNgayDuKienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNgayDuKienTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerNgayDuKienTra.Location = new System.Drawing.Point(206, 132);
            this.dtpickerNgayDuKienTra.Name = "dtpickerNgayDuKienTra";
            this.dtpickerNgayDuKienTra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpickerNgayDuKienTra.Size = new System.Drawing.Size(104, 23);
            this.dtpickerNgayDuKienTra.TabIndex = 71;
            // 
            // dtpickerNgayTra
            // 
            this.dtpickerNgayTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpickerNgayTra.CustomFormat = "dd-MM-yyyy";
            this.dtpickerNgayTra.Enabled = false;
            this.dtpickerNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerNgayTra.Location = new System.Drawing.Point(206, 156);
            this.dtpickerNgayTra.Name = "dtpickerNgayTra";
            this.dtpickerNgayTra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpickerNgayTra.Size = new System.Drawing.Size(104, 23);
            this.dtpickerNgayTra.TabIndex = 70;
            // 
            // dtpickerNgayMuon
            // 
            this.dtpickerNgayMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpickerNgayMuon.CustomFormat = "dd-MM-yyyy";
            this.dtpickerNgayMuon.Enabled = false;
            this.dtpickerNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerNgayMuon.Location = new System.Drawing.Point(206, 103);
            this.dtpickerNgayMuon.Name = "dtpickerNgayMuon";
            this.dtpickerNgayMuon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpickerNgayMuon.Size = new System.Drawing.Size(104, 23);
            this.dtpickerNgayMuon.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tên Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTimNam);
            this.groupBox1.Controls.Add(this.txtTimThang);
            this.groupBox1.Controls.Add(this.btnTimThoiGianTao);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTimNgay);
            this.groupBox1.Controls.Add(this.btnTimTheoTen);
            this.groupBox1.Controls.Add(this.btnTimTheoMa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTimMaPhieu);
            this.groupBox1.Controls.Add(this.txtTimPhieuTheoTen);
            this.groupBox1.Location = new System.Drawing.Point(389, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 113);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(212, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 17);
            this.label14.TabIndex = 85;
            this.label14.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(163, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 84;
            this.label13.Text = "-";
            // 
            // txtTimNam
            // 
            this.txtTimNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNam.Location = new System.Drawing.Point(228, 85);
            this.txtTimNam.Name = "txtTimNam";
            this.txtTimNam.Size = new System.Drawing.Size(45, 23);
            this.txtTimNam.TabIndex = 83;
            this.txtTimNam.Tag = "";
            this.txtTimNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimNam.Click += new System.EventHandler(this.txtTimNam_Click);
            // 
            // txtTimThang
            // 
            this.txtTimThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimThang.Location = new System.Drawing.Point(177, 85);
            this.txtTimThang.Name = "txtTimThang";
            this.txtTimThang.Size = new System.Drawing.Size(32, 23);
            this.txtTimThang.TabIndex = 82;
            this.txtTimThang.Tag = "";
            this.txtTimThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimThang.Click += new System.EventHandler(this.txtTimThang_Click);
            // 
            // btnTimThoiGianTao
            // 
            this.btnTimThoiGianTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimThoiGianTao.Location = new System.Drawing.Point(293, 84);
            this.btnTimThoiGianTao.Name = "btnTimThoiGianTao";
            this.btnTimThoiGianTao.Size = new System.Drawing.Size(44, 23);
            this.btnTimThoiGianTao.TabIndex = 80;
            this.btnTimThoiGianTao.Text = "Tìm";
            this.btnTimThoiGianTao.UseVisualStyleBackColor = true;
            this.btnTimThoiGianTao.Click += new System.EventHandler(this.btnTimThoiGianTao_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 81;
            this.label12.Text = "Ngày Tạo :";
            // 
            // txtTimNgay
            // 
            this.txtTimNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNgay.Location = new System.Drawing.Point(129, 85);
            this.txtTimNgay.Name = "txtTimNgay";
            this.txtTimNgay.Size = new System.Drawing.Size(32, 23);
            this.txtTimNgay.TabIndex = 79;
            this.txtTimNgay.Tag = "";
            this.txtTimNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimNgay.Click += new System.EventHandler(this.txtTimNgay_Click);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoTen.Location = new System.Drawing.Point(293, 59);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(44, 23);
            this.btnTimTheoTen.TabIndex = 7;
            this.btnTimTheoTen.Text = "Tìm";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // btnTimTheoMa
            // 
            this.btnTimTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoMa.Location = new System.Drawing.Point(292, 34);
            this.btnTimTheoMa.Name = "btnTimTheoMa";
            this.btnTimTheoMa.Size = new System.Drawing.Size(45, 23);
            this.btnTimTheoMa.TabIndex = 5;
            this.btnTimTheoMa.Text = "Tìm";
            this.btnTimTheoMa.UseVisualStyleBackColor = true;
            this.btnTimTheoMa.Click += new System.EventHandler(this.btnTimTheoMa_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Tên Đọc Giả:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Mã Phiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tìm Phiếu ";
            // 
            // txtTimMaPhieu
            // 
            this.txtTimMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaPhieu.Location = new System.Drawing.Point(129, 34);
            this.txtTimMaPhieu.Name = "txtTimMaPhieu";
            this.txtTimMaPhieu.Size = new System.Drawing.Size(144, 23);
            this.txtTimMaPhieu.TabIndex = 4;
            // 
            // txtTrangThaiPhieu
            // 
            this.txtTrangThaiPhieu.Enabled = false;
            this.txtTrangThaiPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThaiPhieu.Location = new System.Drawing.Point(183, 188);
            this.txtTrangThaiPhieu.Name = "txtTrangThaiPhieu";
            this.txtTrangThaiPhieu.Size = new System.Drawing.Size(171, 23);
            this.txtTrangThaiPhieu.TabIndex = 24;
            this.txtTrangThaiPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Trạng Thái Phiếu ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dự Kiến Trả";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(137, 71);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(246, 23);
            this.txtTenSach.TabIndex = 18;
            this.txtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày Mượn";
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Enabled = false;
            this.txtTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDocGia.Location = new System.Drawing.Point(137, 42);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(246, 23);
            this.txtTenDocGia.TabIndex = 14;
            this.txtTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Enabled = false;
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(137, 13);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(246, 23);
            this.txtMaPhieuMuon.TabIndex = 13;
            this.txtMaPhieuMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đọc Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Phiếu Mượn";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Trả Sách";
            this.columnHeader6.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Phiếu Mượn Sách";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu Mượn";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đọc Giả";
            this.columnHeader2.Width = 216;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Mượn";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dự Kiến Trả";
            this.columnHeader5.Width = 150;
            // 
            // lvDSPhieuMuon
            // 
            this.lvDSPhieuMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDSPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvDSPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSPhieuMuon.FullRowSelect = true;
            this.lvDSPhieuMuon.GridLines = true;
            this.lvDSPhieuMuon.HideSelection = false;
            this.lvDSPhieuMuon.Location = new System.Drawing.Point(0, 304);
            this.lvDSPhieuMuon.Name = "lvDSPhieuMuon";
            this.lvDSPhieuMuon.Size = new System.Drawing.Size(737, 210);
            this.lvDSPhieuMuon.TabIndex = 15;
            this.lvDSPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lvDSPhieuMuon.View = System.Windows.Forms.View.Details;
            this.lvDSPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.lvDSPhieuMuon_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sách";
            this.columnHeader3.Width = 103;
            // 
            // errorTimMaPhieu
            // 
            this.errorTimMaPhieu.ContainerControl = this;
            // 
            // errorTimTenDocGia
            // 
            this.errorTimTenDocGia.ContainerControl = this;
            // 
            // errorNgay
            // 
            this.errorNgay.ContainerControl = this;
            // 
            // errorThang
            // 
            this.errorThang.ContainerControl = this;
            // 
            // errorNam
            // 
            this.errorNam.ContainerControl = this;
            // 
            // FrmPhieuMuonSachQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 514);
            this.Controls.Add(this.GrBChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDSPhieuMuon);
            this.Name = "FrmPhieuMuonSachQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Mượn Sách";
            this.Load += new System.EventHandler(this.FrmPhieuMuonSachQL_Load);
            this.GrBChiTiet.ResumeLayout(false);
            this.GrBChiTiet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimMaPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTimTenDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPMSDong;
        private System.Windows.Forms.Button BtnPMSMo;
        private System.Windows.Forms.TextBox txtTimPhieuTheoTen;
        private System.Windows.Forms.GroupBox GrBChiTiet;
        private System.Windows.Forms.TextBox txtTrangThaiPhieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimMaPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvDSPhieuMuon;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpickerNgayDuKienTra;
        private System.Windows.Forms.DateTimePicker dtpickerNgayTra;
        private System.Windows.Forms.DateTimePicker dtpickerNgayMuon;
        private System.Windows.Forms.Button btnCapNhatTrangThaiPhieu;
        private System.Windows.Forms.Button BtnXemTatCa;
        private System.Windows.Forms.Button btnPhieuDaDong;
        private System.Windows.Forms.Button btnPhieuDangMo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.Button btnTimTheoMa;
        private System.Windows.Forms.ErrorProvider errorTimMaPhieu;
        private System.Windows.Forms.ErrorProvider errorTimTenDocGia;
        private System.Windows.Forms.Button btnTimThoiGianTao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimNgay;
        private System.Windows.Forms.TextBox txtTimNam;
        private System.Windows.Forms.TextBox txtTimThang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorNgay;
        private System.Windows.Forms.ErrorProvider errorThang;
        private System.Windows.Forms.ErrorProvider errorNam;
    }
}