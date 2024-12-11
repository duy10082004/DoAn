using QuanLyKhoHang.Global_Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyKhoHang.tk
{
    internal class ListofAccount
    {
        private static ListofAccount _instance;
        private List<AccountManager> accountArray;

        public static ListofAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListofAccount();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public ListofAccount()
        {
            this.accountArray = new List<AccountManager>();
        }

        public ListofAccount(List<AccountManager> accountArray)
        {
            this.accountArray = accountArray;
        }

        public List<AccountManager> AccountArray
        {
            get
            {
                return this.accountArray;
            }

            set
            {
                this.accountArray = value;
            }
        }


        public bool addNewAccount(AccountManager account)
        {
            foreach (AccountManager tmp in this.accountArray)
            {
                if (account.AccountUserName == tmp.AccountUserName)
                {
                    return false;
                }
            }
            accountArray.Add(account);
            return true;
        }


        public bool checkAccoutForLogin(string userName, string password)
        {
            foreach (AccountManager tmp in this.accountArray)
            {
                if (userName == tmp.AccountPassword && password == tmp.AccountUserName)
                {
                    GlobalVariable.accountLogin = tmp;
                    return true;
                }
            }
            return false;
        }




        public void initAdminAccount()
        {
            AccountManager adminAccount = new AccountManager("admin", "admin", "NV01", "Quản Lý");
            AccountManager nvAccount = new AccountManager("nv", "nv", "NV02", "Nhân Viên");
            accountArray.Add(adminAccount);
            accountArray.Add(nvAccount);
        }
    }
}
