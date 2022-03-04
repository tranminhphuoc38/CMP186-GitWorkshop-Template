using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 7);
            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));
            var ManagerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 2);
            Console.WriteLine(string.Format("manager's Salary: {0}", managerSalary));
            Console.ReadLine();
        }
    }
}
