using System;
using System.Collections.Generic;
using System.Text;

namespace The_OOP_Hotel__part_2_
{
    internal class Manager : Person
    {
        public string Department { get; set; }

        public void HoldMeeting()
        {
            Console.WriteLine("Lystring! Chefen håller möte. Kom till lokalen och sluta fika!");
        }
    }
}
