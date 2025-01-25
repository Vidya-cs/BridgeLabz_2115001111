using System;

class Program10
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] frequency = new int[10];

        while (number > 0)
        {
            int digit = number % 10;
            frequency[digit]++; 
            number /= 10;
        }

        //Printing the frequency of each digit
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " has Frequency " + frequency[i]);
            }
        }
    }
}
