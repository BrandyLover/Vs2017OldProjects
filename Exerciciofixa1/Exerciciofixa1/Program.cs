using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exerciciofixa1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());


            Employee emp = employees.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage that the salary will be increased by: ");
                emp.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
                Console.WriteLine("Id not found");

            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
