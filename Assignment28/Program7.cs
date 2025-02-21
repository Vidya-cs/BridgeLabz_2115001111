using System;

class Program7{
    static void Main(string[] args){
        try{
            Console.Write("Enter numerator ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator ");
            int den = int.Parse(Console.ReadLine());
            Console.WriteLine("Result= " + (num/den));
        }
        catch (DivideByZeroException){
            Console.WriteLine("Cannot divide by zero");
        }
        finally{
            Console.WriteLine("Finally block is here");
        }
    }
}
