using QuanLyKhoHang.hd;
using QuanLyKhoHang.KhoHang;
using QuanLyKhoHang.NhapHang;
using QuanLyKhoHang.nv;
using QuanLyKhoHang.tk;
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
        public static List<String> khComboboxValue = new List<String>() { "Refresh", "A->Z", "Số Lượng Tồn Kho", "Chưa Cập Nhật Giá Bán" };
        public static List<String> employeeCbbValue = new List<String>() { "Quản Lý", "Nhân Viên" };
        public static List<String> employeeSortCbbValue = new List<String>() { "Quản Lý", "Nhân Viên", "Tên A->Z", "Refresh" };
        public static List<String> goodsTypeCbbValue = new List<String>() { "Máy Tính", "Ti Vi", "Tủ Lạnh", "Điều Hòa", "Điện Thoại" };
        public static List<String> accountShowCbbValue = new List<String> { "Quyền Quản Lý", "Quyền Nhân Viên", "Refresh" };
        public static List<String> nhGoodsSupplier = new List<string> { "Nhà cung cấp A", "Nhà cung cấp B", "Nhà cung cấp C" };
       
        //Sort Hóa Đơnpublic
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

        //sort tài khoản
        public static List<AccountManager> sortManagerAccount = new List<AccountManager>();
        public static List<AccountManager> sortEmployrAccount = new List<AccountManager>();




        //Biến cục bộ 
        public static int fakeNumber = -1;
        public static string fakeString = string.Empty;
        public static bool fakeBool = false;
        public static AccountManager accountLogin = null;
        public static string globleVariableemployeeID = null;
        public static string globalVariableEmployeeDuty = null;
        public static AccountManager accountTakedOut = null;
        public static EmployeeManager employeeTakedOut = null;
        public static bool flag = false;



        //refresh DATA
        public static void clearData()
        {
            employeeTakedOut = null;
            accountTakedOut = null;
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
            sortManagerAccount.Clear();
            sortEmployrAccount.Clear();
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
