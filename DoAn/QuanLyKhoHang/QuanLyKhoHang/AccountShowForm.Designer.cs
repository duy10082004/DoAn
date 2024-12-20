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
            this.colEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountShowCbb = new System.Windows.Forms.ComboBox();
            this.accountShowBtnSort = new System.Windows.Forms.Button();
            this.accountShowBtnInf = new System.Windows.Forms.Button();
            this.accountShowExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDgv
            // 
            this.accountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeID,
            this.colUserName,
            this.colPassword,
            this.colAccountType});
            this.accountDgv.Location = new System.Drawing.Point(51, 42);
            this.accountDgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountDgv.Name = "accountDgv";
            this.accountDgv.RowHeadersWidth = 51;
            this.accountDgv.Size = new System.Drawing.Size(592, 297);
            this.accountDgv.TabIndex = 0;
            this.accountDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDgv_CellClick);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.DataPropertyName = "accountEmployeeID";
            this.colEmployeeID.HeaderText = "Mã Nhân Viên";
            this.colEmployeeID.MinimumWidth = 6;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Width = 125;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "accountUserName";
            this.colUserName.HeaderText = "Tên Tài Khoản";
            this.colUserName.MinimumWidth = 6;
            this.colUserName.Name = "colUserName";
            this.colUserName.Width = 125;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "accountPassword";
            this.colPassword.HeaderText = "Mật Khẩu";
            this.colPassword.MinimumWidth = 6;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 125;
            // 
            // colAccountType
            // 
            this.colAccountType.DataPropertyName = "typeOfAccount";
            this.colAccountType.HeaderText = "Loại Tài Khoản";
            this.colAccountType.MinimumWidth = 6;
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.Width = 125;
            // 
            // accountShowCbb
            // 
            this.accountShowCbb.FormattingEnabled = true;
            this.accountShowCbb.Location = new System.Drawing.Point(692, 42);
            this.accountShowCbb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountShowCbb.Name = "accountShowCbb";
            this.accountShowCbb.Size = new System.Drawing.Size(199, 24);
            this.accountShowCbb.TabIndex = 1;
            // 
            // accountShowBtnSort
            // 
            this.accountShowBtnSort.Location = new System.Drawing.Point(692, 75);
            this.accountShowBtnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountShowBtnSort.Name = "accountShowBtnSort";
            this.accountShowBtnSort.Size = new System.Drawing.Size(124, 28);
            this.accountShowBtnSort.TabIndex = 2;
            this.accountShowBtnSort.Text = "&Lọc";
            this.accountShowBtnSort.UseVisualStyleBackColor = true;
            this.accountShowBtnSort.Click += new System.EventHandler(this.accountShowBtnSort_Click);
            // 
            // accountShowBtnInf
            // 
            this.accountShowBtnInf.Location = new System.Drawing.Point(51, 346);
            this.accountShowBtnInf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountShowBtnInf.Name = "accountShowBtnInf";
            this.accountShowBtnInf.Size = new System.Drawing.Size(189, 28);
            this.accountShowBtnInf.TabIndex = 0;
            this.accountShowBtnInf.Text = "&Thông Tin Tài Khoản";
            this.accountShowBtnInf.UseVisualStyleBackColor = true;
            this.accountShowBtnInf.Click += new System.EventHandler(this.accountShowBtnInf_Click);
            // 
            // accountShowExit
            // 
            this.accountShowExit.Location = new System.Drawing.Point(815, 357);
            this.accountShowExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountShowExit.Name = "accountShowExit";
            this.accountShowExit.Size = new System.Drawing.Size(100, 28);
            this.accountShowExit.TabIndex = 3;
            this.accountShowExit.Text = "&Thoát";
            this.accountShowExit.UseVisualStyleBackColor = true;
            // 
            // AccountShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 400);
            this.Controls.Add(this.accountShowExit);
            this.Controls.Add(this.accountShowBtnInf);
            this.Controls.Add(this.accountShowBtnSort);
            this.Controls.Add(this.accountShowCbb);
            this.Controls.Add(this.accountDgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountShowForm";
            this.Text = "AccountShowForm";
            this.Load += new System.EventHandler(this.AccountShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountDgv;
        private System.Windows.Forms.ComboBox accountShowCbb;
        private System.Windows.Forms.Button accountShowBtnSort;
        private System.Windows.Forms.Button accountShowBtnInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountType;
        private System.Windows.Forms.Button accountShowExit;
    }
}