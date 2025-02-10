using System;

class Book{
    public string Title;
    public int PublicationYear;

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

class Author : Book 
{
    public string Name;
    public string Bio;

    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
}

class Program4
{
    public static void Main(String[] args)
    {
        Author book1 = new Author("C#", 2022, "John", "C# developer");
        
        Console.WriteLine("Book Details");
        book1.DisplayInfo();
    }
}