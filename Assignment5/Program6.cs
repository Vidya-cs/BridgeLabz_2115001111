using System;

class Program6
{
    public static void Main(string[] args){
		
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();

        switch(op){
            case "+":
                Console.WriteLine(first + second);
                break;

            case "-":
                Console.WriteLine(first - second);
                break;

            case "*":
                Console.WriteLine(first * second);
                break;

            case "/":
                //Checking for division by zero
                if(second != 0){
                    Console.WriteLine(first / second);
                }
                else{
                    Console.WriteLine("Division by zero is not Possible");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
