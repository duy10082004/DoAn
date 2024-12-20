namespace QuanLyKhoHang
{
    partial class Account_MH
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
            this.txtNewGoodsType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewSupplier = new System.Windows.Forms.TextBox();
            this.btnAddGoodsType = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewGoodsType
            // 
            this.txtNewGoodsType.Location = new System.Drawing.Point(159, 76);
            this.txtNewGoodsType.Name = "txtNewGoodsType";
            this.txtNewGoodsType.Size = new System.Drawing.Size(130, 22);
            this.txtNewGoodsType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // txtNewSupplier
            // 
            this.txtNewSupplier.Location = new System.Drawing.Point(159, 122);
            this.txtNewSupplier.Name = "txtNewSupplier";
            this.txtNewSupplier.Size = new System.Drawing.Size(130, 22);
            this.txtNewSupplier.TabIndex = 1;
            // 
            // btnAddGoodsType
            // 
            this.btnAddGoodsType.Location = new System.Drawing.Point(322, 64);
            this.btnAddGoodsType.Name = "btnAddGoodsType";
            this.btnAddGoodsType.Size = new System.Drawing.Size(129, 47);
            this.btnAddGoodsType.TabIndex = 2;
            this.btnAddGoodsType.Text = "&Thêm Loại Hàng";
            this.btnAddGoodsType.UseVisualStyleBackColor = true;
            this.btnAddGoodsType.Click += new System.EventHandler(this.btnAddGoodsType_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(322, 117);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(129, 41);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.Text = "&Thêm NCC";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account_MH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnAddGoodsType);
            this.Controls.Add(this.txtNewSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewGoodsType);
            this.Name = "Account_MH";
            this.Text = "Account_MH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewGoodsType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewSupplier;
        private System.Windows.Forms.Button btnAddGoodsType;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button button1;
    }
}