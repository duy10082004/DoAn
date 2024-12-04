using QuanLyKhoHang.Global_Variable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class InvoiceDetail : Form
    {
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            lbInvoiceID.Text = GlobalVariable.fakeInvoice.InvoiceID;
            lbEmployeeCode.Text = GlobalVariable.fakeInvoice.EmployeeCode;
            lbInvoiceTime.Text =   GlobalVariable.fakeInvoice.InvoiceTime.ToString();
            lbInvoiceType.Text = GlobalVariable.fakeInvoice.InVoiceType;
            lbInvoiceTotalCost.Text = GlobalVariable.fakeInvoice.InvoiceTotalCost.ToString();
            GlobalVariable.invoiceDetail();
            if (GlobalVariable.fakeInvoice.InVoiceType == "Đơn Nhập")
            {
               
                dgvInvoiceDetail.DataSource = GlobalVariable.fakeListImportGoods;
            }
            else
            {
                dgvInvoiceDetail.Columns[0].DataPropertyName = "goodsID";
                dgvInvoiceDetail.Columns[1].DataPropertyName = "goodsType";
                dgvInvoiceDetail.Columns[2].DataPropertyName = "goodsName";
                dgvInvoiceDetail.Columns[3].DataPropertyName = "goodsQuantity";
                dgvInvoiceDetail.Columns[4].DataPropertyName = "goodsExportPrice";
                dgvInvoiceDetail.Columns[5].DataPropertyName = "goodsExportTotalPrice";
                dgvInvoiceDetail.Columns[6].DataPropertyName = "EmployeeCode";
                dgvInvoiceDetail.Columns[7].DataPropertyName = "ExportInvoiceID";
                dgvInvoiceDetail.Columns[8].DataPropertyName = "ExportTime";
                dgvInvoiceDetail.Columns[6].Visible = false;
                dgvInvoiceDetail.Columns[7].Visible = false;
                dgvInvoiceDetail.Columns[8].Visible = false;

                dgvInvoiceDetail.DataSource = GlobalVariable.fakeExportGoodsList;
            }

        }

        private void btnInvoiceDetailBackward_Click(object sender, EventArgs e)
        {
            GlobalVariable.fakeInvoice = null ;
            GlobalVariable.fakeListImportGoods.Clear();
            GlobalVariable.fakeExportGoodsList.Clear();
            this.Close();
        }

        private void dgvInvoiceDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
