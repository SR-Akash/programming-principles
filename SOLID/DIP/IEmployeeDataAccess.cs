using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
