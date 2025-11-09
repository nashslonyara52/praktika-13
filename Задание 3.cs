using System;

public class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool Dostup { get; set; }
    public LibraryItem(string title, string author, int year, bool dostup = true)
    {
        Title = title;
        Author = author;
        Year = year;
        Dostup = dostup;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}.");
        Console.WriteLine($"Автор: {Author}.");
        Console.WriteLine($"Год издания: {Year}.");
        Console.WriteLine($"Доступность: {(Dostup ? "Доступно" : "Недоступно")}.");
    }
}
public class Book : LibraryItem
{
    public int PageCount { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, int year, int pageCount, string isbn, bool dostup = true)
        : base(title, author, year, dostup)
    {
        PageCount = pageCount;
        ISBN = isbn;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество страниц: {PageCount}.");
        Console.WriteLine($"ISBN: {ISBN}.");
    }
}
public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public string Chastota { get; set; }

    public Magazine(string title, string author, int year, int issueNumber, string chastota, bool dostup = true)
        : base(title, author, year, dostup)
    {
        IssueNumber = issueNumber;
        Chastota = chastota;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Номер выпуска: {IssueNumber}.");
        Console.WriteLine($"Периодичность: {Chastota}.");
    }
}
public class DVD : LibraryItem
{
    public int Duration { get; set; }
    public string Rating { get; set; }
    public DVD(string title, string author, int year, int duration, string rating, bool dostup = true)
        : base(title, author, year, dostup)
    {
        Duration = duration;
        Rating = rating;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Продолжительность: {Duration} мин.");
        Console.WriteLine($"Рейтинг КП: {Rating}.");
    }
}
public class Audiobook : LibraryItem
{
    public int Duration { get; set; }
    public string Narrator { get; set; }
    public Audiobook(string title, string author, int year, int duration, string narrator, bool dostup = true)
        : base(title, author, year, dostup)
    {
        Duration = duration;
        Narrator = narrator;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Длительность: {Duration} мин.");
        Console.WriteLine($"Диктор: {Narrator}.");
    }
}
class Program
{
    static void Main()
    {
        Book book = new Book("Дежавю", "kizaru", 2025, 165, "228-5-252-00000-67");
        Magazine magazine = new Magazine("МегаКрутойЖурнал", "Кто-то Крутой", 2012, 52, "Еженедельный");
        DVD dvd = new DVD("Мальчишник в Вегасе", "Тодд Филлипс", 2009, 109, "7.7");
        Audiobook audiobook = new Audiobook("Сказка о необратимой смерти", "Слава КПСС", 2023, 52, "Вячеслав Машнов");
        Console.WriteLine("Книга:");
        book.ShowInfo();
        Console.WriteLine("\nЖурнал:");
        magazine.ShowInfo();
        Console.WriteLine("\nDVD:");
        dvd.ShowInfo();
        Console.WriteLine("\nАудиокнига:");
        audiobook.ShowInfo();
    }
}