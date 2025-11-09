using System;
public class BankAccount
{
    public int NumAccount { get; set; }
    public double Balance { get; set; }
    public string Owner { get; set; }
    public BankAccount(int Numaccount, double balance, string owner)
    {
        NumAccount = Numaccount;
        Balance = balance;
        Owner = owner;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Номер счёта: {NumAccount}.");
        Console.WriteLine($"Баланс: {Balance}.");
        Console.WriteLine($"Владелец: {Owner}.");
    }
}
public class CheckingAccount : BankAccount
{
    public double OverDraftLimit { get; set; }
    public CheckingAccount(int accountNum, double balance, string owner, double overDraftLimit) : base(accountNum, balance, owner)
    {
        OverDraftLimit = overDraftLimit;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Лимит овердрафта: {OverDraftLimit}.");
    }
}
public class SavingsAccount : BankAccount
{
    public double PercentRating { get; set; }
    public SavingsAccount(int accountNum, double balance, string owner, double percentRate) : base(accountNum, balance, owner)
    {
        PercentRating = percentRate;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Процентная ставка: {PercentRating}.");
    }
}
public class CreditAccount : BankAccount
{
    public double CreditLimit { get; set; }
    public string datepogasheniya { get; set; }
    public CreditAccount(int accountNum, double balance, string owner, double creditLimit, string pogasheniye) : base(accountNum, balance, owner)
    {
        CreditLimit = creditLimit;
        datepogasheniya = pogasheniye;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Кредитный лимит: {CreditLimit}.");
        Console.WriteLine($"Срок погашения: {datepogasheniya}.");
    }
}
class Program
{
    static void Main()
    {
        CheckingAccount checking = new CheckingAccount(5242, 500, "Арина Барышева", 1000);
        SavingsAccount savings = new SavingsAccount(6767, 10000, "Максим Захаров", 3.5);
        CreditAccount credit = new CreditAccount(1337, -2000, "Сергей Гущин", 3000, "31.12.2025");
        Console.WriteLine("Текущий счет:");
        checking.ShowInfo();
        Console.WriteLine("\nСберегательный счет:");
        savings.ShowInfo();
        Console.WriteLine("\nКредитный счет:");
        credit.ShowInfo();
    }
}