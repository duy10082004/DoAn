using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.NhapHang
{
    [Serializable]
    internal class HangNhap
    {
        private string nhImportOderCode;
        private string nhEmployeeCode;
        private DateTime nhImportTime;
        private string nhGoodsCode;
        private string nhGoodsName;
        private string nhGoodsType;
        private int nhGoodsQuantity;
        private int nhGoodsImportPrice;
        private int nhTotalGoodsImportPrice;
        private string nhGoodsSupplier;

        public HangNhap() 
        {
            this.nhEmployeeCode = "";
            this.nhImportTime = DateTime.Now;
            this.nhGoodsCode = "";
            this.nhGoodsName = "";
            this.nhGoodsType = "";
            this.nhGoodsQuantity = 0;
            this.nhGoodsImportPrice = 0;
            this.nhImportOderCode = "";
            nhGoodsSupplier = "";
        }

        public HangNhap (string nhEmployeeCode, DateTime nhImportTime, string nhGoodsCode, string nhGoodsName, 
        string nhGoodsType, int nhGoodsQuantity, int nhGoodsImportPrice, string nhGoodsSupplier)
        {
            this.nhEmployeeCode = nhEmployeeCode;
            this.nhImportTime = nhImportTime;
            this.nhGoodsCode = nhGoodsCode;
            this.nhGoodsName = nhGoodsName;
            this.nhGoodsType = nhGoodsType;
            this.nhGoodsQuantity = nhGoodsQuantity;
            this.nhGoodsImportPrice = nhGoodsImportPrice;
            this.nhGoodsSupplier = nhGoodsSupplier;

        }

        public string NhEmployeeCode
        {
            get { return this.nhEmployeeCode; }
            set { this.nhEmployeeCode = value; }
        }

        public DateTime NhImportTime
        {
            get { return this.nhImportTime; }
            set { this.nhImportTime = value; }
        }

        public string NhGoodsCode
        {
            get { return this.nhGoodsCode; }
            set { this.nhGoodsCode = value; }
        }

        public string NhGoodsName
        {
            get { return this.nhGoodsName; }
            set { this.nhGoodsName = value; }
        }

        public string NhGoodsType
        {
            get { return this.nhGoodsType; }
            set { this.nhGoodsType = value; }
        }

        public int NhGoodsQuantity
        {
            get { return this.nhGoodsQuantity; }
            set { this.nhGoodsQuantity = value; }
        }

        public int NhGoodsImportPrice
        {
            get { return this.nhGoodsImportPrice; }
            set { this.nhGoodsImportPrice = value; }
        }

        public int nhThanhTien()
        {
            return nhGoodsQuantity * nhGoodsImportPrice;
        }

        public int NhTotalGoodsImportPrice
        {
            get { return nhTotalGoodsImportPrice = nhThanhTien(); }
        }
        
        public string NhImportOderCode
        {
            get { return nhImportOderCode; }
            set { this.nhImportOderCode = value; }
        }

        public string NhGoodsSupplier
        {
            get { return nhGoodsSupplier; }
            set { this.nhGoodsSupplier = value; }
        }



    }
}
