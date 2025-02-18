using System;
using System.Collections.Generic;

abstract class Product{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void Display();
}

class BookCategory : Product{
    public string Author { get; set; }

    public BookCategory(string name, double price, string author) : base(name, price)
    {
        Author = author;
    }

    public override void Display(){
        Console.WriteLine($"[Book] Name: {Name}, Price: {Price}, Author: {Author}");
    }
}

class ClothingCategory : Product{
    public string Size { get; set; }

    public ClothingCategory(string name, double price, string size) : base(name, price)
    {
        Size = size;
    }

    public override void Display()
    {
        Console.WriteLine($"[Clothing] Name: {Name}, Price: {Price}, Size: {Size}");
    }
}
class ProductCatalog<T> where T : Product
{
    private List<T> products = new List<T>();
    public void AddProduct(T product){
        products.Add(product);
    }

    public void DisplayProducts(){
        Console.WriteLine("Marketplace Products:");
        foreach (var product in products)
        {
            product.Display();
        }
    }
}
class DiscountManager{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Discount Applied: {percentage}% off on {product.Name}. New Price: {product.Price}");
    }
}

class Program2{
    public static void Main(string[] args){
        ProductCatalog<BookCategory> bookCatalog = new ProductCatalog<BookCategory>();
        ProductCatalog<ClothingCategory> clothingCatalog = new ProductCatalog<ClothingCategory>();

        BookCategory book1 = new BookCategory("C# for Beginners", 500, "John Doe");
        BookCategory book2 = new BookCategory("Learn Java", 600, "Jane Smith");
        bookCatalog.AddProduct(book1);
        bookCatalog.AddProduct(book2);

       
        ClothingCategory cloth1 = new ClothingCategory("T-Shirt", 300, "M");
        ClothingCategory cloth2 = new ClothingCategory("Jeans", 1200, "L");
        clothingCatalog.AddProduct(cloth1);
        clothingCatalog.AddProduct(cloth2);
        bookCatalog.DisplayProducts();
        clothingCatalog.DisplayProducts();

       
        DiscountManager.ApplyDiscount(book1, 10);
        DiscountManager.ApplyDiscount(cloth2, 20);       
        bookCatalog.DisplayProducts();
        clothingCatalog.DisplayProducts();
    }
}