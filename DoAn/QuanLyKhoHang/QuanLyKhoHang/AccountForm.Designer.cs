﻿namespace QuanLyKhoHang
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
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // accountUserNameTxt
            // 
            this.accountUserNameTxt.Location = new System.Drawing.Point(20, 31);
            this.accountUserNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountUserNameTxt.Name = "accountUserNameTxt";
            this.accountUserNameTxt.Size = new System.Drawing.Size(152, 22);
            this.accountUserNameTxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountPasswordTxt
            // 
            this.accountPasswordTxt.Location = new System.Drawing.Point(20, 79);
            this.accountPasswordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountPasswordTxt.Name = "accountPasswordTxt";
            this.accountPasswordTxt.Size = new System.Drawing.Size(152, 22);
            this.accountPasswordTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // accountLbEmployeeCode
            // 
            this.accountLbEmployeeCode.AutoSize = true;
            this.accountLbEmployeeCode.Location = new System.Drawing.Point(181, 39);
            this.accountLbEmployeeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountLbEmployeeCode.Name = "accountLbEmployeeCode";
            this.accountLbEmployeeCode.Size = new System.Drawing.Size(44, 16);
            this.accountLbEmployeeCode.TabIndex = 6;
            this.accountLbEmployeeCode.Text = "label4";
            // 
            // accountLbEmployeeDuty
            // 
            this.accountLbEmployeeDuty.AutoSize = true;
            this.accountLbEmployeeDuty.Location = new System.Drawing.Point(181, 87);
            this.accountLbEmployeeDuty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountLbEmployeeDuty.Name = "accountLbEmployeeDuty";
            this.accountLbEmployeeDuty.Size = new System.Drawing.Size(44, 16);
            this.accountLbEmployeeDuty.TabIndex = 8;
            this.accountLbEmployeeDuty.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Tài Khoản";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 219);
            this.Controls.Add(this.accountLbEmployeeDuty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountLbEmployeeCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountPasswordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accountUserNameTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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