using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Manager : Person
    {
        public string Department { get; set; }

        public void PlanBudget()
        {
            Console.WriteLine($"{Name} planerar budgeten ");
            

        }

        public void HoldMeeting()
        {
            Console.WriteLine("Lystring! Chefen håller möte. Kom till lokalen och sluta fika!");
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($" Är Chef för: {Department}");
            HoldMeeting();
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($" Departament är: {Department}");
            PlanBudget();

        }




    }
}
