using QuanLyKhoHang.NhapHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.hd
{
    [Serializable]
    internal class InvoiceManager
    {
        private string invoiceID;
        private string invoiceType;
        private string employeeCode;
        private DateTime invoiceTime;
        private int invoiceTotalCost;

        public InvoiceManager()
        {
            this.invoiceID = "";
            this.invoiceType = "";
            this.invoiceTotalCost = 0;
            this.invoiceTime = DateTime.Now;
            this.invoiceTotalCost = 0;
        }

        public InvoiceManager (string invoiceID, DateTime invoiceTime, string emplyeeCode)
        {
            this.invoiceID = invoiceID;
            this.invoiceTime = invoiceTime;
            this.employeeCode = emplyeeCode;
        }

        public string InvoiceID
        {
            get { return this.invoiceID; }
            set { this.invoiceID = value; }
        }

        public DateTime InvoiceTime
        {
            get { return this.invoiceTime; }
            set { this.invoiceTime = value; }
        }

        public string EmployeeCode
        {
            get { return this.employeeCode; }
            set { this.employeeCode = value; }
        }

        public string InVoiceType
        {
            get { return getInVoiceType(); }
            set { this.invoiceType = value; }
        }

        public virtual bool isImportInvoice()
        {
            return false;
        }

        public virtual bool isExportInvoice()
        {
            return false;
        }

        public virtual int getInvoiceTotalCost ()
        {
            return 0; 
        }

        public string getInVoiceType()
        {
            if (this.isImportInvoice()) 
            {
                return "Đơn Nhập";
            }
            else if (this.isExportInvoice())
            {
                return "Đơn Xuất";
            }
            else
            {
                return null;
            }
        }

        public int InvoiceTotalCost
        {
            get 
            { 
                return getInvoiceTotalCost(); 
            }
            set
            {
                this.invoiceTotalCost = value;
            }
        }




    }
}
