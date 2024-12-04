namespace QuanLyKhoHang
{
    partial class QuanLy
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
            this.khBtnExit = new System.Windows.Forms.Button();
            this.dgvQuanLyHangHoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khBtnUpdateExportPrice = new System.Windows.Forms.Button();
            this.khCbbSort = new System.Windows.Forms.ComboBox();
            this.khBtnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // khBtnExit
            // 
            this.khBtnExit.Location = new System.Drawing.Point(663, 409);
            this.khBtnExit.Name = "khBtnExit";
            this.khBtnExit.Size = new System.Drawing.Size(78, 29);
            this.khBtnExit.TabIndex = 1;
            this.khBtnExit.Text = "TRỞ LẠI";
            this.khBtnExit.UseVisualStyleBackColor = true;
            this.khBtnExit.Click += new System.EventHandler(this.khBtnExit_Click);
            // 
            // dgvQuanLyHangHoa
            // 
            this.dgvQuanLyHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvQuanLyHangHoa.Location = new System.Drawing.Point(12, 12);
            this.dgvQuanLyHangHoa.Name = "dgvQuanLyHangHoa";
            this.dgvQuanLyHangHoa.Size = new System.Drawing.Size(645, 426);
            this.dgvQuanLyHangHoa.TabIndex = 2;
            this.dgvQuanLyHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyHangHoa_CellClick);
            this.dgvQuanLyHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyHangHoa_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "hhMaHangHoa";
            this.Column1.HeaderText = "MÃ HÀNG HÓA";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hhTenHangHoa";
            this.Column2.HeaderText = "TÊN HÀNG HÓA";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hhLoaiHangHoa";
            this.Column3.HeaderText = "LOẠI HÀNG HÓA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "hhSoLuong";
            this.Column4.HeaderText = "SỐ LƯỢNG";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "hhGiaNhap";
            this.Column5.HeaderText = "GIÁ NHẬP";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "hhGiaBan";
            this.Column6.HeaderText = "GIÁ BÁN";
            this.Column6.Name = "Column6";
            // 
            // khBtnUpdateExportPrice
            // 
            this.khBtnUpdateExportPrice.Location = new System.Drawing.Point(663, 77);
            this.khBtnUpdateExportPrice.Name = "khBtnUpdateExportPrice";
            this.khBtnUpdateExportPrice.Size = new System.Drawing.Size(152, 32);
            this.khBtnUpdateExportPrice.TabIndex = 3;
            this.khBtnUpdateExportPrice.Text = "Cập Nhật Giá Bán";
            this.khBtnUpdateExportPrice.UseVisualStyleBackColor = true;
            this.khBtnUpdateExportPrice.Click += new System.EventHandler(this.khBtnUpdateExportPrice_Click);
            // 
            // khCbbSort
            // 
            this.khCbbSort.FormattingEnabled = true;
            this.khCbbSort.Location = new System.Drawing.Point(663, 12);
            this.khCbbSort.Name = "khCbbSort";
            this.khCbbSort.Size = new System.Drawing.Size(152, 21);
            this.khCbbSort.TabIndex = 4;
            // 
            // khBtnSort
            // 
            this.khBtnSort.Location = new System.Drawing.Point(663, 39);
            this.khBtnSort.Name = "khBtnSort";
            this.khBtnSort.Size = new System.Drawing.Size(152, 32);
            this.khBtnSort.TabIndex = 5;
            this.khBtnSort.Text = "Lọc";
            this.khBtnSort.UseVisualStyleBackColor = true;
            this.khBtnSort.Click += new System.EventHandler(this.khBtnSort_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.khBtnSort);
            this.Controls.Add(this.khCbbSort);
            this.Controls.Add(this.khBtnUpdateExportPrice);
            this.Controls.Add(this.dgvQuanLyHangHoa);
            this.Controls.Add(this.khBtnExit);
            this.Name = "QuanLy";
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button khBtnExit;
        private System.Windows.Forms.DataGridView dgvQuanLyHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button khBtnUpdateExportPrice;
        private System.Windows.Forms.ComboBox khCbbSort;
        private System.Windows.Forms.Button khBtnSort;
    }
}