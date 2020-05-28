namespace GUI
{
    partial class FrmDanhMucQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrBChiTiet = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCapNhatDanhMuc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LvDanhMucDS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.richNoiDungDanhMuc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrBChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản Lý Danh Mục Thư Viện";
            // 
            // GrBChiTiet
            // 
            this.GrBChiTiet.Controls.Add(this.button4);
            this.GrBChiTiet.Controls.Add(this.button3);
            this.GrBChiTiet.Controls.Add(this.label4);
            this.GrBChiTiet.Controls.Add(this.BtnCapNhatDanhMuc);
            this.GrBChiTiet.Controls.Add(this.label7);
            this.GrBChiTiet.Controls.Add(this.LvDanhMucDS);
            this.GrBChiTiet.Controls.Add(this.txtTenDanhMuc);
            this.GrBChiTiet.Controls.Add(this.richNoiDungDanhMuc);
            this.GrBChiTiet.Controls.Add(this.label3);
            this.GrBChiTiet.Controls.Add(this.label2);
            this.GrBChiTiet.Location = new System.Drawing.Point(12, 42);
            this.GrBChiTiet.Name = "GrBChiTiet";
            this.GrBChiTiet.Size = new System.Drawing.Size(699, 369);
            this.GrBChiTiet.TabIndex = 13;
            this.GrBChiTiet.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(555, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 33);
            this.button4.TabIndex = 28;
            this.button4.Text = "Xóa Danh Mục";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(400, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 33);
            this.button3.TabIndex = 27;
            this.button3.Text = "Thêm Mới Danh Mục";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 15);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Danh Sách Danh Mục";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCapNhatDanhMuc
            // 
            this.BtnCapNhatDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCapNhatDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapNhatDanhMuc.Location = new System.Drawing.Point(110, 311);
            this.BtnCapNhatDanhMuc.Name = "BtnCapNhatDanhMuc";
            this.BtnCapNhatDanhMuc.Size = new System.Drawing.Size(260, 33);
            this.BtnCapNhatDanhMuc.TabIndex = 25;
            this.BtnCapNhatDanhMuc.Text = "Cập Nhật Thông Tin Danh Mục";
            this.BtnCapNhatDanhMuc.UseVisualStyleBackColor = true;
            this.BtnCapNhatDanhMuc.Click += new System.EventHandler(this.BtnCapNhatDanhMuc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Danh Mục";
            // 
            // LvDanhMucDS
            // 
            this.LvDanhMucDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LvDanhMucDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvDanhMucDS.FullRowSelect = true;
            this.LvDanhMucDS.GridLines = true;
            this.LvDanhMucDS.HideSelection = false;
            this.LvDanhMucDS.Location = new System.Drawing.Point(400, 19);
            this.LvDanhMucDS.Margin = new System.Windows.Forms.Padding(4);
            this.LvDanhMucDS.Name = "LvDanhMucDS";
            this.LvDanhMucDS.Size = new System.Drawing.Size(265, 286);
            this.LvDanhMucDS.TabIndex = 10;
            this.LvDanhMucDS.UseCompatibleStateImageBehavior = false;
            this.LvDanhMucDS.View = System.Windows.Forms.View.Details;
            this.LvDanhMucDS.SelectedIndexChanged += new System.EventHandler(this.LvDanhMucDS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Danh Sách Danh Mục";
            this.columnHeader1.Width = 340;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(139, 13);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(192, 23);
            this.txtTenDanhMuc.TabIndex = 13;
            this.txtTenDanhMuc.Text = "Truyện";
            this.txtTenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richNoiDungDanhMuc
            // 
            this.richNoiDungDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNoiDungDanhMuc.Location = new System.Drawing.Point(110, 42);
            this.richNoiDungDanhMuc.Name = "richNoiDungDanhMuc";
            this.richNoiDungDanhMuc.Size = new System.Drawing.Size(260, 263);
            this.richNoiDungDanhMuc.TabIndex = 12;
            this.richNoiDungDanhMuc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
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
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Danh Mục";
            // 
            // FrmDanhMucQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrBChiTiet);
            this.Name = "FrmDanhMucQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhMucQL";
            this.Load += new System.EventHandler(this.FrmDanhMucQL_Load);
            this.GrBChiTiet.ResumeLayout(false);
            this.GrBChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBChiTiet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCapNhatDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LvDanhMucDS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.RichTextBox richNoiDungDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}