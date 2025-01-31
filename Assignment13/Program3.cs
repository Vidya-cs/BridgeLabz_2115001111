using System;

class Program3{
	
    public static bool IsPrime(int num){
        if(num<=1)
            return false;
        
        for(int i= 2; i<num; i++){
            if(num%i==0)
                return false;
        }
        return true;
    }

    public static void Main(String[] args){
		
        Console.WriteLine("Enter a number");
        int number= int.Parse(Console.ReadLine());

        bool result= IsPrime(number);

        if(result==true)
            Console.WriteLine("The number is prime");
        else
            Console.WriteLine("The number is not prime");
    }
}
