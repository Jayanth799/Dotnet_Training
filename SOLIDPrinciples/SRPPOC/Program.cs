using System;
using System.Collections.Generic;

namespace SRPPOC
{
  
    public class EmployeeService
    {
        public string FirstName { get; set; }

        public string LastNsme { get; set; }

        public void EmployeeRegistration(EmployeeService employee)
        {
            StaticData.Employees.Add(employee);
        } 
    }


    public class StaticData
    {
        public static List<EmployeeService> Employees { get; set; } = new List<EmployeeService>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employee = new EmployeeService()
            {
                FirstName = "veera",
                LastNsme = "Babu"

            };
            employee.EmployeeRegistration(employee);
            Console.ReadKey();
        }
    }
}
