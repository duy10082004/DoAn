using QuanLyKhoHang.KhoHang;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renderDGV(DataGridView dgv, List<HangHoa> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        DanhSachHangHoa dsHH = new DanhSachHangHoa();

        private void adminBtnKhoHang_Click(object sender, EventArgs e)
        {
            QuanLy kh = new QuanLy();
            kh.ShowDialog();
        }



        private void adminBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminBtnNhapHang_Click(object sender, EventArgs e)
        {
            GoodsImport nh = new GoodsImport();
            nh.ShowDialog();
        }

        private void adminBtnXemHoaDon_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }

        private void adminBtnXuatHang_Click(object sender, EventArgs e)
        {
            ExportGoods eG = new ExportGoods();
            eG.ShowDialog();
        }

        private void adminBtnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }
    }
}
