
using System;

abstract class FoodItem{
    protected string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string itemName, double price, int quantity){
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails(){
        Console.WriteLine("Item " + itemName);
        Console.WriteLine("Pric " + price);
        Console.WriteLine("Quantity " + quantity);
        Console.WriteLine("Total price " + CalculateTotalPrice());
    }
}

class VegItem : FoodItem{
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice(){
        return price*quantity;
    }
}

class Program6{
    public static void Main(String[] args){
        VegItem veg = new VegItem("Veg Burger", 5, 2);
        veg.GetItemDetails();
    }
}



