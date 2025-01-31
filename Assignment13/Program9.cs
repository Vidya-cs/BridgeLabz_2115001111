using System;

class Program{

    static double Add(double a,double b){
        return a+b;
    }

    static double Subtract(double a,double b){
        return a-b;
    }

    static double Multiply(double a,double b){
        return a*b;
    }

    static double Divide(double a,double b){
        return a/b;
    }
	
	public static void Main(String[] args){
		
        Console.WriteLine("Choose an operation to perform");
        Console.WriteLine("1 for Addition");
        Console.WriteLine("2 for Subtraction");
        Console.WriteLine("3 for Multiplication");
        Console.WriteLine("4 for Division");

        string choice= Console.ReadLine();

        Console.WriteLine("Enter first number");
        double num1= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number");
        double num2= Convert.ToDouble(Console.ReadLine());

        if(choice=="1"){
            double result = Add(num1, num2);
            Console.WriteLine("The result of addition is " + result);
        }
        else if(choice=="2"){
            double result= Subtract(num1, num2);
            Console.WriteLine("The result of subtraction is " + result);
        }
        else if(choice=="3"){
            double result = Multiply(num1, num2);
            Console.WriteLine("The result of multiplication is " + result);
        }
        else if(choice=="4"){
            if(num2!=0){
                double result= Divide(num1, num2);
                Console.WriteLine("The result of division is " + result);
            }
            else{
                Console.WriteLine("We can't divide a number by zero");
            }
        }
        else{
            Console.WriteLine("Invalid choice");
        }
    }
}
