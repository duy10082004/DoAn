namespace QuanLyKhoHang
{
    partial class GoodsImport
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
            this.nhDgvImportGoodsList = new System.Windows.Forms.DataGridView();
            this.nhBtnConfirm = new System.Windows.Forms.Button();
            this.nhBtnDel = new System.Windows.Forms.Button();
            this.nhBtnFix = new System.Windows.Forms.Button();
            this.nhBtnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nhDtImportTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nhTxtGoodsImportPrice = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.nhTxtGoodsQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.Label();
            this.nhTxtGoodsName = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.nhTxtGoodsCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nhBtnBackward = new System.Windows.Forms.Button();
            this.goodsImportCbb = new System.Windows.Forms.ComboBox();
            this.importGoodsLbEmployeeCode = new System.Windows.Forms.Label();
            this.nhTxtGoodsSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nhDgvImportGoodsList)).BeginInit();
            this.SuspendLayout();
            // 
            // nhDgvImportGoodsList
            // 
            this.nhDgvImportGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhDgvImportGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.nhDgvImportGoodsList.Location = new System.Drawing.Point(46, 238);
            this.nhDgvImportGoodsList.Name = "nhDgvImportGoodsList";
            this.nhDgvImportGoodsList.Size = new System.Drawing.Size(747, 301);
            this.nhDgvImportGoodsList.TabIndex = 37;
            this.nhDgvImportGoodsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhDgvImportGoodsList_CellClick);
            this.nhDgvImportGoodsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nhBtnConfirm
            // 
            this.nhBtnConfirm.Location = new System.Drawing.Point(412, 152);
            this.nhBtnConfirm.Name = "nhBtnConfirm";
            this.nhBtnConfirm.Size = new System.Drawing.Size(104, 29);
            this.nhBtnConfirm.TabIndex = 36;
            this.nhBtnConfirm.Text = "XÁC NHẬN";
            this.nhBtnConfirm.UseVisualStyleBackColor = true;
            this.nhBtnConfirm.Click += new System.EventHandler(this.nhBtnConfirm_Click);
            // 
            // nhBtnDel
            // 
            this.nhBtnDel.Location = new System.Drawing.Point(300, 152);
            this.nhBtnDel.Name = "nhBtnDel";
            this.nhBtnDel.Size = new System.Drawing.Size(104, 29);
            this.nhBtnDel.TabIndex = 35;
            this.nhBtnDel.Text = "XÓA";
            this.nhBtnDel.UseVisualStyleBackColor = true;
            this.nhBtnDel.Click += new System.EventHandler(this.nhBtnDel_Click);
            // 
            // nhBtnFix
            // 
            this.nhBtnFix.Location = new System.Drawing.Point(190, 152);
            this.nhBtnFix.Name = "nhBtnFix";
            this.nhBtnFix.Size = new System.Drawing.Size(104, 29);
            this.nhBtnFix.TabIndex = 34;
            this.nhBtnFix.Text = "SỬA";
            this.nhBtnFix.UseVisualStyleBackColor = true;
            this.nhBtnFix.Click += new System.EventHandler(this.nhBtnFix_Click);
            // 
            // nhBtnAdd
            // 
            this.nhBtnAdd.Location = new System.Drawing.Point(80, 152);
            this.nhBtnAdd.Name = "nhBtnAdd";
            this.nhBtnAdd.Size = new System.Drawing.Size(104, 29);
            this.nhBtnAdd.TabIndex = 33;
            this.nhBtnAdd.Text = "THÊM";
            this.nhBtnAdd.UseVisualStyleBackColor = true;
            this.nhBtnAdd.Click += new System.EventHandler(this.nhBtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "NGÀY NHẬP HÀNG";
            // 
            // nhDtImportTime
            // 
            this.nhDtImportTime.Location = new System.Drawing.Point(80, 116);
            this.nhDtImportTime.Name = "nhDtImportTime";
            this.nhDtImportTime.Size = new System.Drawing.Size(188, 20);
            this.nhDtImportTime.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "MÃ NHÂN VIÊN";
            // 
            // nhTxtGoodsImportPrice
            // 
            this.nhTxtGoodsImportPrice.Location = new System.Drawing.Point(541, 161);
            this.nhTxtGoodsImportPrice.Name = "nhTxtGoodsImportPrice";
            this.nhTxtGoodsImportPrice.Size = new System.Drawing.Size(188, 20);
            this.nhTxtGoodsImportPrice.TabIndex = 28;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(538, 45);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(65, 13);
            this.lb1.TabIndex = 27;
            this.lb1.Text = "LOẠI HÀNG";
            // 
            // nhTxtGoodsQuantity
            // 
            this.nhTxtGoodsQuantity.Location = new System.Drawing.Point(541, 116);
            this.nhTxtGoodsQuantity.Name = "nhTxtGoodsQuantity";
            this.nhTxtGoodsQuantity.Size = new System.Drawing.Size(188, 20);
            this.nhTxtGoodsQuantity.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "GIÁ NHẬP";
            // 
            // tb3
            // 
            this.tb3.AutoSize = true;
            this.tb3.Location = new System.Drawing.Point(540, 97);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(63, 13);
            this.tb3.TabIndex = 23;
            this.tb3.Text = "SỐ LƯỢNG";
            // 
            // nhTxtGoodsName
            // 
            this.nhTxtGoodsName.Location = new System.Drawing.Point(328, 116);
            this.nhTxtGoodsName.Name = "nhTxtGoodsName";
            this.nhTxtGoodsName.Size = new System.Drawing.Size(188, 20);
            this.nhTxtGoodsName.TabIndex = 22;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(325, 97);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(63, 13);
            this.lb2.TabIndex = 21;
            this.lb2.Text = "TÊN HÀNG";
            // 
            // nhTxtGoodsCode
            // 
            this.nhTxtGoodsCode.Location = new System.Drawing.Point(328, 61);
            this.nhTxtGoodsCode.Name = "nhTxtGoodsCode";
            this.nhTxtGoodsCode.Size = new System.Drawing.Size(188, 20);
            this.nhTxtGoodsCode.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "MÃ HÀNG";
            // 
            // nhBtnBackward
            // 
            this.nhBtnBackward.Location = new System.Drawing.Point(778, 545);
            this.nhBtnBackward.Name = "nhBtnBackward";
            this.nhBtnBackward.Size = new System.Drawing.Size(66, 22);
            this.nhBtnBackward.TabIndex = 38;
            this.nhBtnBackward.Text = "TRỞ LẠI";
            this.nhBtnBackward.UseVisualStyleBackColor = true;
            this.nhBtnBackward.Click += new System.EventHandler(this.nhBtnBackward_Click);
            // 
            // goodsImportCbb
            // 
            this.goodsImportCbb.FormattingEnabled = true;
            this.goodsImportCbb.Location = new System.Drawing.Point(541, 61);
            this.goodsImportCbb.Name = "goodsImportCbb";
            this.goodsImportCbb.Size = new System.Drawing.Size(188, 21);
            this.goodsImportCbb.TabIndex = 39;
            // 
            // importGoodsLbEmployeeCode
            // 
            this.importGoodsLbEmployeeCode.AutoSize = true;
            this.importGoodsLbEmployeeCode.Location = new System.Drawing.Point(83, 66);
            this.importGoodsLbEmployeeCode.Name = "importGoodsLbEmployeeCode";
            this.importGoodsLbEmployeeCode.Size = new System.Drawing.Size(35, 13);
            this.importGoodsLbEmployeeCode.TabIndex = 40;
            this.importGoodsLbEmployeeCode.Text = "label2";
            // 
            // nhTxtGoodsSupplier
            // 
            this.nhTxtGoodsSupplier.Location = new System.Drawing.Point(541, 209);
            this.nhTxtGoodsSupplier.Name = "nhTxtGoodsSupplier";
            this.nhTxtGoodsSupplier.Size = new System.Drawing.Size(188, 20);
            this.nhTxtGoodsSupplier.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nhà Cung Cấp";
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
            // Column10
            // 
            this.Column10.DataPropertyName = "nhGoodsSupplier";
            this.Column10.HeaderText = "Nhà Cung Cấp ";
            this.Column10.Name = "Column10";
            // 
            // GoodsImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 579);
            this.Controls.Add(this.nhTxtGoodsSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importGoodsLbEmployeeCode);
            this.Controls.Add(this.goodsImportCbb);
            this.Controls.Add(this.nhBtnBackward);
            this.Controls.Add(this.nhDgvImportGoodsList);
            this.Controls.Add(this.nhBtnConfirm);
            this.Controls.Add(this.nhBtnDel);
            this.Controls.Add(this.nhBtnFix);
            this.Controls.Add(this.nhBtnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nhDtImportTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nhTxtGoodsImportPrice);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.nhTxtGoodsQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.nhTxtGoodsName);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.nhTxtGoodsCode);
            this.Controls.Add(this.label1);
            this.Name = "GoodsImport";
            this.Text = "GoodsImport";
            this.Load += new System.EventHandler(this.GoodsImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhDgvImportGoodsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView nhDgvImportGoodsList;
        private System.Windows.Forms.Button nhBtnConfirm;
        private System.Windows.Forms.Button nhBtnDel;
        private System.Windows.Forms.Button nhBtnFix;
        private System.Windows.Forms.Button nhBtnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker nhDtImportTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nhTxtGoodsImportPrice;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox nhTxtGoodsQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tb3;
        private System.Windows.Forms.TextBox nhTxtGoodsName;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox nhTxtGoodsCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nhBtnBackward;
        private System.Windows.Forms.ComboBox goodsImportCbb;
        private System.Windows.Forms.Label importGoodsLbEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox nhTxtGoodsSupplier;
        private System.Windows.Forms.Label label2;
    }
}