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
            



            if (GlobalVariable.fakeBool == false)
            {
                dgvInvoice.DataSource = ListOfInvoice.Instance.InvoiceArray.ToList();
            }
            else
            {
                foreach (InvoiceManager invoice in ListOfInvoice.Instance.InvoiceArray)
                {
                    if (invoice.EmployeeCode == GlobalVariable.fakeString)
                    {
                        GlobalVariable.sortInvoiceByEmployeeCope.Add(invoice);
                    }
                }
                dgvInvoice.DataSource = GlobalVariable.sortInvoiceByEmployeeCope.ToList();
            }
            
                cbbInvoiceSearch.DataSource = GlobalVariable.invoiceComboboxValue;
        }

        private void btnInvoiceBackward_Click(object sender, EventArgs e)
        {
            GlobalVariable.clearData();
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
            GlobalVariable.fakeString = dgvInvoice.SelectedCells[0].Value.ToString();
            int tmp = ListOfInvoice.Instance.InvoiceArray.FindIndex(InvoiceManager => InvoiceManager.InvoiceID == GlobalVariable.fakeString);
            GlobalVariable.fakeInvoice = ListOfInvoice.Instance.InvoiceArray[tmp];

        }

        private void btnInvoiceDetail_Click(object sender, EventArgs e)
        {
            InvoiceDetail tmp = new InvoiceDetail();
            tmp.ShowDialog();
        }

        private void btnInvoiceSearch_Click(object sender, EventArgs e)
        {
            object tmp = cbbInvoiceSearch.SelectedItem;
            string idx = tmp.ToString();
            
            


            if (idx == "Đơn Nhập Hàng")
            {
                foreach (InvoiceManager invoice in ListOfInvoice.Instance.InvoiceArray)
                {
                    if (invoice.InVoiceType == "Đơn Nhập")
                    {
                        GlobalVariable.fakeInvoiceList.Add(invoice);
                    }
                }
                GlobalVariable.fakeInvoiceList2.Clear();
                dgvInvoice.DataSource = GlobalVariable.fakeInvoiceList;
            }
            else if (idx == "Đơn Xuất Hàng")
            {
                foreach (InvoiceManager invoice in ListOfInvoice.Instance.InvoiceArray)
                {
                    if (invoice.InVoiceType == "Đơn Xuất")
                    {
                        GlobalVariable.fakeInvoiceList2.Add(invoice);
                    }
                }
                GlobalVariable.fakeInvoiceList.Clear();
                dgvInvoice.DataSource = GlobalVariable.fakeInvoiceList2;
            }
            else if (idx == "Giá Thấp Đến Cao")
            {
                GlobalVariable.fakeInvoiceList3 = ListOfInvoice.Instance.InvoiceArray.OrderBy(InvoiceManager => InvoiceManager.InvoiceTotalCost).ToList();
                dgvInvoice.DataSource = GlobalVariable.fakeInvoiceList3;
                GlobalVariable.fakeInvoiceList4.Clear();
            }
            else if (idx == "Giá Cao Đến Thấp")
            {
                GlobalVariable.fakeInvoiceList4 = ListOfInvoice.Instance.InvoiceArray.OrderByDescending(InvoiceManager => InvoiceManager.InvoiceTotalCost).ToList();
                dgvInvoice.DataSource = GlobalVariable.fakeInvoiceList4;
                GlobalVariable.fakeInvoiceList3.Clear();
            }
            else
            {
                dgvInvoice.DataSource = ListOfInvoice.Instance.InvoiceArray.ToList();
            }



        }

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariable.clearData();
        }
    }
}
