using System;

class Bank{
    string Name { get; set; }
    List<Customer> Customers { get; set; }

    public Bank(string name){
        Name = name;
        Customers = new List<Customer>();
    }

    public void OpenAccount(Customer customer, decimal initialDeposit){
        BankAccount account = new BankAccount(this, initialDeposit);
        customer.AddAccount(account);
        if(!Customers.Contains(customer)){
            Customers.Add(customer);
        }
        Console.WriteLine($"Account opened for {customer.Name} at {Name} with balance {initialDeposit:C}");
    }
}


class Customer{
    string Name { get; set; }
    List<BankAccount> Accounts { get; set; }

    public Customer(string name){
        Name = name;
        Accounts = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account){
        Accounts.Add(account);
    }

    public void ViewBalance(){
        Console.WriteLine($"{Name}'s Bank Accounts");
        for(int i=0; i<Accounts.Count; i++){
			Console.WriteLine("Bank " + Accounts[i].Bank.Name + ", Balance " + Accounts[i].Balance);
		}
    }
}


class BankAccount{
    Bank Bank { get; set; }
    decimal Balance { get; private set; }

    public BankAccount(Bank bank, decimal initialDeposit){
        Bank = bank;
        Balance = initialDeposit;
    }
}

class Program2{
    public static void Main(String[] args){
        Bank bank1 = new Bank("Global Bank");
        Customer customer1 = new Customer("Alice");
        Customer customer2 = new Customer("Bob");

        bank1.OpenAccount(customer1, 500);
        bank1.OpenAccount(customer1, 1500);
        bank1.OpenAccount(customer2, 1000);

        customer1.ViewBalance();
        Console.WriteLine();
        customer2.ViewBalance();
    }
}