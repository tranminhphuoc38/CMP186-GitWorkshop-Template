using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);
            var ManagerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 7);
            Console.WriteLine(string.Format("Manager's Salary: {0}", ManagerSalary));
            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));

            Console.ReadLine();
            
        }
    }
}
