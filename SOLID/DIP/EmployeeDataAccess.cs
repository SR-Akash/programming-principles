using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee
            {
                Id = id,
                Name = "Akash",
                Department = "IT",
                Salary = 50000
            };
            return emp;
        }
    }
}
