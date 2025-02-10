
using System;

abstract class LibraryItem{
    protected int itemId;
    protected string title;
    protected string author;

    public LibraryItem(int itemId, string title, string author){
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails(){
        Console.WriteLine("Item ID " + itemId);
        Console.WriteLine("Title " + title);
        Console.WriteLine("Author " + author);
        Console.WriteLine("Loan duration " + GetLoanDuration());
    }
}

class Book : LibraryItem{
    public Book(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration(){
        return 14;
    }
}

class Program5{
    public static void Main(string[] args){
        Book book = new Book(101, "C# ", "Vidya");
        book.GetItemDetails();
    }
}



