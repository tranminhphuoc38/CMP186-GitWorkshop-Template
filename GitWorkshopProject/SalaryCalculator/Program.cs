using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeService.Manager, 7);
            Console.WriteLine(string.Format("Engineer's Salary: {30000000}", engineerSalary));

            Console.ReadLine();
        }
    }
}
