using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.hd;
using QuanLyKhoHang.KhoHang;
using QuanLyKhoHang.NhapHang;
using QuanLyKhoHang.nv;
using QuanLyKhoHang.tk;
using QuanLyKhoHang.xh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
           AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(EmployeeManager employee in ListOfEmployee.Instance.EmployeeArray)
            {
                if (employee.EmployeeCode == GlobalVariable.accountLogin.AccountEmployeeID )
                {
                    if (employee.EmployeeDuty == "Nhân Viên")
                    {
                        adminBtn.Visible = false;
                    }
                    formLbHoTenNhanVien.Text = employee.EmployeeName;
                    formLBMaNhanVien.Text = employee.EmployeeCode;
                    formLbChucVu.Text = employee.EmployeeDuty;
                }
                
            }
            //load kho hang
            FileStream fs = new FileStream("khoHang.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            DanhSachHangHoa.Instance.DsHangHoa = (List<HangHoa>)bf.Deserialize(fs);
            fs.Close();
            ////load hoa don
            //FileStream fs2 = new FileStream("invoice.dat", FileMode.Open);
            //BinaryFormatter bf2 = new BinaryFormatter();
            //ListOfInvoice.Instance.InvoiceArray = (List<InvoiceManager>)bf.Deserialize(fs);
            //fs.Close();
            ////load hang nhap
            //FileStream fs3 = new FileStream("hangnhap.dat", FileMode.Open);
            //BinaryFormatter bf3 = new BinaryFormatter();
            //DanhSachHangNhap.Instance.HangNhapArr = (List<HangNhap>)bf.Deserialize(fs);
            //fs.Close();
            ////load hang xuat
            //FileStream fs4 = new FileStream("hangxuat.dat", FileMode.Open);
            //BinaryFormatter bf4 = new BinaryFormatter();
            //ExportGoodsList.Instance.ExportGoodsArray = (List<Export>)bf.Deserialize(fs);
            //fs.Close();
            ////load nhan vien
            //FileStream fs5 = new FileStream("employee.dat", FileMode.Open);
            //BinaryFormatter bf5 = new BinaryFormatter();
            //ListOfEmployee.Instance.EmployeeArray = (List<EmployeeManager>)bf.Deserialize(fs);
            //fs.Close();
            ////load tai khoan
            //FileStream fs6 = new FileStream("account.dat", FileMode.Open);
            //BinaryFormatter bf6 = new BinaryFormatter();
            //ListofAccount.Instance.AccountArray = (List<AccountManager>)bf.Deserialize(fs);
            //fs.Close();

        }

        private void adminBtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            

            GlobalVariable.flag = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //luu kho hang
            FileStream fs = new FileStream("khoHang.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, DanhSachHangHoa.Instance.DsHangHoa);
            fs.Close();

            //luu hoa don
            FileStream fs1 = new FileStream("invoice.dat", FileMode.Create);
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(fs, ListOfInvoice.Instance.InvoiceArray);
            fs1.Close();
            //luu hang nhap
            FileStream fs2 = new FileStream("hangnhap.dat", FileMode.Create);
            BinaryFormatter bf2 = new BinaryFormatter();
            bf2.Serialize(fs, DanhSachHangNhap.Instance.HangNhapArr);
            fs2.Close();
            //luu hang xuat
            FileStream fs3 = new FileStream("hangxuat.dat", FileMode.Create);
            BinaryFormatter bf3 = new BinaryFormatter();
            bf3.Serialize(fs, ExportGoodsList.Instance.ExportGoodsArray);
            fs3.Close();
            //luu nhan vien
            FileStream fs4 = new FileStream("employee.dat", FileMode.Create);
            BinaryFormatter bf4 = new BinaryFormatter();
            bf4.Serialize(fs, ListOfEmployee.Instance.EmployeeArray);
            fs4.Close();
            //luu tai khoan
            FileStream fs5 = new FileStream("account.dat", FileMode.Create);
            BinaryFormatter bf5 = new BinaryFormatter();
            bf5.Serialize(fs, ListofAccount.Instance.AccountArray);
            fs5.Close();
        }
    }
}
