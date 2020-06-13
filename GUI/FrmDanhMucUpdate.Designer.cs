﻿namespace GUI
{
    partial class FrmDanhMucUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.richNoiDungDM = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ErrorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenDanhMuc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoiDung = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh Sửa Danh Mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(148, 74);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(245, 20);
            this.txtMa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Danh Mục : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội Dung :";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(148, 105);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(245, 20);
            this.txtTenDM.TabIndex = 2;
            // 
            // richNoiDungDM
            // 
            this.richNoiDungDM.Location = new System.Drawing.Point(148, 147);
            this.richNoiDungDM.Name = "richNoiDungDM";
            this.richNoiDungDM.Size = new System.Drawing.Size(245, 95);
            this.richNoiDungDM.TabIndex = 3;
            this.richNoiDungDM.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Chỉnh Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(303, 282);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ErrorID
            // 
            this.ErrorID.ContainerControl = this;
            // 
            // errorTenDanhMuc
            // 
            this.errorTenDanhMuc.ContainerControl = this;
            // 
            // errorNoiDung
            // 
            this.errorNoiDung.ContainerControl = this;
            // 
            // FrmDanhMucUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 346);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.richNoiDungDM);
            this.Controls.Add(this.txtTenDM);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhMucUpdate";
            this.Text = "FrmDanhMucUpdate";
            this.Load += new System.EventHandler(this.FrmDanhMucUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.RichTextBox richNoiDungDM;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider ErrorID;
        private System.Windows.Forms.ErrorProvider errorTenDanhMuc;
        private System.Windows.Forms.ErrorProvider errorNoiDung;
    }
}