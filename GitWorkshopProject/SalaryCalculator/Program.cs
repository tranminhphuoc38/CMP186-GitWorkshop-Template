﻿using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);
            var managerSalary = EmployeeService.CalculateSalary(EmployeeType.Manager, 7);
            var expertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 9);

            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));
            Console.ReadLine();
          
            Console.WriteLine(string.Format("Manager's Salary: {0}", managerSalary));
            Console.ReadLine();
          
            Console.WriteLine(string.Format("Expert's Salary: {0}", expertSalary));
            Console.ReadLine();
        }
    }
}
