using System;

class Program9{
    public static void Main(string[] args){
        int[] numbers = {10, 20, 30, 40, 50};
        try{
            Console.WriteLine("Enter index ");
            int index = int.Parse(Console.ReadLine());

            try{
                int value = numbers[index];
                Console.Write("Enter divisor ");
                int divisor = int.Parse(Console.ReadLine());

                try{
                    int result = value/divisor;
                    Console.WriteLine("Result= " + result);
                }
                catch (DivideByZeroException){
                    Console.WriteLine("Cannot divide by zero");
                }
            }
            catch (IndexOutOfRangeException){
                Console.WriteLine("Invalid array index");
            }
        }
        catch (FormatException){
            Console.WriteLine("Enter a valid number");
        }
    }
}
