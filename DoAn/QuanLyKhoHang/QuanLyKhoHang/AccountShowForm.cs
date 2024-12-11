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
        }
    }
}
