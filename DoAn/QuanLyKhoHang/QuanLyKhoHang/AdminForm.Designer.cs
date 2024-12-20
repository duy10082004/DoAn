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
            this.adminBtnEmployee.Location = new System.Drawing.Point(16, 15);
            this.adminBtnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtnEmployee.Name = "adminBtnEmployee";
            this.adminBtnEmployee.Size = new System.Drawing.Size(183, 43);
            this.adminBtnEmployee.TabIndex = 0;
            this.adminBtnEmployee.Text = "&Quản Lý Nhân Viên";
            this.adminBtnEmployee.UseVisualStyleBackColor = true;
            this.adminBtnEmployee.Click += new System.EventHandler(this.adminBtnEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Quản Lý Mặt Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminBtnAccount
            // 
            this.adminBtnAccount.Location = new System.Drawing.Point(16, 116);
            this.adminBtnAccount.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtnAccount.Name = "adminBtnAccount";
            this.adminBtnAccount.Size = new System.Drawing.Size(183, 43);
            this.adminBtnAccount.TabIndex = 2;
            this.adminBtnAccount.Text = "&Quản Lý Tài Khoản";
            this.adminBtnAccount.UseVisualStyleBackColor = true;
            this.adminBtnAccount.Click += new System.EventHandler(this.adminBtnAccount_Click);
            // 
            // adminBtnExit
            // 
            this.adminBtnExit.Location = new System.Drawing.Point(293, 437);
            this.adminBtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtnExit.Name = "adminBtnExit";
            this.adminBtnExit.Size = new System.Drawing.Size(183, 43);
            this.adminBtnExit.TabIndex = 3;
            this.adminBtnExit.Text = "&Thoát";
            this.adminBtnExit.UseVisualStyleBackColor = true;
            this.adminBtnExit.Click += new System.EventHandler(this.adminBtnExit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 495);
            this.Controls.Add(this.adminBtnExit);
            this.Controls.Add(this.adminBtnAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminBtnEmployee);
            this.Margin = new System.Windows.Forms.Padding(4);
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