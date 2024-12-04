using QuanLyKhoHang.KhoHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.xh
{
    internal class Export
    {
        private string employeeCode;
        private string goodsID;
        private string goodsName;
        private string gooddsType;
        private int goodsQuantity;
        private int goodsExportTotalPrice;
        private string exportInvoiceID;
        private DateTime exportTime;
        private int goodsExportPrice;

        public Export ()
        {
            this.employeeCode = string.Empty;
            this.goodsID = string.Empty;
            this.goodsName = string.Empty;
            this.gooddsType = string.Empty;
            this.goodsQuantity = 0;
            this.goodsExportTotalPrice = 0;
            this.exportInvoiceID = string.Empty;
            this.exportTime = DateTime.Now;
            this.goodsExportPrice = 0;
        }

        public Export (string employeeCode, string goodsID, string goodsName, string goodsType, int goodsQuantity, string exportInvoiceID, DateTime exportTime)
        {
            this.employeeCode = employeeCode;
            this.goodsID = goodsID;
            this.goodsName = goodsName;
            this.gooddsType = goodsType;
            this.goodsQuantity = goodsQuantity;
            this.exportInvoiceID = exportInvoiceID;
            this.exportTime = exportTime;  
        }


        public string EmployeeCode
        {
            get { return this.employeeCode; }
            set { this.employeeCode = value; }
        }

        public string GoodsID
        {
            get { return this.goodsID; }
            set { this.goodsID = value; }
        }

        public string GoodsName
        {
            get { return this.goodsName; }
            set { this.goodsName = value; }
        }

        public string GoodsType
        {
            get { return this.gooddsType; }
            set { this.gooddsType = value; }
        }

        public int GoodsQuantity
        {
            get { return this.goodsQuantity; }
            set { this.goodsQuantity = value; }
        }

        public string ExportInvoiceID
        {
            get { return this.exportInvoiceID; }
            set { this.exportInvoiceID = value; }

        }

        public DateTime ExportTime
        {
            get { return this.exportTime; }
            set { this.exportTime = value; }
        }

        public int getGoodsExportPrice()
        {
            int result = 0;
            foreach (HangHoa tmp in DanhSachHangHoa.Instance.DsHangHoa)
            {
                if (goodsID == tmp.HhMaHangHoa)
                {
                    result = tmp.HhGiaBan;
                }
            }
            return result;
        }

        public int GoodsExportPrice
        {
            get { return this.goodsExportPrice = getGoodsExportPrice(); }
            set { this.goodsExportPrice = value; }
        }


        public int getGoodsExportTotalPrice()
        {
            int result = 0;
            foreach (HangHoa tmp in DanhSachHangHoa.Instance.DsHangHoa)
            {
                if (tmp.HhMaHangHoa == goodsID)
                {
                    return result = tmp.HhGiaBan * goodsQuantity;
                }
            }

            return result;
        }

        public int GoodsExportTotalPrice
        {
            get { return this.goodsExportTotalPrice = getGoodsExportTotalPrice(); }
            set { this.goodsExportTotalPrice = value; }
        }




    }
}
