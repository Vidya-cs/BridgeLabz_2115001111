using System;

class Program1
{
    public static void Main(string[] args){
	
        int number = int.Parse(Console.ReadLine());

        // Check if the number is greater than 1
        if (number > 1){

			// Assume the number is prime
			bool isPrime = true;
		
			for (int i = 2; i <= number/2; i++)
			{
				if (number % i == 0)
				{
					// Number is divisible by i, hence not prime
					isPrime = false;
					break;
				}
			}
		
			if (isPrime)
			{
				Console.WriteLine(number + " is a prime number");
			}
			else
			{
				Console.WriteLine(number + " is not a prime number");
			}
		}
		else{
			Console.WriteLine(number + " is not a prime number");
		}
    }
}
