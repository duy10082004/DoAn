namespace QuanLyKhoHang
{
    partial class ExportPirceUpdate
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
            this.components = new System.ComponentModel.Container();
            this.exportGoodsPriceUpdateTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.daToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportGoodsPriceUpdateTxt
            // 
            this.exportGoodsPriceUpdateTxt.Location = new System.Drawing.Point(36, 37);
            this.exportGoodsPriceUpdateTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportGoodsPriceUpdateTxt.Name = "exportGoodsPriceUpdateTxt";
            this.exportGoodsPriceUpdateTxt.Size = new System.Drawing.Size(185, 22);
            this.exportGoodsPriceUpdateTxt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daToolStripMenuItem,
            this.adaToolStripMenuItem,
            this.adToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 76);
            // 
            // daToolStripMenuItem
            // 
            this.daToolStripMenuItem.Name = "daToolStripMenuItem";
            this.daToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.daToolStripMenuItem.Text = "da";
            // 
            // adaToolStripMenuItem
            // 
            this.adaToolStripMenuItem.Name = "adaToolStripMenuItem";
            this.adaToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.adaToolStripMenuItem.Text = "ada";
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.adToolStripMenuItem.Text = "ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá Bán";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportPirceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportGoodsPriceUpdateTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExportPirceUpdate";
            this.Text = "ExportPirceUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportPirceUpdate_FormClosed);
            this.Load += new System.EventHandler(this.ExportPirceUpdate_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox exportGoodsPriceUpdateTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}