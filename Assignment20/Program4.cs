
using System;

abstract class BankAccount{
    protected int accountNumber;
    protected string holderName;
    protected double balance;

    public BankAccount(int accountNumber, string holderName, double balance){
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount){
        balance+=amount;
        Console.WriteLine("Deposited " + amount);
    }

    public abstract double CalculateInterest();

    public void DisplayAccountDetails(){
        Console.WriteLine("Account Number " + accountNumber);
        Console.WriteLine("Holder Name " + holderName);
        Console.WriteLine("Balance " + balance);
        Console.WriteLine("Interest Earned " + CalculateInterest());
    }
}

class SavingsAccount : BankAccount{
    public SavingsAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest(){
        return balance*0.04;
    }
}

class Program4{
    public static void Main(string[] args){
        SavingsAccount savings = new SavingsAccount(12345, "John Doe", 5000);
        savings.Deposit(1000);
        savings.DisplayAccountDetails();
    }
}



