namespace QuanLyKhoHang
{
    partial class AccountForm
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
            this.accountUserNameTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.accountPasswordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accountLbEmployeeCode = new System.Windows.Forms.Label();
            this.accountLbEmployeeDuty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // accountUserNameTxt
            // 
            this.accountUserNameTxt.Location = new System.Drawing.Point(15, 25);
            this.accountUserNameTxt.Name = "accountUserNameTxt";
            this.accountUserNameTxt.Size = new System.Drawing.Size(115, 20);
            this.accountUserNameTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountPasswordTxt
            // 
            this.accountPasswordTxt.Location = new System.Drawing.Point(15, 64);
            this.accountPasswordTxt.Name = "accountPasswordTxt";
            this.accountPasswordTxt.Size = new System.Drawing.Size(115, 20);
            this.accountPasswordTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // accountLbEmployeeCode
            // 
            this.accountLbEmployeeCode.AutoSize = true;
            this.accountLbEmployeeCode.Location = new System.Drawing.Point(136, 32);
            this.accountLbEmployeeCode.Name = "accountLbEmployeeCode";
            this.accountLbEmployeeCode.Size = new System.Drawing.Size(35, 13);
            this.accountLbEmployeeCode.TabIndex = 6;
            this.accountLbEmployeeCode.Text = "label4";
            // 
            // accountLbEmployeeDuty
            // 
            this.accountLbEmployeeDuty.AutoSize = true;
            this.accountLbEmployeeDuty.Location = new System.Drawing.Point(136, 71);
            this.accountLbEmployeeDuty.Name = "accountLbEmployeeDuty";
            this.accountLbEmployeeDuty.Size = new System.Drawing.Size(35, 13);
            this.accountLbEmployeeDuty.TabIndex = 8;
            this.accountLbEmployeeDuty.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Tài Khoản";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 178);
            this.Controls.Add(this.accountLbEmployeeDuty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountLbEmployeeCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountPasswordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accountUserNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountUserNameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox accountPasswordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label accountLbEmployeeCode;
        private System.Windows.Forms.Label accountLbEmployeeDuty;
        private System.Windows.Forms.Label label5;
    }
}