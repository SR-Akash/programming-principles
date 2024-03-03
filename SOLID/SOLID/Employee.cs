using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    #region SRP Principle Violation
    class Employee
    {
        //Own Responsibilty
        public int CalculateSalary()
        {
            return 1000;
        }
        //Own Responsibilty
        public string GetDepartment()
        {
            return "CSE";
        }

        //Extra Responsibilty
        public void Save()
        {
            //save employees to database
        }
    }
    #endregion

    #region Following Proper SRP Principle
    public class Employees
    {
        //Own Responsibilty
        public int CalculateSalary()
        {
            return 1000;
        }
        //Own Responsibilty
        public string GetDepartment()
        {
            return "CSE";
        }
    }

    public class EmployeeRepository
    {
        //Extra Responsibilty
        public void Insert(Employees employee)
        {
            //save employees to database
        }
    }

    #endregion
}
