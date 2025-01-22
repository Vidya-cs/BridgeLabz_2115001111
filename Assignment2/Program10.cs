using System;

class Program10{
	public static void Main(String[] args){
		int numberOfChocolates= int.Parse(Console.ReadLine());
		int numberOfChildren= int.Parse(Console.ReadLine());
		
		//Calculating 
		
		int eachChildGets= numberOfChocolates / numberOfChildren;
		int remainingChoc= numberOfChocolates % numberOfChildren;
		
		//Displaying Result
		
		Console.WriteLine("The number of chocolates each child gets is " + eachChildGets + " and the number of remaining chocolates is " + remainingChoc);
	}
}
