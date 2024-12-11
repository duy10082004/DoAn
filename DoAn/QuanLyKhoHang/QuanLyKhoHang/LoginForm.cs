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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = loginTxtUserName.Text;
            string password = loginTxtPassword.Text;
            if(ListofAccount.Instance.checkAccoutForLogin(userName, password) == true)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu!!");
            }

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ListofAccount.Instance.initAdminAccount();
            ListOfEmployee.Instance.initEmployee();
        }
    }
}
