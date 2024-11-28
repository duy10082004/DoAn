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
            this.dgvInvoice.Location = new System.Drawing.Point(12, 12);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(549, 175);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "invoiceID";
            this.Column1.HeaderText = "MÃ ĐƠN HÀNG";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoiceType";
            this.Column2.HeaderText = "LOẠI ĐƠN HÀNG";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "invoiceTime";
            this.Column3.HeaderText = "NGÀY NHẬP ĐƠN";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "invoiceTotalCost";
            this.Column4.HeaderText = "GIÁ TRỊ HÓA ĐƠN";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "employeeCode";
            this.Column5.HeaderText = "MÃ NHÂN VIÊN NHẬP";
            this.Column5.Name = "Column5";
            // 
            // btnInvoiceBackward
            // 
            this.btnInvoiceBackward.Location = new System.Drawing.Point(12, 410);
            this.btnInvoiceBackward.Name = "btnInvoiceBackward";
            this.btnInvoiceBackward.Size = new System.Drawing.Size(91, 28);
            this.btnInvoiceBackward.TabIndex = 1;
            this.btnInvoiceBackward.Text = "TRỞ LẠI";
            this.btnInvoiceBackward.UseVisualStyleBackColor = true;
            this.btnInvoiceBackward.Click += new System.EventHandler(this.btnInvoiceBackward_Click);
            // 
            // cbbInvoiceSearch
            // 
            this.cbbInvoiceSearch.FormattingEnabled = true;
            this.cbbInvoiceSearch.Location = new System.Drawing.Point(12, 193);
            this.cbbInvoiceSearch.Name = "cbbInvoiceSearch";
            this.cbbInvoiceSearch.Size = new System.Drawing.Size(155, 21);
            this.cbbInvoiceSearch.TabIndex = 2;
            this.cbbInvoiceSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInvoiceSearch
            // 
            this.btnInvoiceSearch.Location = new System.Drawing.Point(12, 220);
            this.btnInvoiceSearch.Name = "btnInvoiceSearch";
            this.btnInvoiceSearch.Size = new System.Drawing.Size(91, 28);
            this.btnInvoiceSearch.TabIndex = 3;
            this.btnInvoiceSearch.Text = "LỌC";
            this.btnInvoiceSearch.UseVisualStyleBackColor = true;
            // 
            // btnInvoiceDetail
            // 
            this.btnInvoiceDetail.Location = new System.Drawing.Point(431, 193);
            this.btnInvoiceDetail.Name = "btnInvoiceDetail";
            this.btnInvoiceDetail.Size = new System.Drawing.Size(130, 28);
            this.btnInvoiceDetail.TabIndex = 4;
            this.btnInvoiceDetail.Text = "CHI TIẾT HÓA ĐƠN";
            this.btnInvoiceDetail.UseVisualStyleBackColor = true;
            this.btnInvoiceDetail.Click += new System.EventHandler(this.btnInvoiceDetail_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btnInvoiceDetail);
            this.Controls.Add(this.btnInvoiceSearch);
            this.Controls.Add(this.cbbInvoiceSearch);
            this.Controls.Add(this.btnInvoiceBackward);
            this.Controls.Add(this.dgvInvoice);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
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