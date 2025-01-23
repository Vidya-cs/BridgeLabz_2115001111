using System;

class Program4
{
    public static void Main(string[] args){
		
        int number = int.Parse(Console.ReadLine());
		
        int sum = 0;

        //Find divisors and calculate their sum
        for(int i= 1; i< number; i++)
        {
            if(number % i == 0)
            {
                sum+= i;
            }
        }

        //Checking the number is Abundant or not
        if(sum > number){
            Console.WriteLine("Number is an Abundant Number");
        }
        else{
            Console.WriteLine("Number is Not an Abundant Number");
        }
    }
}
