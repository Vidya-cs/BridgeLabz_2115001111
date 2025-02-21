using System;

class Program2{
    public static void Main(string[] args){
        try{
            Console.Write("Enter numerator ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator ");
            int den = Convert.ToInt32(Console.ReadLine());
            int result = num/den;
            Console.WriteLine("Result= " + result);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input enter a number");
        }
    }
}
