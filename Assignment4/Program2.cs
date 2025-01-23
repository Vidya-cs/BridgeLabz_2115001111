using System;

class Program2
{
    public static void Main(string[] args){
	
        int number = int.Parse(Console.ReadLine());
		
		if(number > 0){
        
			for (int i = 0; i <= number; i++)
			{
				//Checking conditions for Fizz, Buzz, and FizzBuzz
				
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
			}
        }
    }
}
