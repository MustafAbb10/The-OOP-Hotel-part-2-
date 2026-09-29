using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Consultant : Person
    {
        

        public decimal HourlyRate { get; set; }

        public string  ConsultingFirm { get; set; }

        public string Expertise { get; set; }

        

        

        public void Giveadvice()
        {
            Console.WriteLine($"konsulten är {Expertise} expert");


        }



        public override void PrintInfo()
        {

            
            base.PrintInfo();
            Console.WriteLine($" ConsultingFirma: {ConsultingFirm}");
            Console.WriteLine($" HourlyRate: {HourlyRate}");
            Giveadvice();


        }


        public override void Introduce()
        {
            base.Introduce();

            Console.WriteLine($"{ConsultingFirm} Är firmans namn");
            Console.WriteLine($"{HourlyRate} Är timlönen");
        }











    }




}
