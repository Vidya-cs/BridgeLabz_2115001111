using System;

class Program4{
	public static void Main(String[] args){
		int sp= int.Parse(Console.ReadLine());
		int cp= int.Parse(Console.ReadLine());
		
		Console.WriteLine("The Cost Price is INR "+ cp + " and Selling Price is INR "+ sp);
		
		int diff= Math.Abs(sp-cp);
		double percentage = (double)diff / cp * 100;
		
		if(sp>cp){
			Console.WriteLine("The Profit is INR "+ diff + " and the Profit Percentage is "+ percentage);
		}
		else{
			Console.WriteLine("The Loss is INR "+ diff + " and the Loss Percentage is "+ percentage);
		}
	}
}