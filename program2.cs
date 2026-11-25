using System;

class BankAccount
{
    public int AccountNumber;
    public string HolderName;
    public double Balance;

    public BankAccount(int accountNumber,
                       string holderName,
                       double balance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Holder Name: " + HolderName);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account =
            new BankAccount(101, "Rahul", 5000);

        account.Deposit(2000);
        account.Withdraw(1000);

        account.DisplayDetails();
    }
}
