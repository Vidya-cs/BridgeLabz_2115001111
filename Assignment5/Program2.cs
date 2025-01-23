using System;

class Program2{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		int count=0;
		
		//Counting number of digits
		while(num!=0){
			count++;
			num/=10;
		}
		
		//Displaying the result
		Console.WriteLine("Total number of digit is " + count);
	}
}

		