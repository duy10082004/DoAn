namespace QuanLyKhoHang
{
    partial class ExportGoods
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
            this.nhBtnBackward = new System.Windows.Forms.Button();
            this.xhDgvExportGoods = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.xhBtnConfirm = new System.Windows.Forms.Button();
            this.xhBtnDel = new System.Windows.Forms.Button();
            this.xhBtnFix = new System.Windows.Forms.Button();
            this.xhBtnAdd = new System.Windows.Forms.Button();
            this.xhDtImportTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.xhTxtGoodsQuantity = new System.Windows.Forms.TextBox();
            this.xhTxtGoodsType = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.Label();
            this.xhTxtGoodsName = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.xhTxtGoodsCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exportGoodsLbEmployeeCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xhDgvExportGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // nhBtnBackward
            // 
            this.nhBtnBackward.Location = new System.Drawing.Point(835, 538);
            this.nhBtnBackward.Name = "nhBtnBackward";
            this.nhBtnBackward.Size = new System.Drawing.Size(66, 22);
            this.nhBtnBackward.TabIndex = 58;
            this.nhBtnBackward.Text = "TRỞ LẠI";
            this.nhBtnBackward.UseVisualStyleBackColor = true;
            this.nhBtnBackward.Click += new System.EventHandler(this.nhBtnBackward_Click);
            // 
            // xhDgvExportGoods
            // 
            this.xhDgvExportGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xhDgvExportGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.xhDgvExportGoods.Location = new System.Drawing.Point(76, 216);
            this.xhDgvExportGoods.Name = "xhDgvExportGoods";
            this.xhDgvExportGoods.Size = new System.Drawing.Size(649, 301);
            this.xhDgvExportGoods.TabIndex = 57;
            this.xhDgvExportGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xhDgvExportGoods_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "goodsID";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "goodsType";
            this.Column2.HeaderText = "Loại Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "goodsName";
            this.Column3.HeaderText = "Tên Hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "goodsQuantity";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "goodsExportPrice";
            this.Column5.HeaderText = "Giá Bán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "goodsExportTotalPrice";
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "employeeCode";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "exportTime";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "exportInvoiceID";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "NGÀY NHẬP HÀNG";
            // 
            // xhBtnConfirm
            // 
            this.xhBtnConfirm.Location = new System.Drawing.Point(408, 132);
            this.xhBtnConfirm.Name = "xhBtnConfirm";
            this.xhBtnConfirm.Size = new System.Drawing.Size(104, 29);
            this.xhBtnConfirm.TabIndex = 56;
            this.xhBtnConfirm.Text = "XÁC NHẬN";
            this.xhBtnConfirm.UseVisualStyleBackColor = true;
            this.xhBtnConfirm.Click += new System.EventHandler(this.xhBtnConfirm_Click);
            // 
            // xhBtnDel
            // 
            this.xhBtnDel.Location = new System.Drawing.Point(296, 132);
            this.xhBtnDel.Name = "xhBtnDel";
            this.xhBtnDel.Size = new System.Drawing.Size(104, 29);
            this.xhBtnDel.TabIndex = 55;
            this.xhBtnDel.Text = "XÓA";
            this.xhBtnDel.UseVisualStyleBackColor = true;
            this.xhBtnDel.Click += new System.EventHandler(this.xhBtnDel_Click);
            // 
            // xhBtnFix
            // 
            this.xhBtnFix.Location = new System.Drawing.Point(186, 132);
            this.xhBtnFix.Name = "xhBtnFix";
            this.xhBtnFix.Size = new System.Drawing.Size(104, 29);
            this.xhBtnFix.TabIndex = 54;
            this.xhBtnFix.Text = "SỬA";
            this.xhBtnFix.UseVisualStyleBackColor = true;
            this.xhBtnFix.Click += new System.EventHandler(this.xhBtnFix_Click);
            // 
            // xhBtnAdd
            // 
            this.xhBtnAdd.Location = new System.Drawing.Point(76, 132);
            this.xhBtnAdd.Name = "xhBtnAdd";
            this.xhBtnAdd.Size = new System.Drawing.Size(104, 29);
            this.xhBtnAdd.TabIndex = 53;
            this.xhBtnAdd.Text = "THÊM";
            this.xhBtnAdd.UseVisualStyleBackColor = true;
            this.xhBtnAdd.Click += new System.EventHandler(this.xhBtnAdd_Click);
            // 
            // xhDtImportTime
            // 
            this.xhDtImportTime.Location = new System.Drawing.Point(76, 96);
            this.xhDtImportTime.Name = "xhDtImportTime";
            this.xhDtImportTime.Size = new System.Drawing.Size(188, 20);
            this.xhDtImportTime.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "MÃ NHÂN VIÊN";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(534, 25);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(65, 13);
            this.lb1.TabIndex = 47;
            this.lb1.Text = "LOẠI HÀNG";
            // 
            // xhTxtGoodsQuantity
            // 
            this.xhTxtGoodsQuantity.Location = new System.Drawing.Point(537, 96);
            this.xhTxtGoodsQuantity.Name = "xhTxtGoodsQuantity";
            this.xhTxtGoodsQuantity.Size = new System.Drawing.Size(188, 20);
            this.xhTxtGoodsQuantity.TabIndex = 46;
            // 
            // xhTxtGoodsType
            // 
            this.xhTxtGoodsType.Location = new System.Drawing.Point(537, 41);
            this.xhTxtGoodsType.Name = "xhTxtGoodsType";
            this.xhTxtGoodsType.Size = new System.Drawing.Size(188, 20);
            this.xhTxtGoodsType.TabIndex = 44;
            // 
            // tb3
            // 
            this.tb3.AutoSize = true;
            this.tb3.Location = new System.Drawing.Point(536, 77);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(63, 13);
            this.tb3.TabIndex = 43;
            this.tb3.Text = "SỐ LƯỢNG";
            // 
            // xhTxtGoodsName
            // 
            this.xhTxtGoodsName.Location = new System.Drawing.Point(324, 99);
            this.xhTxtGoodsName.Name = "xhTxtGoodsName";
            this.xhTxtGoodsName.Size = new System.Drawing.Size(188, 20);
            this.xhTxtGoodsName.TabIndex = 42;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(321, 77);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(63, 13);
            this.lb2.TabIndex = 41;
            this.lb2.Text = "TÊN HÀNG";
            // 
            // xhTxtGoodsCode
            // 
            this.xhTxtGoodsCode.Location = new System.Drawing.Point(324, 41);
            this.xhTxtGoodsCode.Name = "xhTxtGoodsCode";
            this.xhTxtGoodsCode.Size = new System.Drawing.Size(188, 20);
            this.xhTxtGoodsCode.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "MÃ HÀNG";
            // 
            // exportGoodsLbEmployeeCode
            // 
            this.exportGoodsLbEmployeeCode.AutoSize = true;
            this.exportGoodsLbEmployeeCode.Location = new System.Drawing.Point(73, 41);
            this.exportGoodsLbEmployeeCode.Name = "exportGoodsLbEmployeeCode";
            this.exportGoodsLbEmployeeCode.Size = new System.Drawing.Size(13, 13);
            this.exportGoodsLbEmployeeCode.TabIndex = 59;
            this.exportGoodsLbEmployeeCode.Text = "1";
            // 
            // ExportGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.exportGoodsLbEmployeeCode);
            this.Controls.Add(this.nhBtnBackward);
            this.Controls.Add(this.xhDgvExportGoods);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xhBtnConfirm);
            this.Controls.Add(this.xhBtnDel);
            this.Controls.Add(this.xhBtnFix);
            this.Controls.Add(this.xhBtnAdd);
            this.Controls.Add(this.xhDtImportTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.xhTxtGoodsQuantity);
            this.Controls.Add(this.xhTxtGoodsType);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.xhTxtGoodsName);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.xhTxtGoodsCode);
            this.Controls.Add(this.label1);
            this.Name = "ExportGoods";
            this.Text = "ExportGoods";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportGoods_FormClosed);
            this.Load += new System.EventHandler(this.ExportGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xhDgvExportGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nhBtnBackward;
        private System.Windows.Forms.DataGridView xhDgvExportGoods;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button xhBtnConfirm;
        private System.Windows.Forms.Button xhBtnDel;
        private System.Windows.Forms.Button xhBtnFix;
        private System.Windows.Forms.Button xhBtnAdd;
        private System.Windows.Forms.DateTimePicker xhDtImportTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox xhTxtGoodsQuantity;
        private System.Windows.Forms.TextBox xhTxtGoodsType;
        private System.Windows.Forms.Label tb3;
        private System.Windows.Forms.TextBox xhTxtGoodsName;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox xhTxtGoodsCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label exportGoodsLbEmployeeCode;
    }
}