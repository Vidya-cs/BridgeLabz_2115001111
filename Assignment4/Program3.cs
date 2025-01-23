using System;

class Program3
{
    public static void Main(string[] args){
		
        int number = int.Parse(Console.ReadLine());

        //Checking if the number is positive
        if (number > 0)
        {
            int i = 0;

            while (i <= number)
            {
                // Checking conditions for Fizz, Buzz, and FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
				
                i++;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
