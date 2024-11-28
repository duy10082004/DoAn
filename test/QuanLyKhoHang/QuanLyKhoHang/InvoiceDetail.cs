using QuanLyKhoHang.Global_Variable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dgvInvoiceDetail.DataSource = GlobalVariable.fakeListImportGoods;

        }

        private void btnInvoiceDetailBackward_Click(object sender, EventArgs e)
        {
            GlobalVariable.clearData();
            this.Close();
        }

        private void dgvInvoiceDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
