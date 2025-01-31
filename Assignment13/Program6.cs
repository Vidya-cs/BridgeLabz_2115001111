using System;

class Program6{
	
    public static int FindFact(int num){
		
        if(num==0 || num==1){
            return 1;
        }
        return num * FindFact(num-1);
    }

    public static void Main(String[] args){
		
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        int result = FindFact(number);

        Console.WriteLine("Factorial of " + number + " is " + result);
    }
}
