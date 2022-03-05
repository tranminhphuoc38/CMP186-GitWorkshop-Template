using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);
            var ExpertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 9);
            var ManagerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 7);

            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));

            Console.ReadLine();
        }
    }
}
