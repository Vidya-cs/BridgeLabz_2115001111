
using System;

interface Worker{
    void PerformDuties();
}

class Person{
    public string Name;
    public int Id;
    public Person(string name, int id){
        Name = name;
        Id = id;
    }

    public void DisplayInfo(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
    }
}

class Chef : Person, Worker{
    public string SpecialDish;

    public Chef(string name, int id, string specialDish) : base(name, id)
    {
        SpecialDish = specialDish;
    }

    public void PerformDuties()
    {
        Console.WriteLine(Name + " is preparing " + SpecialDish);
    }
}

class Waiter : Person, Worker{
    public int TableNumber;
    public Waiter(string name, int id, int tableNumber) : base(name, id){
        TableNumber = tableNumber;
    }

    public void Perform(){
        Console.WriteLine(Name + " is serving customers at table " + TableNumber);
    }
}

class Program10
{
    public static void Main()
    {
        Chef chef = new Chef("Vidya", 101, "Pasta");
        Waiter waiter = new Waiter("Sagar", 102, 5);

        Console.WriteLine("Restaurant Staff Details");

        chef.DisplayInfo();
        chef.Perform();
        Console.WriteLine();

        waiter.DisplayInfo();
        waiter.Perform();
    }
}



