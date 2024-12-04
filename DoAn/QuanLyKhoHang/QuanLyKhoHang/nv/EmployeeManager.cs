using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.nv
{
    internal class EmployeeManager
    {
        private string employeeCode;
        private string employeeName;
        private string employeeDuty;
        private DateTime employeeBirthDay;

        public EmployeeManager()
        {
            this.employeeDuty = string.Empty;
            this.employeeName = string.Empty;
            this.employeeCode = string.Empty;
            this.employeeBirthDay = DateTime.Now;
        }

        public EmployeeManager (string employeeCode, string employeeName, string employeeDuty, DateTime employeeBirthDay)
        {
            this.employeeCode = employeeCode;
            this.employeeName = employeeName;
            this.employeeDuty = employeeDuty;
            this.employeeBirthDay = employeeBirthDay;
        }

        public string EmployeeCode
        {
            get { return this.employeeCode; }
            set { this.employeeCode = value; }
        }

        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }

        public string EmployeeDuty
        {
            get { return this.employeeDuty; }
            set
            {
                this.employeeDuty = value;
            }
        }

        public DateTime EmployeeBirthDay
        {
            get { return this.employeeBirthDay; }
            set { this.employeeBirthDay = value; }
        }

        



    }
}
