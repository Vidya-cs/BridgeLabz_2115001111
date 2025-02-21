using System;

class InsufficientFundsException : Exception{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount{
    private double balance;

    public BankAccount(double initialBalance){
        balance = initialBalance;
    }

    public void Withdraw(double amount){
        if(amount<0)
            throw new ArgumentException("Invalid amount");
        if(amount>balance)
            throw new InsufficientFundsException("Insufficient balance");

        balance -= amount;
        Console.WriteLine("Withdrawal successful your new balannce is " + balance);
    }

    public double GetBalance(){
        return balance;
    }
}

class Program10{
    public static void Main(string[] args){
		
		//setting the initial amount
        BankAccount account = new BankAccount(1000); 

        try{
            Console.Write("Enter withdrawal amount ");
            double amount = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex){
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex){
            Console.WriteLine(ex.Message);
        }
        catch (FormatException){
            Console.WriteLine("Please enter a valid number");
        }
    }
}
