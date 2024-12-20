namespace QuanLyKhoHang
{
    partial class InvoiceForm
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
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInvoiceBackward = new System.Windows.Forms.Button();
            this.cbbInvoiceSearch = new System.Windows.Forms.ComboBox();
            this.btnInvoiceSearch = new System.Windows.Forms.Button();
            this.btnInvoiceDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvInvoice.Location = new System.Drawing.Point(16, 15);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.Size = new System.Drawing.Size(732, 215);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "invoiceID";
            this.Column1.HeaderText = "MÃ ĐƠN HÀNG";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceType";
            this.Column2.HeaderText = "LOẠI ĐƠN HÀNG";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "invoiceTime";
            this.Column3.HeaderText = "NGÀY NHẬP ĐƠN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "invoiceTotalCost";
            this.Column4.HeaderText = "GIÁ TRỊ HÓA ĐƠN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "employeeCode";
            this.Column5.HeaderText = "MÃ NHÂN VIÊN NHẬP";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnInvoiceBackward
            // 
            this.btnInvoiceBackward.Location = new System.Drawing.Point(16, 505);
            this.btnInvoiceBackward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvoiceBackward.Name = "btnInvoiceBackward";
            this.btnInvoiceBackward.Size = new System.Drawing.Size(121, 34);
            this.btnInvoiceBackward.TabIndex = 3;
            this.btnInvoiceBackward.Text = "&TRỞ LẠI";
            this.btnInvoiceBackward.UseVisualStyleBackColor = true;
            this.btnInvoiceBackward.Click += new System.EventHandler(this.btnInvoiceBackward_Click);
            // 
            // cbbInvoiceSearch
            // 
            this.cbbInvoiceSearch.FormattingEnabled = true;
            this.cbbInvoiceSearch.Location = new System.Drawing.Point(16, 238);
            this.cbbInvoiceSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbInvoiceSearch.Name = "cbbInvoiceSearch";
            this.cbbInvoiceSearch.Size = new System.Drawing.Size(205, 24);
            this.cbbInvoiceSearch.TabIndex = 0;
            this.cbbInvoiceSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInvoiceSearch
            // 
            this.btnInvoiceSearch.Location = new System.Drawing.Point(16, 271);
            this.btnInvoiceSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvoiceSearch.Name = "btnInvoiceSearch";
            this.btnInvoiceSearch.Size = new System.Drawing.Size(121, 34);
            this.btnInvoiceSearch.TabIndex = 2;
            this.btnInvoiceSearch.Text = "&LỌC";
            this.btnInvoiceSearch.UseVisualStyleBackColor = true;
            this.btnInvoiceSearch.Click += new System.EventHandler(this.btnInvoiceSearch_Click);
            // 
            // btnInvoiceDetail
            // 
            this.btnInvoiceDetail.Location = new System.Drawing.Point(575, 238);
            this.btnInvoiceDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvoiceDetail.Name = "btnInvoiceDetail";
            this.btnInvoiceDetail.Size = new System.Drawing.Size(173, 34);
            this.btnInvoiceDetail.TabIndex = 1;
            this.btnInvoiceDetail.Text = "&CHI TIẾT HÓA ĐƠN";
            this.btnInvoiceDetail.UseVisualStyleBackColor = true;
            this.btnInvoiceDetail.Click += new System.EventHandler(this.btnInvoiceDetail_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.btnInvoiceDetail);
            this.Controls.Add(this.btnInvoiceSearch);
            this.Controls.Add(this.cbbInvoiceSearch);
            this.Controls.Add(this.btnInvoiceBackward);
            this.Controls.Add(this.dgvInvoice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceForm_FormClosed);
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnInvoiceBackward;
        private System.Windows.Forms.ComboBox cbbInvoiceSearch;
        private System.Windows.Forms.Button btnInvoiceSearch;
        private System.Windows.Forms.Button btnInvoiceDetail;
    }
}