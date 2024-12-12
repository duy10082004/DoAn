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
    public partial class AccountInformationForm : Form
    {
        public AccountInformationForm()
        {
            InitializeComponent();
        }

        private void AccountInformationForm_Load(object sender, EventArgs e)
        {
            //thong tin chu tai khoan
            gbChangePassword.Visible = false;
            accountinfEmployeeIDLb.Text = GlobalVariable.employeeTakedOut.EmployeeCode;
            accountinfEmployeeNameLb.Text = GlobalVariable.employeeTakedOut.EmployeeName;
            accountinfEmployeeBirthLb.Text = GlobalVariable.employeeTakedOut.EmployeeBirthDay.ToString();
            accountinfEmployeeDutyLb.Text = GlobalVariable.globalVariableEmployeeDuty;
            //thong tin tai khoan
            accountUserNameLb.Text = GlobalVariable.accountTakedOut.AccountUserName;
            accountPasswordLb.Text = GlobalVariable.accountTakedOut.AccountPassword;
            accountTypeLb.Text = GlobalVariable.accountTakedOut.TypeOfAccount;



        }

        private void accountInfExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeAccountInfBtn_Click(object sender, EventArgs e)
        {
            gbChangePassword.Visible = true;
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            foreach (AccountManager account in ListofAccount.Instance.AccountArray)
            {
                if (account.AccountEmployeeID == GlobalVariable.accountTakedOut.AccountEmployeeID)
                {
                    account.AccountPassword = changePasswordTxt.Text;
                    MessageBox.Show("Đổi Mật Khẩu Thành Công!!");
                    accountPasswordLb.Text = account.AccountPassword;
                    break;
                }
            }
            gbChangePassword.Visible=false;
        }
    }
}
