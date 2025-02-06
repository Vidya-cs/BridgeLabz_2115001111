using System;


class Product{
    string Name { get; set; }
    decimal Price { get; set; }

    public Product(string name, decimal price){
        Name= name;
        Price= price;
    }
}


class Order{
    int OrderId { get; set; }
    Customer Customer { get; set; }
    List<Product> Products { get; set; }
    decimal TotalAmount { get; private set; }

    public Order(int orderId, Customer customer){
        OrderId= orderId;
        Customer= customer;
        Products= new List<Product>();
        TotalAmount= 0;
    }

    public void AddProduct(Product product){
        Products.Add(product);
        TotalAmount += product.Price;
    }

    public void DisplayOrderDetails(){
        Console.WriteLine($"Order ID {OrderId}, Customer {Customer.Name}");
        Console.WriteLine("Products");
        foreach(var product in Products){
            Console.WriteLine($"{product.Name}  ${product.Price}");
        }
        Console.WriteLine($"Total Amount ${TotalAmount}");
    }
}

class Customer{
    string Name { get; set; }
    List<Order> Orders { get; set; }

    public Customer(string name){
        Name= name;
        Orders= new List<Order>();
    }

    public void PlaceOrder(Order order){
        Orders.Add(order);
    }

    public void ViewOrders(){
        Console.WriteLine($"Customer: {Name} - Orders:");
        foreach(var order in Orders){
            order.DisplayOrderDetails();
        }
    }
}

class Program7{
    public static void Main(String[] args){
        Customer customer = new Customer("John Doe");
        Order order1 = new Order(1, customer);
        Order order2 = new Order(2, customer);
        Product product1 = new Product("Laptop", 999.99m);
        Product product2 = new Product("Mouse", 49.99m);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product2);

        customer.PlaceOrder(order1);
        customer.PlaceOrder(order2);

        customer.ViewOrders();
    }
}