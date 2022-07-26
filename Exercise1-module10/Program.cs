using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise1_module10.Entities;

namespace Exercise1_module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsorced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsorced is 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsorcedEmployee(name, hours, value, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, value));
                }

                Console.WriteLine("\nPAYMENTS: ");
                foreach (Employee emp in employees)
                {
                    Console.Write($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
