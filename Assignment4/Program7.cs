using System;

class Program7
{
    public static void Main(string[] args){
		
        int num = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        int result = 1;

        //Calculating the power using a for loop
        for (int i = 1; i <= power; i++)
        {
            result *= num;
        }

        //Displaying the result
        Console.WriteLine(num + " power " + power + " is " + result);
    }
}
