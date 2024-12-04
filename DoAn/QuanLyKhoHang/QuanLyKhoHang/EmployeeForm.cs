using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.nv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeBtnBackWard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeBtnAdd_Click(object sender, EventArgs e)
        {
            string employeeCode = employeeTxtCode.Text;
            string employeeName = employeeTxtName.Text;
            object tmp = employeeCbbDuty.SelectedValue;
            string employeeDuty = tmp.ToString();
            DateTime employeeBirtDay = employeeDtBirtDay.Value;

            EmployeeManager employee = new EmployeeManager(employeeCode, employeeName, employeeDuty, employeeBirtDay);
            if (ListOfEmployee.Instance.addNewEmployee(employee))
            {
                MessageBox.Show("Đã Thêm Thông Tin Nhân Viên Mới!");
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Đã Tồn Tại!");
            }

            employeeTxtCode.Clear();
            employeeTxtName.Clear();



            employeeDgv.DataSource = ListOfEmployee.Instance.EmployeeArray.ToList();


        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeeCbbDuty.DataSource = GlobalVariable.employeeCbbValue;
            employeeCbbSort.DataSource = GlobalVariable.employeeSortCbbValue;
            employeeDgv.DataSource = ListOfEmployee.Instance.EmployeeArray.ToList();
            
        }

        private void employeeDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GlobalVariable.fakeNumber = e.RowIndex;
            GlobalVariable.fakeString = employeeDgv.SelectedCells[0].Value.ToString();
            employeeTxtCode.Text = ListOfEmployee.Instance.EmployeeArray[e.RowIndex].EmployeeCode.ToString();
            employeeTxtName.Text = ListOfEmployee.Instance.EmployeeArray[e.RowIndex].EmployeeName.ToString();
        }

        private void employeeBtnFix_Click(object sender, EventArgs e)
        {
            object tmp = employeeCbbDuty.SelectedItem;

            string employeeDuty = tmp.ToString();
            EmployeeManager employee = new EmployeeManager(employeeTxtCode.Text, employeeTxtName.Text, employeeDuty, employeeDtBirtDay.Value);

            int index = ListOfEmployee.Instance.EmployeeArray.FindIndex(EmployeeManager => EmployeeManager.EmployeeCode == GlobalVariable.fakeString);

            ListOfEmployee.Instance.EmployeeArray[index] = employee;

            MessageBox.Show("Đã Sửa Thông Tin Nhân Viên!!");

            employeeDgv.DataSource = ListOfEmployee.Instance.EmployeeArray.ToList();
            GlobalVariable.clearData();

        }

        private void employeeBtnDel_Click(object sender, EventArgs e)
        {
            int index = ListOfEmployee.Instance.EmployeeArray.FindIndex(EmployeeManager => EmployeeManager.EmployeeCode == GlobalVariable.fakeString);
            ListOfEmployee.Instance.EmployeeArray.RemoveAt(index);
            MessageBox.Show("Đã Xóa Thông Tin Nhân Viên!");
            employeeDgv.DataSource = ListOfEmployee.Instance.EmployeeArray.ToList();
        }

        private void employeeBtnSort_Click(object sender, EventArgs e)
        {
            object tmp = employeeCbbSort.SelectedItem;
            string cbbSortValue = tmp.ToString();
            if (cbbSortValue == "Quản Lý")
            {
                foreach (EmployeeManager employee in ListOfEmployee.Instance.EmployeeArray)
                {
                    if (employee.EmployeeDuty == "Quản Lý")
                    {
                        GlobalVariable.employeeQLSort.Add(employee);
                    }
                }
                employeeDgv.DataSource = GlobalVariable.employeeQLSort.ToList();
                GlobalVariable.employeeNVSort.Clear();
                GlobalVariable.hhAZsortList.Clear();
            }
            else if (cbbSortValue == "Nhân Viên")
            {
                foreach (EmployeeManager employee in ListOfEmployee.Instance.EmployeeArray)
                {
                    if (employee.EmployeeDuty == "Nhân Viên")
                    {
                        GlobalVariable.employeeNVSort.Add(employee);
                    }
                }
                employeeDgv.DataSource = GlobalVariable.employeeNVSort.ToList();
                GlobalVariable.employeeQLSort.Clear();
                GlobalVariable.employeeAZSort.Clear();
            }
            else if (cbbSortValue == "Tên A->Z")
            {
                GlobalVariable.employeeAZSort = ListOfEmployee.Instance.EmployeeArray.OrderBy(employeeManager => employeeManager.EmployeeName).ToList();
                employeeDgv.DataSource = GlobalVariable.employeeAZSort.ToList();
                GlobalVariable.employeeNVSort.Clear();
                GlobalVariable.employeeQLSort.Clear();
            }



        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariable.clearData();
        }

        private void employeeInvoiceStatistics_Click(object sender, EventArgs e)
        {
            GlobalVariable.fakeBool = true;
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }
    }
}
