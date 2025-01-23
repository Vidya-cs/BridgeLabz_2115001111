using System;

class Program18{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		//Printing the table as asked
		
		for(int i=6; i<=9; i++){
			Console.WriteLine(num + " * " + i + " = " + num * i + "\n");
		}
	}
}