﻿namespace QuanLyKhoHang
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
            this.adminBtnKhoHang = new System.Windows.Forms.Button();
            this.adminBtnNhapHang = new System.Windows.Forms.Button();
            this.adminBtnXuatHang = new System.Windows.Forms.Button();
            this.adminBtnXemHoaDon = new System.Windows.Forms.Button();
            this.adminBtnExit = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.formLBMaNhanVien = new System.Windows.Forms.Label();
            this.formLbHoTenNhanVien = new System.Windows.Forms.Label();
            this.formLbChucVu = new System.Windows.Forms.Label();
            this.adminBtnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBtnKhoHang
            // 
            this.adminBtnKhoHang.Location = new System.Drawing.Point(16, 15);
            this.adminBtnKhoHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtnKhoHang.Name = "adminBtnKhoHang";
            this.adminBtnKhoHang.Size = new System.Drawing.Size(179, 42);
            this.adminBtnKhoHang.TabIndex = 0;
            this.adminBtnKhoHang.Text = "&Kiểm Tra Kho Hàng";
            this.adminBtnKhoHang.UseVisualStyleBackColor = true;
            this.adminBtnKhoHang.Click += new System.EventHandler(this.adminBtnKhoHang_Click);
            // 
            // adminBtnNhapHang
            // 
            this.adminBtnNhapHang.Location = new System.Drawing.Point(16, 64);
            this.adminBtnNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtnNhapHang.Name = "adminBtnNhapHang";
            this.adminBtnNhapHang.Size = new System.Drawing.Size(179, 42);
            this.adminBtnNhapHang.TabIndex = 1;
            this.adminBtnNhapHang.Text = "&Nhập Hàng";
            this.adminBtnNhapHang.UseVisualStyleBackColor = true;
            this.adminBtnNhapHang.Click += new System.EventHandler(this.adminBtnNhapHang_Click);
            // 
            // adminBtnXuatHang
            // 
            this.adminBtnXuatHang.Location = new System.Drawing.Point(16, 113);
            this.adminBtnXuatHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtnXuatHang.Name = "adminBtnXuatHang";
            this.adminBtnXuatHang.Size = new System.Drawing.Size(179, 42);
            this.adminBtnXuatHang.TabIndex = 2;
            this.adminBtnXuatHang.Text = "&Xuất Hàng";
            this.adminBtnXuatHang.UseVisualStyleBackColor = true;
            this.adminBtnXuatHang.Click += new System.EventHandler(this.adminBtnXuatHang_Click);
            // 
            // adminBtnXemHoaDon
            // 
            this.adminBtnXemHoaDon.Location = new System.Drawing.Point(16, 162);
            this.adminBtnXemHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtnXemHoaDon.Name = "adminBtnXemHoaDon";
            this.adminBtnXemHoaDon.Size = new System.Drawing.Size(179, 42);
            this.adminBtnXemHoaDon.TabIndex = 3;
            this.adminBtnXemHoaDon.Text = "&Xem Hóa Đơn";
            this.adminBtnXemHoaDon.UseVisualStyleBackColor = true;
            this.adminBtnXemHoaDon.Click += new System.EventHandler(this.adminBtnXemHoaDon_Click);
            // 
            // adminBtnExit
            // 
            this.adminBtnExit.Location = new System.Drawing.Point(16, 261);
            this.adminBtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtnExit.Name = "adminBtnExit";
            this.adminBtnExit.Size = new System.Drawing.Size(179, 38);
            this.adminBtnExit.TabIndex = 5;
            this.adminBtnExit.Text = "&Thoát";
            this.adminBtnExit.UseVisualStyleBackColor = true;
            this.adminBtnExit.Click += new System.EventHandler(this.adminBtnExit_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(16, 212);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(179, 42);
            this.adminBtn.TabIndex = 4;
            this.adminBtn.Text = "&Quản Lý";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtnEmployee_Click);
            // 
            // formLBMaNhanVien
            // 
            this.formLBMaNhanVien.AutoSize = true;
            this.formLBMaNhanVien.Location = new System.Drawing.Point(239, 41);
            this.formLBMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formLBMaNhanVien.Name = "formLBMaNhanVien";
            this.formLBMaNhanVien.Size = new System.Drawing.Size(91, 16);
            this.formLBMaNhanVien.TabIndex = 6;
            this.formLBMaNhanVien.Text = "Ma Nhan Vien";
            // 
            // formLbHoTenNhanVien
            // 
            this.formLbHoTenNhanVien.AutoSize = true;
            this.formLbHoTenNhanVien.Location = new System.Drawing.Point(239, 64);
            this.formLbHoTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formLbHoTenNhanVien.Name = "formLbHoTenNhanVien";
            this.formLbHoTenNhanVien.Size = new System.Drawing.Size(44, 16);
            this.formLbHoTenNhanVien.TabIndex = 7;
            this.formLbHoTenNhanVien.Text = "label2";
            // 
            // formLbChucVu
            // 
            this.formLbChucVu.AutoSize = true;
            this.formLbChucVu.Location = new System.Drawing.Point(239, 90);
            this.formLbChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formLbChucVu.Name = "formLbChucVu";
            this.formLbChucVu.Size = new System.Drawing.Size(44, 16);
            this.formLbChucVu.TabIndex = 8;
            this.formLbChucVu.Text = "label3";
            // 
            // adminBtnLogOut
            // 
            this.adminBtnLogOut.Location = new System.Drawing.Point(243, 261);
            this.adminBtnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtnLogOut.Name = "adminBtnLogOut";
            this.adminBtnLogOut.Size = new System.Drawing.Size(179, 38);
            this.adminBtnLogOut.TabIndex = 6;
            this.adminBtnLogOut.Text = "&Đăng Xuất";
            this.adminBtnLogOut.UseVisualStyleBackColor = true;
            this.adminBtnLogOut.Click += new System.EventHandler(this.adminBtnLogOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 320);
            this.Controls.Add(this.adminBtnLogOut);
            this.Controls.Add(this.formLbChucVu);
            this.Controls.Add(this.formLbHoTenNhanVien);
            this.Controls.Add(this.formLBMaNhanVien);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.adminBtnExit);
            this.Controls.Add(this.adminBtnXemHoaDon);
            this.Controls.Add(this.adminBtnXuatHang);
            this.Controls.Add(this.adminBtnNhapHang);
            this.Controls.Add(this.adminBtnKhoHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminBtnKhoHang;
        private System.Windows.Forms.Button adminBtnNhapHang;
        private System.Windows.Forms.Button adminBtnXuatHang;
        private System.Windows.Forms.Button adminBtnXemHoaDon;
        private System.Windows.Forms.Button adminBtnExit;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Label formLBMaNhanVien;
        private System.Windows.Forms.Label formLbHoTenNhanVien;
        private System.Windows.Forms.Label formLbChucVu;
        private System.Windows.Forms.Button adminBtnLogOut;
    }
}

