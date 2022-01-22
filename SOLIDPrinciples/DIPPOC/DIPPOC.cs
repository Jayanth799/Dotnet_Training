using System;
using System.Collections.Generic;
using System.Text;

namespace DIPPOC
{
    public interface IEmployeeDataAccess
    {
        Employee getEmployeeDetails(int id);
    }

    public class EmployeesDataAcces : IEmployeeDataAccess
    {
        public Employee getEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                Id = id,
                EmployeeName = "Suman",
                Department = "IT",
                Salary = 100000
            };
            return emp;
        }
    }
    public class DataAccessFactorys
    {
        public static IEmployeeDataAccess GetEmployeeDataAccess()
        {
            return new EmployeesDataAcces();
        } 
    }

    public class EmployeeBusinesslogics
    {
        IEmployeeDataAccess _iemployeeDataAcces;
        public EmployeeBusinesslogics()
        {
            _iemployeeDataAcces = DataAccessFactorys.GetEmployeeDataAccess();
        }
        public Employee GetEmployeeDataa(int id)
        {
            return _iemployeeDataAcces.getEmployeeDetails(id);
        }
    }

    class DIPPOC
    {
        public static void Main()
        {
            var empdetails =new EmployeeBusinesslogics();
            var details = empdetails.GetEmployeeDataa(55);
            Console.ReadKey();
        }
    }
}
