using System;
using System.Collections.Generic;

class Program19{
    static void Main(string[] args){
        Dictionary<string, double> cart = new Dictionary<string, double>();
        SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>();
        List<string> orderOfItems = new List<string>();
        cart["Laptop"] = 1000;
        cart["Phone"] = 800;
        cart["Headphones"] = 150;
        cart["Tablet"] = 500;
        List<string> keys = new List<string>(cart.Keys);
        for (int i = 0; i < keys.Count; i++){
            sortedCart[keys[i]] = cart[keys[i]];
            orderOfItems.Add(keys[i]);
        }

        Console.WriteLine("Shopping cart");
        List<string> cartKeys = new List<string>(cart.Keys);
        for (int i = 0; i < cartKeys.Count; i++){
            Console.WriteLine(cartKeys[i] + ": $" + cart[cartKeys[i]]);
        }

        Console.WriteLine("Sorted by Price:");
        List<string> sortedKeys = new List<string>(sortedCart.Keys);
        for (int i = 0; i < sortedKeys.Count; i++){
            Console.WriteLine(sortedKeys[i] + ": $" + sortedCart[sortedKeys[i]]);
        }

        Console.WriteLine("Order of items added");
        for (int i = 0; i < orderOfItems.Count; i++){
            Console.Write(orderOfItems[i] + " ");
        }
    }
}
