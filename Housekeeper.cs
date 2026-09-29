using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Housekeeper : Employee
    {



        public override void Work()
        {
            base.Work();
            Console.Write($" {Name} städar just nu gå ut från hotellrummet");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Work();
        }





    }
}
