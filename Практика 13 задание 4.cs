using System;
using System.Diagnostics;
using System.Xml.Linq;
namespace ConsoleApp7
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Course(string name, string description, string author, double price)
        {
            Name = name;
            Description = description;
            Author = author;
            Price = price;
        }
        public class VideoCourse : Course
        {
            public int QuantityVideo { get; set; }
            public string Totalduration { get; set; }
            public VideoCourse(string name, string description, string author, double price, int quantityVideo, string totalduration) : base(name, description, author, price)
            {
                QuantityVideo = quantityVideo;
                Totalduration = totalduration;
            }
            public string VideoCourseInfo()
            {
                return $"{Name} проводит видео-курсы, в котором снято {QuantityVideo} видео, общая длительность видео {Totalduration}, автор курсов {Author} и их стоимость {Price}.";
            }
        }
        public class TextCourse : Course
        {
            public int Chapter { get; set; }
            public int TotalNumberOfPpages { get; set; }
            public TextCourse(string name, string description, string author, int сhapter, double price, int totalNumberOfPpages) : base(name, description, author, price)
            {
                TotalNumberOfPpages = totalNumberOfPpages;
                Chapter = сhapter;
            }
            public string TextCourseInfo()
            {
                return $"{Name} ведёт текстовые курсы, где содеожится {Chapter} глав, и их общая длительность {TotalNumberOfPpages}, автор курсов {Author} и их стоимость {Price}.";
            }
        }
        public class InteractiveCourse : Course
        {
            public int Exercises { get; set; }
            public int Check {  get; set; }
            public InteractiveCourse(string name, string description, string author, double price, int exercises, int check) : base(name, description, author, price)
            {
                Exercises = exercises;
                Check = check;
            }
            public string InteractiveCourseInfo()
            {
                return $"{Name} ведёт интерактивный курс, где всего {Exercises} упражнений, а проверка идёт по системе оценок: {Check}, автор курсов {Author} и их стоимость {Price}.";
            }
        }
        class Program
        {
            static void Main()
            {
                VideoCourse mgr = new VideoCourse("Барышева Арина", "курсы видео", "Арина", 100000, 20, "90ч");
                TextCourse dev = new TextCourse("Марк Тебряев", "текстовые курсы", "Марк", 16, 50000, 6);
                InteractiveCourse dir = new InteractiveCourse("Лилия Пшеничная", "интерактивные курсы", "Михаил", 60000, 19, 98);
                Console.WriteLine(mgr.VideoCourseInfo());
                Console.WriteLine(dev.TextCourseInfo());
                Console.WriteLine(dir.InteractiveCourseInfo());
            }
        }
    }
}