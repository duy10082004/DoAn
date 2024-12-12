using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.nv;
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
    public partial class AccountShowForm : Form
    {
        public AccountShowForm()
        {
            InitializeComponent();
        }

        private void AccountShowForm_Load(object sender, EventArgs e)
        {
            accountDgv.DataSource = ListofAccount.Instance.AccountArray.ToList();
            accountShowCbb.DataSource = GlobalVariable.accountShowCbbValue.ToList();
        }

        private void accountShowBtnSort_Click(object sender, EventArgs e)
        {
            object tmp = accountShowCbb.SelectedItem;
            string cbbValue = tmp.ToString();

            if (cbbValue == "Quyền Quản Lý")
            {
                GlobalVariable.sortEmployrAccount.Clear();
                foreach (AccountManager account in ListofAccount.Instance.AccountArray)
                {
                    if (account.TypeOfAccount == "Quản Lý")
                    {
                        GlobalVariable.sortManagerAccount.Add(account);
                    }
                }
                accountDgv.DataSource = GlobalVariable.sortManagerAccount.ToList();

            }
            else if (cbbValue == "Quyền Nhân Viên")
            {
                GlobalVariable.sortManagerAccount.Clear();
                foreach (AccountManager account in ListofAccount.Instance.AccountArray)
                {
                    if (account.TypeOfAccount == "Nhân Viên")
                    {
                        GlobalVariable.sortEmployrAccount.Add(account);
                    }
                }
                accountDgv.DataSource = GlobalVariable.sortEmployrAccount.ToList();
            }
            else
            {
                GlobalVariable.sortEmployrAccount.Clear();
                GlobalVariable.sortManagerAccount.Clear();
                accountDgv.DataSource = ListofAccount.Instance.AccountArray.ToList();
            }
        }

        private void accountShowBtnInf_Click(object sender, EventArgs e)
        {
            foreach (AccountManager account in ListofAccount.Instance.AccountArray)
            {
                if (account.AccountEmployeeID == GlobalVariable.fakeString)
                {
                    GlobalVariable.accountTakedOut = account;
                }
            }

            foreach (EmployeeManager employee in ListOfEmployee.Instance.EmployeeArray)
            {
                if (employee.EmployeeCode == GlobalVariable.accountTakedOut.AccountEmployeeID)
                {
                    GlobalVariable.employeeTakedOut = employee;
                    break;
                }
            }



            AccountInformationForm accountInformationForm = new AccountInformationForm();
            accountInformationForm.ShowDialog();
        }

        private void accountDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GlobalVariable.fakeString = accountDgv.SelectedCells[2].Value.ToString();
            }
            catch { }
        }
    }
}
