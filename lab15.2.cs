using System;

class Account
{
    public double balance;

    public Account(double b)
    {
        balance = b;
    }

    public virtual void Withdraw(double amt)
    {
        balance -= amt;
        Console.WriteLine("Withdraw: " + amt);
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(double b) : base(b) { }

    public override void Withdraw(double amt)
    {
        if (amt > balance)
            Console.WriteLine("Insufficient balance");
        else
            balance -= amt;
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount(1500);
        s.Withdraw(200);
        Console.WriteLine(s.balance);
    }
}