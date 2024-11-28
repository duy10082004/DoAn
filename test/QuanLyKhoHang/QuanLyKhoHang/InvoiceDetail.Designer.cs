namespace QuanLyKhoHang
{
    partial class InvoiceDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbInvoiceID = new System.Windows.Forms.Label();
            this.lbInvoiceTime = new System.Windows.Forms.Label();
            this.lbInvoiceType = new System.Windows.Forms.Label();
            this.lbInvoiceTotalCost = new System.Windows.Forms.Label();
            this.lbEmployeeCode = new System.Windows.Forms.Label();
            this.dgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.btnInvoiceDetailBackward = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đơn Hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Nhập Đơn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Trị Hóa Đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Đơn Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Nhân Viên Nhập:";
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.AutoSize = true;
            this.lbInvoiceID.Location = new System.Drawing.Point(122, 23);
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(35, 13);
            this.lbInvoiceID.TabIndex = 5;
            this.lbInvoiceID.Text = "label6";
            // 
            // lbInvoiceTime
            // 
            this.lbInvoiceTime.AutoSize = true;
            this.lbInvoiceTime.Location = new System.Drawing.Point(291, 23);
            this.lbInvoiceTime.Name = "lbInvoiceTime";
            this.lbInvoiceTime.Size = new System.Drawing.Size(35, 13);
            this.lbInvoiceTime.TabIndex = 6;
            this.lbInvoiceTime.Text = "label7";
            // 
            // lbInvoiceType
            // 
            this.lbInvoiceType.AutoSize = true;
            this.lbInvoiceType.Location = new System.Drawing.Point(522, 23);
            this.lbInvoiceType.Name = "lbInvoiceType";
            this.lbInvoiceType.Size = new System.Drawing.Size(35, 13);
            this.lbInvoiceType.TabIndex = 7;
            this.lbInvoiceType.Text = "label8";
            // 
            // lbInvoiceTotalCost
            // 
            this.lbInvoiceTotalCost.AutoSize = true;
            this.lbInvoiceTotalCost.Location = new System.Drawing.Point(684, 23);
            this.lbInvoiceTotalCost.Name = "lbInvoiceTotalCost";
            this.lbInvoiceTotalCost.Size = new System.Drawing.Size(35, 13);
            this.lbInvoiceTotalCost.TabIndex = 8;
            this.lbInvoiceTotalCost.Text = "label9";
            // 
            // lbEmployeeCode
            // 
            this.lbEmployeeCode.AutoSize = true;
            this.lbEmployeeCode.Location = new System.Drawing.Point(149, 73);
            this.lbEmployeeCode.Name = "lbEmployeeCode";
            this.lbEmployeeCode.Size = new System.Drawing.Size(35, 13);
            this.lbEmployeeCode.TabIndex = 9;
            this.lbEmployeeCode.Text = "label6";
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(39, 116);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(646, 301);
            this.dgvInvoiceDetail.TabIndex = 38;
            this.dgvInvoiceDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetail_CellContentClick);
            // 
            // btnInvoiceDetailBackward
            // 
            this.btnInvoiceDetailBackward.Location = new System.Drawing.Point(668, 426);
            this.btnInvoiceDetailBackward.Name = "btnInvoiceDetailBackward";
            this.btnInvoiceDetailBackward.Size = new System.Drawing.Size(82, 23);
            this.btnInvoiceDetailBackward.TabIndex = 39;
            this.btnInvoiceDetailBackward.Text = "TRỞ LẠI";
            this.btnInvoiceDetailBackward.UseVisualStyleBackColor = true;
            this.btnInvoiceDetailBackward.Click += new System.EventHandler(this.btnInvoiceDetailBackward_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nhGoodsCode";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nhGoodsType";
            this.Column2.HeaderText = "Loại Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nhGoodsName";
            this.Column3.HeaderText = "Tên Hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nhGoodsQuantity";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nhGoodsImportPrice";
            this.Column5.HeaderText = "Giá Nhập";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nhTotalGoodsImportPrice";
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nhEmployeeCode";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "nhImportTime";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "nhImportOderCode";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 461);
            this.Controls.Add(this.btnInvoiceDetailBackward);
            this.Controls.Add(this.dgvInvoiceDetail);
            this.Controls.Add(this.lbEmployeeCode);
            this.Controls.Add(this.lbInvoiceTotalCost);
            this.Controls.Add(this.lbInvoiceType);
            this.Controls.Add(this.lbInvoiceTime);
            this.Controls.Add(this.lbInvoiceID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceDetail";
            this.Text = "InvoiceDetail";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbInvoiceID;
        private System.Windows.Forms.Label lbInvoiceTime;
        private System.Windows.Forms.Label lbInvoiceType;
        private System.Windows.Forms.Label lbInvoiceTotalCost;
        private System.Windows.Forms.Label lbEmployeeCode;
        private System.Windows.Forms.DataGridView dgvInvoiceDetail;
        private System.Windows.Forms.Button btnInvoiceDetailBackward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}