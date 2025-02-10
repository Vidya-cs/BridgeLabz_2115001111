using System;

class Employee  // Base Class
{
    public string Name;
    public int Id;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Manager : Employee  // Subclass
{
    public int TeamSize;

    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

class Developer : Employee  // Subclass
{
    public string ProgrammingLanguage;

    public Developer(string name, int id, double salary, string language) : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

class Intern : Employee  // Subclass
{
    public string InternshipDuration;

    public Intern(string name, int id, double salary, string duration) : base(name, id, salary)
    {
        InternshipDuration = duration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}

class Program2
{
    public static void Main()
    {
        Manager manager = new Manager("Alice", 101, 80000, 10);
        Developer developer = new Developer("Bob", 102, 60000, "C#");
        Intern intern = new Intern("Charlie", 103, 20000, "3 months");

        Console.WriteLine("Manager Details:");
        manager.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Developer Details:");
        developer.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Intern Details:");
        intern.DisplayDetails();
    }
}
