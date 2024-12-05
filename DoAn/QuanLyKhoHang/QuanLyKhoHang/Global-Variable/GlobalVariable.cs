using QuanLyKhoHang.hd;
using QuanLyKhoHang.KhoHang;
using QuanLyKhoHang.NhapHang;
using QuanLyKhoHang.nv;
using QuanLyKhoHang.xh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuanLyKhoHang.Global_Variable
{
    internal class GlobalVariable
    {
        
        //value Combobox;
        public static List<String> invoiceComboboxValue = new List<String>() {"Refresh", "Giá Thấp Đến Cao",
            "Giá Cao Đến Thấp", "Đơn Nhập Hàng", "Đơn Xuất Hàng" };
        public static List<String> khComboboxValue = new List<string>() { "Refresh", "A->Z", "Số Lượng Tồn Kho", "Chưa Cập Nhật Giá Bán" };
        public static List<String> employeeCbbValue = new List<string>() { "Quản Lý", "Nhân Viên" };
        public static List<String> employeeSortCbbValue = new List<string>() { "Quản Lý", "Nhân Viên", "Tên A->Z" };

        //Sort Hóa Đơn
        public static InvoiceManager fakeInvoice = new InvoiceManager("", DateTime.Now, "");
        public static List<HangNhap> fakeListImportGoods = new List<HangNhap>();
        public static List<Export> fakeExportGoodsList = new List<Export>();
        public static List<InvoiceManager> fakeInvoiceList = new List<InvoiceManager>();
        public static List<InvoiceManager> fakeInvoiceList2 = new List<InvoiceManager>();
        public static List<InvoiceManager> fakeInvoiceList3 = new List<InvoiceManager>();
        public static List<InvoiceManager> fakeInvoiceList4 = new List<InvoiceManager>();
        public static List<InvoiceManager> sortInvoiceByEmployeeCope = new List<InvoiceManager>();
        
        //sort Kho Hàng
        public static List<HangHoa> hhAZsortList = new List<HangHoa>();
        public static List<HangHoa> hhQuanTitySort = new List<HangHoa>();
        public static List<HangHoa> hhNonExportPriceSort = new List<HangHoa>();

        //sort Nhân Viên
        public static List<EmployeeManager> employeeQLSort = new List<EmployeeManager>();
        public static List<EmployeeManager> employeeNVSort = new List<EmployeeManager>();
        public static List<EmployeeManager> employeeAZSort = new List<EmployeeManager>();



        //Biến cục bộ 
        public static int fakeNumber = -1;
        public static string fakeString = string.Empty;
        public static bool fakeBool = false;



        //refresh DATA
        public static void clearData()
        {
            fakeListImportGoods.Clear();
            fakeExportGoodsList.Clear();
            fakeInvoiceList.Clear();
            fakeInvoiceList2.Clear();
            fakeInvoiceList3.Clear();
            fakeInvoiceList4.Clear();
            hhAZsortList.Clear();
            hhQuanTitySort.Clear();
            hhNonExportPriceSort.Clear();
            employeeQLSort.Clear();
            employeeNVSort.Clear();
            employeeAZSort.Clear();
            fakeInvoice = null;
            fakeNumber = -1;
            fakeString = string.Empty;
            fakeBool = false;
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
            foreach (Export tmp in ExportGoodsList.Instance.ExportGoodsArray)
            {
                if (tmp.ExportInvoiceID == fakeInvoice.InvoiceID)
                {
                    fakeExportGoodsList.Add(tmp);
                }
            }
        }

    }




}
