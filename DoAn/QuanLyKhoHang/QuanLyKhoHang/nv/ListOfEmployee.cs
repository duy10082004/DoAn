using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.nv
{
    internal class ListOfEmployee
    {
        private static ListOfEmployee _instance;
        private List<EmployeeManager> employeeArray;

        public static ListOfEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListOfEmployee();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }


        public ListOfEmployee()
        {
            employeeArray = new List<EmployeeManager>();
        }

        public ListOfEmployee (List<EmployeeManager> employeeArray)
        {
            this.employeeArray = employeeArray;
        }

        public List<EmployeeManager> EmployeeArray
        {
            get { return employeeArray; }
            set { employeeArray = value; }
        }

        public bool employeeCodeChecked (string employeeCode)
        {
            foreach (EmployeeManager employee in employeeArray)
            {
                if (employee.EmployeeCode == employeeCode)
                {
                    return false;
                }
            }
            return true;
        }

        public bool addNewEmployee (EmployeeManager employee)
        {
            if (employeeCodeChecked(employee.EmployeeCode))
            {
                employeeArray.Add(employee);
                return true;
            }
            return false;
        }



    }
}
