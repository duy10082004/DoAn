namespace QuanLyKhoHang
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
            this.SuspendLayout();
            // 
            // adminBtnKhoHang
            // 
            this.adminBtnKhoHang.Location = new System.Drawing.Point(449, 120);
            this.adminBtnKhoHang.Name = "adminBtnKhoHang";
            this.adminBtnKhoHang.Size = new System.Drawing.Size(134, 34);
            this.adminBtnKhoHang.TabIndex = 0;
            this.adminBtnKhoHang.Text = "Kiểm Tra Kho Hàng";
            this.adminBtnKhoHang.UseVisualStyleBackColor = true;
            this.adminBtnKhoHang.Click += new System.EventHandler(this.adminBtnKhoHang_Click);
            // 
            // adminBtnNhapHang
            // 
            this.adminBtnNhapHang.Location = new System.Drawing.Point(449, 160);
            this.adminBtnNhapHang.Name = "adminBtnNhapHang";
            this.adminBtnNhapHang.Size = new System.Drawing.Size(134, 34);
            this.adminBtnNhapHang.TabIndex = 1;
            this.adminBtnNhapHang.Text = "Nhập Hàng";
            this.adminBtnNhapHang.UseVisualStyleBackColor = true;
            this.adminBtnNhapHang.Click += new System.EventHandler(this.adminBtnNhapHang_Click);
            // 
            // adminBtnXuatHang
            // 
            this.adminBtnXuatHang.Location = new System.Drawing.Point(449, 200);
            this.adminBtnXuatHang.Name = "adminBtnXuatHang";
            this.adminBtnXuatHang.Size = new System.Drawing.Size(134, 34);
            this.adminBtnXuatHang.TabIndex = 2;
            this.adminBtnXuatHang.Text = "Xuất Hàng";
            this.adminBtnXuatHang.UseVisualStyleBackColor = true;
            // 
            // adminBtnXemHoaDon
            // 
            this.adminBtnXemHoaDon.Location = new System.Drawing.Point(449, 240);
            this.adminBtnXemHoaDon.Name = "adminBtnXemHoaDon";
            this.adminBtnXemHoaDon.Size = new System.Drawing.Size(134, 34);
            this.adminBtnXemHoaDon.TabIndex = 3;
            this.adminBtnXemHoaDon.Text = "Xem Hóa Đơn";
            this.adminBtnXemHoaDon.UseVisualStyleBackColor = true;
            this.adminBtnXemHoaDon.Click += new System.EventHandler(this.adminBtnXemHoaDon_Click);
            // 
            // adminBtnExit
            // 
            this.adminBtnExit.Location = new System.Drawing.Point(455, 312);
            this.adminBtnExit.Name = "adminBtnExit";
            this.adminBtnExit.Size = new System.Drawing.Size(128, 31);
            this.adminBtnExit.TabIndex = 4;
            this.adminBtnExit.Text = "Thoát";
            this.adminBtnExit.UseVisualStyleBackColor = true;
            this.adminBtnExit.Click += new System.EventHandler(this.adminBtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.adminBtnExit);
            this.Controls.Add(this.adminBtnXemHoaDon);
            this.Controls.Add(this.adminBtnXuatHang);
            this.Controls.Add(this.adminBtnNhapHang);
            this.Controls.Add(this.adminBtnKhoHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminBtnKhoHang;
        private System.Windows.Forms.Button adminBtnNhapHang;
        private System.Windows.Forms.Button adminBtnXuatHang;
        private System.Windows.Forms.Button adminBtnXemHoaDon;
        private System.Windows.Forms.Button adminBtnExit;
    }
}

