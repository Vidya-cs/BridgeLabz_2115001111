
using System;

class Order{
    public int OrderId;
    public string OrderDate;

    public Order(int orderId, string orderDate){
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate);
        Console.WriteLine("Order Status: " + GetOrderStatus());
    }
}

class ShippedOrder : Order {
    public string TrackingNumber;

    public ShippedOrder(int orderId, string orderDate, string trackingNumber) 
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped, Tracking No: " + TrackingNumber;
    }
}

class DeliveredOrder : ShippedOrder{
    public string DeliveryDate;

    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) 
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered on " + DeliveryDate;
    }
}

class Program6
{
    public static void Main()
    {
        Order order = new Order(1001, "2024-02-08");
        order.DisplayOrderDetails();

        Console.WriteLine();

        ShippedOrder shipped = new ShippedOrder(1002, "2024-02-07", "TRK12345");
        shipped.DisplayOrderDetails();

        Console.WriteLine();

        DeliveredOrder delivered = new DeliveredOrder(1003, "2024-02-05", "TRK67890", "2024-02-10");
        delivered.DisplayOrderDetails();
    }
}



