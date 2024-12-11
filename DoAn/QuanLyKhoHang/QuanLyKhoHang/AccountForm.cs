using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.tk;
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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = accountUserNameTxt.Text;
            string password = accountPasswordTxt.Text;
            string employeeID = accountLbEmployeeCode.Text;
            string employeeDuty = accountLbEmployeeDuty.Text;

            AccountManager account = new AccountManager(userName, password, employeeID, employeeDuty);
            if (accountUserNameTxt.Text == "" || accountPasswordTxt.Text == "")
            {
                MessageBox.Show("Không Được Để Trống!");
            }
            else
            {
                if (ListofAccount.Instance.addNewAccount(account))
                {
                    MessageBox.Show("Tạo Tài Khoản Thành Công!");
                }
                else
                {
                    MessageBox.Show("Trùng Tên Đăng Nhập!!");
                }
            }

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            accountLbEmployeeCode.Text = GlobalVariable.globleVariableemployeeID;
            accountLbEmployeeDuty.Text = GlobalVariable.globalVariableEmployeeDuty;
        }
    }
}
