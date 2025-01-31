using System;

class Program7{
	
    public static int FindGCD(int a, int b){
        while(b!=0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static int FindLCM(int a, int b){
        return (a*b)/FindGCD(a,b);
    }

    public static void Main(String[] args){
		
        Console.WriteLine("Enter first number");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(num1,num2);
        int lcm = FindLCM(num1,num2);

        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is " + lcm);
    }
}
