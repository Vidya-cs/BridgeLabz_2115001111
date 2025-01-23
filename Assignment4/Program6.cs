using System;

class Program6
{
    public static void Main(string[] args){
		
        int number = int.Parse(Console.ReadLine());
		
        int fact = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            //Checking number is perfectly divisible by i
            if (number % i == 0)
            {
                fact = i; 
                break; 
            }
        }

        //Displaying the greatest factor
        Console.WriteLine("The greatest factor of "+ number + " beside itself is "+ fact);
    }
}
