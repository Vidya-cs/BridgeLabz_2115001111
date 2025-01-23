using System;

class Program3{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		int d=num, sum=0;
		
		//Finding the sum of digits
		while(d!=0){
			sum+= d%10;
			d/=10;
		}
		
		//Checking whether it is Harshad number or not
		
		if(num % sum == 0){
			Console.WriteLine("Yes it is Harshad Number");
		}
		else{
			Console.WriteLine("No it is not a Harshad Number");
		}
	}
}

		