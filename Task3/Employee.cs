using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public HiringDate? Date { get; set; }
        public Gender Gender { get; set; }
        public int Salary { get; set; }
        public Security Security { get; set; }
        public Employee(int id, string name,HiringDate date,Gender gender,int salary,Security security)
        {
            ID = id;
            Name = name;
            Date = date;
            Gender = gender;
            Salary = salary;
            Security = security;
        }
        public override string ToString()
        {
            return ($"Employee has {Salary.ToString("C2")} and his role is {Security}");
        }
    }
}
