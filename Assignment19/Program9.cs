using System;

class Person{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("This is a person.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Teacher : Person{
    public string Subject;
    public Teacher(string name, int age, string subject) : base(name, age){
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("This is a Teacher.");
        Console.WriteLine("Teaches: " + Subject);
    }
}

class Student : Person  // Subclass extending Person
{
    public string Grade;

    public Student(string name, int age, string grade) : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("This is a Student.");
        Console.WriteLine("Grade: " + Grade);
    }
}

class Staff : Person{
    public string JobTitle;

    public Staff(string name, int age, string jobTitle) : base(name, age)
    {
        JobTitle = jobTitle;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("This is a Staff Member.");
        Console.WriteLine("Job Title: " + JobTitle);
    }
}

class Program9
{
    public static void Main()
    {
        Teacher teacher = new Teacher("Alice", 35, "Mathematics");
        Student student = new Student("Bob", 16, "10th Grade");
        Staff staff = new Staff("Charlie", 40, "Librarian");

        Console.WriteLine("School Roles:\n");

        teacher.DisplayRole();
        teacher.DisplayInfo();
        Console.WriteLine();

        student.DisplayRole();
        student.DisplayInfo();
        Console.WriteLine();

        staff.DisplayRole();
        staff.DisplayInfo();
    }
}