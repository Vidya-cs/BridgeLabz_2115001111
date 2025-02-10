using System;
using System.Collections.Generic;

abstract class Product{
    protected int productId;
    protected string name;
    protected double price;

    public Product(int productId, string name, double price){
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();

    public virtual double GetFinalPrice(){
        return price-CalculateDiscount();
    }

    public void DisplayProductDetails(){
        Console.WriteLine("Product ID " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price " + price);
        Console.WriteLine("Discount " + CalculateDiscount());
        Console.WriteLine("Final Price " + GetFinalPrice());
    }
}

interface ITaxable{
    double CalculateTax();
    void GetTaxDetails();
}

class Electronics : Product, ITaxable{
    public Electronics(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount(){
        return price*0.1;
    }

    public double CalculateTax(){
        return price*0.15;
    }

    public void GetTaxDetails()
    {
        Console.WriteLine("Tax for " + name + ": $" + CalculateTax());
    }
}

class Clothing : Product
{
    public Clothing(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price*0.2;
    }
}

class Program2{
    public static void Main(string[] args){
        List<Product> products = new List<Product>();
        products.Add(new Electronics(201, "Laptop", 1000));
        products.Add(new Clothing(202, "T-Shirt", 50));

        foreach (var product in products)
        {
            product.DisplayProductDetails();
            if (product is ITaxable)
            {
                ((ITaxable)product).GetTaxDetails();
            }
            Console.WriteLine();
        }
    }
}
