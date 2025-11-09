using System;

namespace ConsoleApp7
{
    public class Animal
    {
        public string View { get; set; }
        public int Age { get; set; }
        public string LivingEnvironment { get; set; }
        public string Diet { get; set; }
        public Animal(string view, int age, string livingEnvironment, string diet)
        {
            View = view;
            Age = age;
            LivingEnvironment = livingEnvironment;
            Diet = diet;
        }
        public class Mammal : Animal
        {
            public string Fur {  get; set; }
            public string Pregnancy { get; set; }

            public Mammal(string view, int age, string livingEnvironment, string diet, string fur, string pregnancy) : base(view, age, livingEnvironment, diet)
            {
                Fur = fur;
                Pregnancy = pregnancy;
            }
            public string MammalInfo()
            {
                return $"{View} животное, ему сейчас {Age} лет, тип меха {Fur}, прожолжительность беремености {Pregnancy}, среда обитания {LivingEnvironment}, диета {Diet}";
            }
        }
        public class Bird : Animal
        {
            public string Scope { get; set; }
            public string Nesting { get; set; }
            public Bird(string view, int age, string livingEnvironment, string diet, string scope, string nesting) : base(view, age, livingEnvironment, diet)
            {
                Scope = scope;
                Nesting = nesting;

            }
            public string BirdInfo()
            {
                return $"{View} животное, ей сейчас {Age} года,размах крыла (в сантиметрах) {Scope}, имеет тип гнездования {Nesting}, среда обитания {LivingEnvironment}, диета {Diet}";
            }
        }
        public class Reptile : Animal
        {
            public string Skin { get; set; }
            public double Temperature { get; set; }
            public Reptile(string view, int age, string livingEnvironment, string diet, string skin, double temperature) : base(view, age, livingEnvironment, diet)
            {
                Skin = skin;
                Temperature = temperature;
            }
            public string ReptileInfo()
            {
                return $"{View} животное,ей сейчас {Age} лет, оно имеет тип кожи {Skin}, обитает в среде с температурой  от {Temperature}, среда обитания {LivingEnvironment}, диета {Diet}.";
            }
        }
        public class Fish : Animal
        {
            public string Scales { get; set; }
            public int Depth { get; set; }

            public Fish(string view, int age, string livingEnvironment, string diet, string scales, int depth) : base(view, age, livingEnvironment, diet)
            {
                Scales = scales;
                Depth = depth;
            }
            public string FishInfo()
            {
                return $"{View} животное,ей сейчас {Age} лет, оно имеет тип кожи {Scales}, диета {Diet}, среда обитания {LivingEnvironment}, обитает на глубине {Depth}.";
            }
        }
        class Program
        {
            static void Main()
            {
                Mammal mgr = new Mammal("Лев", 12, "саванна", "мясо", "жёстая и пышная", "105 дней");
                Bird dev = new Bird("Синица", 2, "леса", "насекомые", "23", "дуплогнездники");
                Reptile dir = new Reptile("Зелёная черепаха", 120, "море", "морская трава","сухая и ороговевшая", 19);
                Fish anm = new Fish("Треска", 10, "море и океан", "всеядная","мелкая циклоидная", 40);
                Console.WriteLine(mgr.MammalInfo());
                Console.WriteLine(dev.BirdInfo());
                Console.WriteLine(dir.ReptileInfo());
                Console.WriteLine(anm.FishInfo());
            }
        }
    }
}