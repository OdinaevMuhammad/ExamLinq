using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task6.Dtos
{
    public class Employee
    {

        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {
            
        }

        public Employee(string name, string department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}