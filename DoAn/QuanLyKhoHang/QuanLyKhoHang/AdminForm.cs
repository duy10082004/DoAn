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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void adminBtnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void adminBtnAccount_Click(object sender, EventArgs e)
        {
            AccountShowForm accountShowForm = new AccountShowForm();
            accountShowForm.ShowDialog();
        }

        private void adminBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account_MH account_MH = new Account_MH();
            account_MH.ShowDialog();
        }
    }
}
