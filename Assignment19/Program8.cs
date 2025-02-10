using System;

class BankAccount{
    public int AccountNumber;
    public double Balance;

    public BankAccount(int accountNumber, double balance){
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType(){
        Console.WriteLine("This is a general bank account.");
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: $" + Balance);
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public SavingsAccount(int accountNumber, double balance, double interestRate) 
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Savings Account.");
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount : BankAccount{
    public double WithdrawalLimit;

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit) 
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Checking Account.");
        Console.WriteLine("Withdrawal Limit: $" + WithdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount{
    public int MaturityPeriod;

    public FixedDepositAccount(int accountNumber, double balance, int maturityPeriod) 
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Fixed Deposit Account.");
        Console.WriteLine("Maturity Period: " + MaturityPeriod + " months");
    }
}

class Program8
{
    public static void Main()
    {
        SavingsAccount savings = new SavingsAccount(1001, 5000, 3.5);
        CheckingAccount checking = new CheckingAccount(1002, 2000, 1000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount(1003, 10000, 12);

        Console.WriteLine("Account Details:\n");

        savings.DisplayAccountType();
        savings.DisplayBalance();
        Console.WriteLine();

        checking.DisplayAccountType();
        checking.DisplayBalance();
        Console.WriteLine();

        fixedDeposit.DisplayAccountType();
        fixedDeposit.DisplayBalance();
    }
}