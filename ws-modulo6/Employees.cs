using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo6
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * (percentage / 100.00));

        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
