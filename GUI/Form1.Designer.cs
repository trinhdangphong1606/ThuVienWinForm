namespace GUI
{
    partial class Form1
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
            this.lvSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnHienThiSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSach
            // 
            this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSach.FullRowSelect = true;
            this.lvSach.GridLines = true;
            this.lvSach.HideSelection = false;
            this.lvSach.Location = new System.Drawing.Point(23, 135);
            this.lvSach.Name = "lvSach";
            this.lvSach.Size = new System.Drawing.Size(606, 147);
            this.lvSach.TabIndex = 0;
            this.lvSach.UseCompatibleStateImageBehavior = false;
            this.lvSach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Năm XB";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Danh Mục";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tác Giả";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngôn Ngữ";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nội Dung";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Lượng";
            // 
            // BtnHienThiSach
            // 
            this.BtnHienThiSach.Location = new System.Drawing.Point(101, 70);
            this.BtnHienThiSach.Name = "BtnHienThiSach";
            this.BtnHienThiSach.Size = new System.Drawing.Size(75, 23);
            this.BtnHienThiSach.TabIndex = 1;
            this.BtnHienThiSach.Text = "button1";
            this.BtnHienThiSach.UseVisualStyleBackColor = true;
            this.BtnHienThiSach.Click += new System.EventHandler(this.BtnHienThiSach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHienThiSach);
            this.Controls.Add(this.lvSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button BtnHienThiSach;
    }
}

