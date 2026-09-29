using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Person
    {
        string Name { get; set; }
        int Age { get; set; }
        string EmployeeId { get; set; }
        DateTime StartDate { get; set; }
        decimal Salary { get; set; }

        public void PrintInfo(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine(name + " " + age);
        }
    }
}
