using QuanLyKhoHang.xh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.hd
{
    internal class ExportInvoice: InvoiceManager
    {
        public ExportInvoice(string invoiceID, DateTime invoiceTime, string employeeCode)
                            : base(invoiceID, invoiceTime, employeeCode)
        {
            this.InvoiceID = invoiceID;
            this.InvoiceTime = invoiceTime;
        }


        public override bool isExportInvoice()
        {
            return true;
        }

        public override bool isImportInvoice()
        {
            return false;
        }

        public override int getInvoiceTotalCost()
        {
            int result = 0;
            foreach (Export tmp in ExportGoodsList.Instance.ExportGoodsArray)
            {
                if (tmp.ExportInvoiceID == this.InvoiceID)
                {
                    result += tmp.GoodsExportTotalPrice;
                }
            }
            return result;  
        }


    }
}
