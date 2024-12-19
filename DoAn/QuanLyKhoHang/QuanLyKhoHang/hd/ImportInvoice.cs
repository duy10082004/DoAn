using QuanLyKhoHang.NhapHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuanLyKhoHang.hd
{
    [Serializable]
    internal class ImportInvoice:InvoiceManager
    {
        public ImportInvoice(string invoiceID, DateTime invoiceTime, string employeeCode)
        : base(invoiceID, invoiceTime, employeeCode)
        {
            this.InvoiceID = invoiceID;
            this.InvoiceTime = invoiceTime;
        }

        public override bool isImportInvoice()
        {
            return true;
        }

        public override bool isExportInvoice()
        {
            return false;
        }

        public override int getInvoiceTotalCost()
        {
            int totalCost = 0;
            foreach (HangNhap tmp in DanhSachHangNhap.Instance.HangNhapArr)
            {
                if (tmp.NhImportOderCode == InvoiceID)
                {
                    totalCost += tmp.NhTotalGoodsImportPrice;
                }
            }
            return totalCost;
        }



    }
}
