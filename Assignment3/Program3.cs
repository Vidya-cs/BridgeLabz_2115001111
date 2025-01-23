using System;

class Program3{
	public static void Main(String[] args){
		int num1= int.Parse(Console.ReadLine());
		int num2= int.Parse(Console.ReadLine());
		int num3= int.Parse(Console.ReadLine());
		
		if(num1 > num2 && num1 > num3){
			Console.WriteLine("Is the first number the largest ?  Yes. \nIs the second number the largest ? No. \nIs the third number the largest ? No.");
		}
		else if(num2 > num1 && num2 > num3){
			Console.WriteLine("Is the first number the largest ?  No. \nIs the second number the largest ? Yes.\n Is the third number the largest ? No.");
		}
		else{
			Console.WriteLine("Is the first number the largest ?  No. \nIs the second number the largest ? No. \nIs the third number the largest ? Yes.");
		}
	}
}