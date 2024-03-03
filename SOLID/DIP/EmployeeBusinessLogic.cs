using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _employeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
