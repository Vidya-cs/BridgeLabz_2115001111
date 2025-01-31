using System;

class Program2{
	
	public static int[] Input(){
		
		Console.WriteLine("Enter 3 numbers");
		int num1= int.Parse(Console.ReadLine());
		int num2= int.Parse(Console.ReadLine());
		int num3= int.Parse(Console.ReadLine());
		
		return new int[] {num1, num2, num3};
	}
	
	public static void FindMaximum(int num1, int num2, int num3){
		
		int max= (num1>num2)?((num1>num3)?num1:num3):((num2>num3)?num2:num3);
		
		Console.WriteLine("Largest among the three is " + max);
	}

	
	public static void Main(String[] args){
		
		int[] ar= Input();
		int num1= ar[0];
		int num2= ar[1];
		int num3= ar[2];
		
		FindMaximum(num1, num2, num3);
	}
}