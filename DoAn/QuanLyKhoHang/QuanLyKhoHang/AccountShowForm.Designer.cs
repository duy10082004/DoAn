namespace QuanLyKhoHang
{
    partial class AccountShowForm
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
            this.accountDgv = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountShowBtnSort = new System.Windows.Forms.Button();
            this.accountShowBtnInf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDgv
            // 
            this.accountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colPassword,
            this.colAccountType,
            this.colEmployeeID});
            this.accountDgv.Location = new System.Drawing.Point(38, 34);
            this.accountDgv.Name = "accountDgv";
            this.accountDgv.Size = new System.Drawing.Size(444, 241);
            this.accountDgv.TabIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "accountUserName";
            this.colUserName.HeaderText = "Tên Tài Khoản";
            this.colUserName.Name = "colUserName";
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "accountPassword";
            this.colPassword.HeaderText = "Mật Khẩu";
            this.colPassword.Name = "colPassword";
            // 
            // colAccountType
            // 
            this.colAccountType.DataPropertyName = "typeOfAccount";
            this.colAccountType.HeaderText = "Loại Tài Khoản";
            this.colAccountType.Name = "colAccountType";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.DataPropertyName = "accountEmployeeID";
            this.colEmployeeID.HeaderText = "Mã Nhân Viên";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // accountShowBtnSort
            // 
            this.accountShowBtnSort.Location = new System.Drawing.Point(519, 61);
            this.accountShowBtnSort.Name = "accountShowBtnSort";
            this.accountShowBtnSort.Size = new System.Drawing.Size(93, 23);
            this.accountShowBtnSort.TabIndex = 2;
            this.accountShowBtnSort.Text = "Lọc";
            this.accountShowBtnSort.UseVisualStyleBackColor = true;
            // 
            // accountShowBtnInf
            // 
            this.accountShowBtnInf.Location = new System.Drawing.Point(38, 281);
            this.accountShowBtnInf.Name = "accountShowBtnInf";
            this.accountShowBtnInf.Size = new System.Drawing.Size(142, 23);
            this.accountShowBtnInf.TabIndex = 3;
            this.accountShowBtnInf.Text = "Thông Tin Tài Khoản";
            this.accountShowBtnInf.UseVisualStyleBackColor = true;
            // 
            // AccountShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 325);
            this.Controls.Add(this.accountShowBtnInf);
            this.Controls.Add(this.accountShowBtnSort);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.accountDgv);
            this.Name = "AccountShowForm";
            this.Text = "AccountShowForm";
            this.Load += new System.EventHandler(this.AccountShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button accountShowBtnSort;
        private System.Windows.Forms.Button accountShowBtnInf;
    }
}