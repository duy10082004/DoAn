using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.hd
{
    internal class ListOfInvoice
    {
        private List<InvoiceManager> invoiceArray;
        private static ListOfInvoice _instance;

        public ListOfInvoice()
        {
            invoiceArray = new List<InvoiceManager>();
        }

        public List<InvoiceManager> InvoiceArray
        {
            get { return invoiceArray; }
            set { invoiceArray = value; }
        }

        public static ListOfInvoice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListOfInvoice();
                }
                return _instance;
            }
            set { _instance = value; }
        }

        public void addInvoice(InvoiceManager invoice)
        {
            invoiceArray.Add(invoice);
        }


    }
}
