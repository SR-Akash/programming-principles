using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Without Liskov Substitution Principle
            //Employee employee = new Employee();
            //PermanetEmployee permanetEmployee = new PermanetEmployee();
            //ContructualEmployee contructualEmployee = new ContructualEmployee();
            //Console.WriteLine(employee.CalculateSalary());
            //Console.WriteLine(employee.CalculateBonus());

            //Console.WriteLine(permanetEmployee.CalculateSalary());
            //Console.WriteLine(permanetEmployee.CalculateBonus());

            //Console.WriteLine(contructualEmployee.CalculateSalary());
            //Console.WriteLine(contructualEmployee.CalculateBonus());

            #endregion

            #region Following Liskov Substitution Principle
            EmployeeType employee = new Employees();
            Console.WriteLine(employee.CalculateBonus());
            Console.WriteLine(employee.CalculateSalary());
            employee = new PermanetEmployees(); 
            Console.WriteLine(employee.CalculateSalary());
            employee = new ContructualEmployees(); 
            Console.WriteLine(employee.CalculateSalary());

             
            #endregion
        }
    }

    #region example without Liskov Substitution Principle
    public class Employee
    {
        public virtual int CalculateSalary()
        {
            return 1000;
        }

        public virtual int CalculateBonus()
        {
            return 100;
        }
    }

    public class PermanetEmployee : Employee
    {
        public override int CalculateSalary()
        {
            return 2000;
        }
    }

    public class ContructualEmployee : Employee
    {
        public override int CalculateSalary()
        {
            return 1500;
        }
        public override int CalculateBonus()
        {
            throw new NotImplementedException();
        }

    }
    #endregion

    #region Following Liskov Substitution Principle

    public abstract class EmployeeType
    {
        public abstract int CalculateSalary();
        public abstract int CalculateBonus();
    }

    public class Employees : EmployeeType
    {
        public override int CalculateSalary()
        {
            return 1000;
        }

        public override int CalculateBonus()
        {
            return 100;
        }
    }

    public class PermanetEmployees : EmployeeType
    {
        public override int CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public override int CalculateSalary()
        {
            return 2000;
        }
    }

    public class ContructualEmployees : EmployeeType
    {
        public override int CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public override int CalculateSalary()
        {
            return 1500;
        }

    }
    #endregion

}
