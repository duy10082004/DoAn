using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.tk
{
    internal class AccountManager
    {
        private string accountUserName;
        private string accountPassword;
        private string accountEmployeeID;
        private string typeOfAccount;

        public AccountManager()
        {
            this.accountUserName = string.Empty;
            this.accountPassword = string.Empty;
            this.accountEmployeeID = string.Empty;
            this.typeOfAccount = string.Empty;
        }

        public AccountManager(string accountUserName, string accountPassword, string accountEmployeeID, string typeOfAccount)
        {
            this.accountUserName = accountUserName;
            this.accountPassword = accountPassword;
            this.accountEmployeeID = accountEmployeeID;
            this.typeOfAccount = typeOfAccount;
        }

        public string AccountUserName
        {
            get { return this.accountUserName; }
            set { this.accountUserName = value; }
        }

        public string AccountPassword
        {
            get { return this.accountPassword; }
            set { this.accountPassword = value; }
        }

        public string AccountEmployeeID
        {
            get { return this.accountEmployeeID; }
            set { this.accountEmployeeID = value; }
        }

        public string TypeOfAccount
        {
            get { return this.typeOfAccount; }
            set { this.typeOfAccount = value; }
        }



    }
}
