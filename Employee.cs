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

        public override void Introduce()
        {
            base.Introduce();
            Work();
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($" Jobb titeln är: {JobTitle}");
            Console.WriteLine($" Departament är:{Department}");

        }




    }
}
