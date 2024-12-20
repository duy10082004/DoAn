﻿using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.nv;
using QuanLyKhoHang.tk;
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
            if(employeeCode == "" || employeeName == "")
            {
                MessageBox.Show("Thông Tin Cần Nhập Đang Bỏ Trống!!");
            }
            else
            {
                if (ListOfEmployee.Instance.addNewEmployee(employee))
                {
                    MessageBox.Show("Đã Thêm Thông Tin Nhân Viên Mới!");
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên Đã Tồn Tại!");
                }
            }
            
            //cleart textbox          
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
            GlobalVariable.globleVariableemployeeID = employeeDgv.SelectedCells[0].Value.ToString();
            GlobalVariable.globalVariableEmployeeDuty = employeeDgv.SelectedCells[2].Value.ToString();


        }

        private void employeeBtnFix_Click(object sender, EventArgs e)
        {
            object tmp = employeeCbbDuty.SelectedItem;

            string employeeDuty = tmp.ToString();
            EmployeeManager employee = new EmployeeManager(employeeTxtCode.Text, employeeTxtName.Text, employeeDuty, employeeDtBirtDay.Value);

            int index = ListOfEmployee.Instance.EmployeeArray.FindIndex(EmployeeManager => EmployeeManager.EmployeeCode == GlobalVariable.fakeString);

            ListOfEmployee.Instance.EmployeeArray[index] = employee;

            foreach(AccountManager account in ListofAccount.Instance.AccountArray)
            {
                if(account.AccountEmployeeID == employeeTxtCode.Text)
                {
                    account.TypeOfAccount = employeeDuty;
                }
            }

            MessageBox.Show("Đã Sửa Thông Tin Nhân Viên!!");

            employeeDgv.DataSource = ListOfEmployee.Instance.EmployeeArray.ToList();
            GlobalVariable.clearData();

        }

        private void employeeBtnDel_Click(object sender, EventArgs e)
        {
            int employeeListIndex = ListOfEmployee.Instance.EmployeeArray.FindIndex(EmployeeManager => EmployeeManager.EmployeeCode == GlobalVariable.fakeString);
            int accountListIndex = ListofAccount.Instance.AccountArray.FindIndex(AccountManager => AccountManager.AccountEmployeeID == GlobalVariable.fakeString);
            ListOfEmployee.Instance.EmployeeArray.RemoveAt(employeeListIndex);
            ListofAccount.Instance.AccountArray.RemoveAt(accountListIndex);
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
            else
            {
                employeeDgv.DataSource = ListOfEmployee.Instance.EmployeeArray;
            }



        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariable.clearData();
        }

        private void employeeInvoiceStatistics_Click(object sender, EventArgs e)
        {
            foreach(AccountManager account in ListofAccount.Instance.AccountArray)
            {
                if(account.AccountEmployeeID == GlobalVariable.globleVariableemployeeID)
                {
                    MessageBox.Show("Nhân Viên Đã Có Tài Khoản!!");
                    return;
                }
            }




            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();



        }

        private void employeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
