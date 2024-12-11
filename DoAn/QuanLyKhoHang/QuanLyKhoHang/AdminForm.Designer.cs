namespace QuanLyKhoHang
{
    partial class AdminForm
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
            this.adminBtnEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminBtnAccount = new System.Windows.Forms.Button();
            this.adminBtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBtnEmployee
            // 
            this.adminBtnEmployee.Location = new System.Drawing.Point(12, 12);
            this.adminBtnEmployee.Name = "adminBtnEmployee";
            this.adminBtnEmployee.Size = new System.Drawing.Size(137, 35);
            this.adminBtnEmployee.TabIndex = 0;
            this.adminBtnEmployee.Text = "Quản Lý Nhân Viên";
            this.adminBtnEmployee.UseVisualStyleBackColor = true;
            this.adminBtnEmployee.Click += new System.EventHandler(this.adminBtnEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quản Lý Mặt Hàng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminBtnAccount
            // 
            this.adminBtnAccount.Location = new System.Drawing.Point(12, 94);
            this.adminBtnAccount.Name = "adminBtnAccount";
            this.adminBtnAccount.Size = new System.Drawing.Size(137, 35);
            this.adminBtnAccount.TabIndex = 2;
            this.adminBtnAccount.Text = "Quản Lý Tài Khoản";
            this.adminBtnAccount.UseVisualStyleBackColor = true;
            this.adminBtnAccount.Click += new System.EventHandler(this.adminBtnAccount_Click);
            // 
            // adminBtnExit
            // 
            this.adminBtnExit.Location = new System.Drawing.Point(220, 355);
            this.adminBtnExit.Name = "adminBtnExit";
            this.adminBtnExit.Size = new System.Drawing.Size(137, 35);
            this.adminBtnExit.TabIndex = 3;
            this.adminBtnExit.Text = "Thoát";
            this.adminBtnExit.UseVisualStyleBackColor = true;
            this.adminBtnExit.Click += new System.EventHandler(this.adminBtnExit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 402);
            this.Controls.Add(this.adminBtnExit);
            this.Controls.Add(this.adminBtnAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminBtnEmployee);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminBtnEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminBtnAccount;
        private System.Windows.Forms.Button adminBtnExit;
    }
}