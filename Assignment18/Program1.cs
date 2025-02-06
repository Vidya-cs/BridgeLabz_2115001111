using System;

class Book{
    string Title { get; set; }
    string Author { get; set; }

    public Book(string title, string author){
        Title = title;
        Author = author;
    }

    public void Display(){
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

class Library{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name){
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book){
        Books.Add(book);
    }

    public void DisplayBooks(){
        Console.WriteLine($"Library: {Name} has the following books:");
        for(int i=0; i<Books.Count; i++){
			Books[i].Display();
		}
    }
}

class Program1{
    public static void Main(String[] args){
		
        Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("1984", "George Orwell");

        //create libraries
        Library library1 = new Library("City Library");
        Library library2 = new Library("Community Library");

        //adding books
        library1.AddBook(book1);
        library1.AddBook(book2);

        library2.AddBook(book2);
        library2.AddBook(book3);

        //Displaying books in library
        library1.DisplayBooks();
        Console.WriteLine();
        library2.DisplayBooks();
    }
}