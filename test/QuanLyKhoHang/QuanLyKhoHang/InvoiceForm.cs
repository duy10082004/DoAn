using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.hd;
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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = ListOfInvoice.Instance.InvoiceArray.ToList();
            cbbInvoiceSearch.DataSource = GlobalVariable.invoiceComboboxValue;
        }

        private void btnInvoiceBackward_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            GlobalVariable.fakeInvoice = ListOfInvoice.Instance.InvoiceArray[index];

        }

        private void btnInvoiceDetail_Click(object sender, EventArgs e)
        {
            InvoiceDetail tmp = new InvoiceDetail();
            tmp.ShowDialog();
        }
    }
}
