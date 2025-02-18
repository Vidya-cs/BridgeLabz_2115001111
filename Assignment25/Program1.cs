using System;
using System.Collections.Generic;

abstract class WarehouseItem{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price){
        Name = name;
        Price = price;
    }

    public abstract void Display();
}

class Electronics : WarehouseItem{
    public string Brand { get; set; }

    public Electronics(string name, double price, string brand) : base(name, price){
        Brand = brand;
    }

    public override void Display(){
        Console.WriteLine($"[Electronics] Name: {Name}, Price: {Price}, Brand: {Brand}");
    }
}

class Groceries : WarehouseItem{
    public string ExpiryDate { get; set; }

    public Groceries(string name, double price, string expiryDate) : base(name, price){
        ExpiryDate = expiryDate;
    }

    public override void Display(){
        Console.WriteLine($"[Groceries] Name: {Name}, Price: {Price}, Expiry: {ExpiryDate}");
    }
}

class Furniture : WarehouseItem{
    public string Material { get; set; }
    public Furniture(string name, double price, string material) : base(name, price){
        Material = material;
    }

    public override void Display(){
        Console.WriteLine($"[Furniture] name: {Name}, price: {Price}, material: {Material}");
    }
}

class Storage<T> where T : WarehouseItem{
    private List<T> items = new List<T>();
	
    public void AddItem(T item){
        items.Add(item);
    }

    public void DisplayItems(){
        Console.WriteLine("Warehouse Inventory");
        foreach (var item in items){
            item.Display();
        }
    }
}

class Program{
    public static void Main(string[] args){
		
        Storage<Electronics> electronicStorage = new Storage<Electronics>();
        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
		
		//electronic
        electronicStorage.AddItem(new Electronics("Laptop", 1000, "Dell"));
        electronicStorage.AddItem(new Electronics("Smartphone", 800, "Samsung"));
		
		//grocery
        groceryStorage.AddItem(new Groceries("Milk", 2.5, "2025-06-01"));
        groceryStorage.AddItem(new Groceries("Bread", 1.2, "2025-02-20"));
		
		//furniture
        furnitureStorage.AddItem(new Furniture("Chair", 50, "Wood"));
        furnitureStorage.AddItem(new Furniture("Table", 100, "Metal"));

        electronicStorage.DisplayItems();
        groceryStorage.DisplayItems();
        furnitureStorage.DisplayItems();
    }
}
