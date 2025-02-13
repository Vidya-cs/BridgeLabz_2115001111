using System;

class Item
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public Item Next;

    public Item(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private Item head;

    public void AddItemAtEnd(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemID, quantity, price);
        if (head == null)
        {
            head = newItem;
            return;
        }
        Item temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newItem;
    }

    public void AddItemAtBeginning(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemID, quantity, price);
        newItem.Next = head;
        head = newItem;
    }

    public void AddItemAtPosition(string itemName, int itemID, int quantity, double price, int position)
    {
        if (position == 1)
        {
            AddItemAtBeginning(itemName, itemID, quantity, price);
            return;
        }
        Item newItem = new Item(itemName, itemID, quantity, price);
        Item temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        newItem.Next = temp.Next;
        temp.Next = newItem;
    }

    public void RemoveItem(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        if (head.ItemID == itemID)
        {
            head = head.Next;
            return;
        }
        Item temp = head, prev = null;
        while (temp != null && temp.ItemID != itemID)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }
        prev.Next = temp.Next;
    }

    public Item SearchItemByID(int itemID)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public Item SearchItemByName(string itemName)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateItemQuantity(int itemID, int newQuantity)
    {
        Item item = SearchItemByID(itemID);
        if (item != null)
        {
            item.Quantity = newQuantity;
            Console.WriteLine("Quantity updated successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public double CalculateTotalInventoryValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        return totalValue;
    }

    public void SortByItemName()
    {
        if (head == null || head.Next == null) return;

        Item current, index;
        string tempName;
        int tempID, tempQuantity;
        double tempPrice;

        for (current = head; current != null; current = current.Next)
        {
            for (index = current.Next; index != null; index = index.Next)
            {
                if (string.Compare(current.ItemName, index.ItemName) > 0)
                {
                    tempName = current.ItemName;
                    tempID = current.ItemID;
                    tempQuantity = current.Quantity;
                    tempPrice = current.Price;

                    current.ItemName = index.ItemName;
                    current.ItemID = index.ItemID;
                    current.Quantity = index.Quantity;
                    current.Price = index.Price;

                    index.ItemName = tempName;
                    index.ItemID = tempID;
                    index.Quantity = tempQuantity;
                    index.Price = tempPrice;
                }
            }
        }
    }

    public void SortByPrice()
    {
        if (head == null || head.Next == null) return;

        Item current, index;
        string tempName;
        int tempID, tempQuantity;
        double tempPrice;

        for (current = head; current != null; current = current.Next)
        {
            for (index = current.Next; index != null; index = index.Next)
            {
                if (current.Price > index.Price)
                {
                    tempName = current.ItemName;
                    tempID = current.ItemID;
                    tempQuantity = current.Quantity;
                    tempPrice = current.Price;

                    current.ItemName = index.ItemName;
                    current.ItemID = index.ItemID;
                    current.Quantity = index.Quantity;
                    current.Price = index.Price;

                    index.ItemName = tempName;
                    index.ItemID = tempID;
                    index.Quantity = tempQuantity;
                    index.Price = tempPrice;
                }
            }
        }
    }

    public void DisplayAllItems()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine("Item ID: " + temp.ItemID + ", Name: " + temp.ItemName + ", Quantity: " + temp.Quantity + ", Price: $" + temp.Price);
            temp = temp.Next;
        }
    }
}

class Program4
{
    public static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddItemAtEnd("Laptop", 101, 5, 1000);
        inventory.AddItemAtEnd("Mouse", 102, 20, 25);
        inventory.AddItemAtBeginning("Keyboard", 103, 10, 50);
        inventory.AddItemAtPosition("Monitor", 104, 8, 200, 2);

        Console.WriteLine("\nAll Inventory Items:");
        inventory.DisplayAllItems();

        Console.WriteLine("\nTotal Inventory Value: $" + inventory.CalculateTotalInventoryValue());

        Console.WriteLine("\nSearching for Item ID 102:");
        Item foundItem = inventory.SearchItemByID(102);
        if (foundItem != null)
            Console.WriteLine("Found Item: " + foundItem.ItemName);
        else
            Console.WriteLine("Item not found.");

        Console.WriteLine("\nUpdating Quantity for Item ID 101:");
        inventory.UpdateItemQuantity(101, 10);

        Console.WriteLine("\nSorting Inventory by Name:");
        inventory.SortByItemName();
        inventory.DisplayAllItems();

        Console.WriteLine("\nSorting Inventory by Price:");
        inventory.SortByPrice();
        inventory.DisplayAllItems();

        Console.WriteLine("\nRemoving Item ID 102:");
        inventory.RemoveItem(102);

        Console.WriteLine("\nUpdated Inventory:");
        inventory.DisplayAllItems();
    }
}
