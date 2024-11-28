using QuanLyKhoHang.hd;
using QuanLyKhoHang.NhapHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.Global_Variable
{
    internal class GlobalVariable
    {
        

        public static List<String> invoiceComboboxValue = new List<String>() {"Mã Đơn Hàng", "Giá Thấp Đến Cao",
            "Giá Cao Đến Thấp", "Đơn Nhập Hàng", "Đơn Xuất Hàng" };

        public static InvoiceManager fakeInvoice = null;
        public static List<HangNhap> fakeListImportGoods = new List<HangNhap>();
        
        public static void clearData()
        {
            fakeListImportGoods.Clear();
        }
        public static void invoiceDetail()
        {
            foreach(HangNhap tmp in DanhSachHangNhap.Instance.HangNhapArr)
            {
                if (tmp.NhImportOderCode == fakeInvoice.InvoiceID)
                {
                    fakeListImportGoods.Add(tmp);
                }
            }
        }
        
    }
}
