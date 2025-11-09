using System;
namespace ConsoleApp7
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
        public Employee(string name, string position, decimal salary, DateTime date)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Date = date;
        }
        public class Manager : Employee
        {
            public int TeamSize { get; set; }
            public Manager(string name, string position, decimal salary, DateTime hireDate, int teamSize) : base(name, position, salary, hireDate)
            {
                TeamSize = teamSize;
            }
            public string Sobranie()
            {
                return $"{Name} проводит собрание с командой из {TeamSize} человек.";
            }
        }
        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            public Developer(string name, string position, decimal salary, DateTime hireDate, string programmingLanguage) : base(name, position, salary, hireDate)
            {
                ProgrammingLanguage = programmingLanguage;
            }
            public string WriteCode()
            {
                return $"{Name} пишет код на {ProgrammingLanguage}.";
            }
        }
        public class Director : Employee
        {
            public string Department { get; set; }

            public Director(string name, string position, decimal salary, DateTime hireDate, string department) : base(name, position, salary, hireDate)
            {
                Department = department;
            }
            public string Swagaet()
            {
                return $"{Name}, директор отдела {Department}, утверждает бюджет.";
            }
        }
        class Program
        {
            static void Main()
            {
                Manager mgr = new Manager("Михаил Григорьев", "Менеджер", 80000, new DateTime(2020, 12, 8), 67);
                Developer dev = new Developer("Марк Тебряев", "Разработчик", 70000, new DateTime(2025, 11, 9), "C#");
                Director dir = new Director("Лилия Пшеничная", "Директор", 150000, new DateTime(2015, 1, 20), "SWAGA");
                Console.WriteLine(mgr.Sobranie());
                Console.WriteLine(dev.WriteCode());
                Console.WriteLine(dir.Swagaet());
            }
        }
    }
}