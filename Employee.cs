using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Employee: Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }

        public void Work()
        {
            
            Console.WriteLine("Den anställde är " + JobTitle + " på " + Department + ".");
        }
    }
}
