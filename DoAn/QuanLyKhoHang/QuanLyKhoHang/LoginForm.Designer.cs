namespace QuanLyKhoHang
{
    partial class LoginForm
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
            this.loginTxtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginTxtUserName
            // 
            this.loginTxtUserName.Location = new System.Drawing.Point(20, 31);
            this.loginTxtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTxtUserName.Name = "loginTxtUserName";
            this.loginTxtUserName.Size = new System.Drawing.Size(195, 22);
            this.loginTxtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(20, 111);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(103, 28);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "&Đăng Nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // loginTxtPassword
            // 
            this.loginTxtPassword.Location = new System.Drawing.Point(20, 79);
            this.loginTxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTxtPassword.Name = "loginTxtPassword";
            this.loginTxtPassword.Size = new System.Drawing.Size(195, 22);
            this.loginTxtPassword.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTxtPassword);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTxtUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTxtPassword;
    }
}