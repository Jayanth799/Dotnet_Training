using System;

namespace DIPPOC
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { set; get; }
        public string Department { set; get; }
        public int Salary { set; get; }
    }

    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _employeeDataAccess = null;
        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeData();
        }
        public Employee GetEmployeeDetails(int Id)
        {
            return _employeeDataAccess.GetEmployeeData(Id);
        }
    }
    public class DataAccessFactory 
    {
        public static EmployeeDataAccess GetEmployeeData()
        {
            return new EmployeeDataAccess();
        }

    }
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeData(int id)
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
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var empDetails = new EmployeeBusinessLogic();
        //    Console.WriteLine(empDetails.GetEmployeeDetails(1).Department);
        //    Console.ReadLine();
        //}
    }
}
