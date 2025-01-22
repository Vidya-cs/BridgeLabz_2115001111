using System;

class Program6
{
    public static void Main(string[] args){
		
        double salary = double.Parse(Console.ReadLine());
		double bonus= double.Parse(Console.ReadLine());

        //Calculating total salary
			
		double totalSalary= salary + bonus;
			
        // Displaying the result
        Console.WriteLine("The salary is INR " + salary + " bonus is INR " + bonus + ".Hence Total Income is INR " + totalSalary);
    }
}
