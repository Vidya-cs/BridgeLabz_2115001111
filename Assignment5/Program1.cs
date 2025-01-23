using System;

class Program1{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		int d=num, sum=0;
		
		//Finding the sum of digits cube
		while(d!=0){
			int rem= d%10;
			sum+= (int)Math.Pow(rem, 3);
			d/=10;
		}
		
		//Checking whether it is Armstrong number or not
		
		if(sum==num){
			Console.WriteLine("Yes it is Armstrong Number");
		}
		else{
			Console.WriteLine("No it is not Armstrong Number");
		}
	}
}

		