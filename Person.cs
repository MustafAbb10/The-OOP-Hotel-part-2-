using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public void PrintInfo()
        {

            Console.WriteLine($"{Name} är chefens namn och {Age} är hans ålder.");
            Console.WriteLine($"{EmployeeID} är hans jobb-ID och {StartDate} så började han jobba här.");
            Console.WriteLine($"{Salary} är hans lön");
        }

        public void Introduce()
        {
            
            Console.WriteLine("Hej jag heter " + Name + " " + Age);
        }
    }
}
