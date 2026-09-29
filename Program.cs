namespace The_OOP_Hotel__part_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager chefen = new Manager()
            {
                Name = "Mustaf",
                Age = 28,

                EmployeeID = "M52",
                StartDate = new DateTime(2026, 09, 29),
                Salary = 50000m,

                Department = "Administration"

            };

            Employee employee = new Employee()
            {
                Name = "Gustaf",
                Age = 25,
                EmployeeID = "M59",

                StartDate = new DateTime(2026, 09, 30),
                Salary = 30000m,
                Department = "Lobbyn"
            };

            Consultant consultant = new Consultant()
            {
                Name = "Anders",
                Age = 36,
                EmployeeID = "M5999",

                StartDate = new DateTime(2026, 10, 30),
                Salary = 30000m,
                ConsultingFirm = "Konsult firma Ab",
                HourlyRate = 200 ,

            };

           /* employee.Introduce();
            employee.PrintInfo();
            employee.Work();*/
            consultant.Introduce();
            consultant.PrintInfo();
            employee.PrintInfo();
            employee.Introduce();
            chefen.PrintInfo();
            chefen.Introduce();
               

            


        }



    }
}
