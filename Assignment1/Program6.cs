using System;

class Program6
{
    public static void Main(String[] args)
    {
        // Read the fees amount as input from the user
        int fees = int.Parse(Console.ReadLine());
        
        // Calculate 10% discount on the fees
        double discount = fees * 0.1;
        
        // Calculate the final fee after subtracting the discount
        double discountVal = fees - discount;
        
        // Display the discount amount and the final discounted fee
        Console.WriteLine("The discount is INR " + discount + " and final discounted fee is INR " + discountVal);
    }
}
