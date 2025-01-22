using System;

class Program7
{
    public static void Main(string[] args){
		
        int num1 = int.Parse(Console.ReadLine());
		int num2= int.Parse(Console.ReadLine());

        //Swapping
		 
		num1= num1+num2;
		num2= num1-num2;
		num1= num1-num2;
		
        // Displaying the result
		
		Console.WriteLine(" The Swapped numbers are num2= " + num2 + " and num1= " + num1);
    }
}
