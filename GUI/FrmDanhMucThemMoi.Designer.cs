namespace GUI
{
    partial class FrmDanhMucThemMoi
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDanhMucMoi = new System.Windows.Forms.TextBox();
            this.richNoiDungDanhMucMoi = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDanhMucCapNhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thêm Mới Danh Mục Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nội Dung: ";
            // 
            // txtTenDanhMucMoi
            // 
            this.txtTenDanhMucMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMucMoi.Location = new System.Drawing.Point(126, 40);
            this.txtTenDanhMucMoi.Name = "txtTenDanhMucMoi";
            this.txtTenDanhMucMoi.Size = new System.Drawing.Size(489, 23);
            this.txtTenDanhMucMoi.TabIndex = 20;
            this.txtTenDanhMucMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richNoiDungDanhMucMoi
            // 
            this.richNoiDungDanhMucMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNoiDungDanhMucMoi.Location = new System.Drawing.Point(126, 69);
            this.richNoiDungDanhMucMoi.Name = "richNoiDungDanhMucMoi";
            this.richNoiDungDanhMucMoi.Size = new System.Drawing.Size(489, 101);
            this.richNoiDungDanhMucMoi.TabIndex = 19;
            this.richNoiDungDanhMucMoi.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Danh Mục:";
            // 
            // BtnDanhMucCapNhat
            // 
            this.BtnDanhMucCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDanhMucCapNhat.Location = new System.Drawing.Point(126, 176);
            this.BtnDanhMucCapNhat.Name = "BtnDanhMucCapNhat";
            this.BtnDanhMucCapNhat.Size = new System.Drawing.Size(337, 25);
            this.BtnDanhMucCapNhat.TabIndex = 23;
            this.BtnDanhMucCapNhat.Text = "Thêm Danh Mục";
            this.BtnDanhMucCapNhat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(486, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 25);
            this.button1.TabIndex = 24;
            this.button1.Text = "Hủy Thêm Mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmDanhMucThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDanhMucCapNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenDanhMucMoi);
            this.Controls.Add(this.richNoiDungDanhMucMoi);
            this.Controls.Add(this.label2);
            this.Name = "FrmDanhMucThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Mới Danh Mục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDanhMucMoi;
        private System.Windows.Forms.RichTextBox richNoiDungDanhMucMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDanhMucCapNhat;
        private System.Windows.Forms.Button button1;
    }
}