using System;

public class Book{
    
    string title;
    string author;
    double price;
	
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    //Method for displaying book details
    public void DisplayDetails(){
        Console.WriteLine("Book Title " + title);
        Console.WriteLine("Book Author " + author);
        Console.WriteLine("Book Price " + price);
    }
}

public class Program3{

    public static void Main(String[] args){
		
        Book obj = new Book("Think and Grow Rich", "Napoleon Hill", 200.15);

        obj.DisplayDetails();
    }
}
