using System;

class Program4{
    public static void Main(string[] args){
        int[] numbers = {1, 2, 3, 4, 5};

        try{
            Console.Write("Enter index ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Value at index " + index + " = " + numbers[index]);
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine("Invalid index");
        }
        catch (NullReferenceException){
            Console.WriteLine("Array is not initialized");
        }
    }
}
