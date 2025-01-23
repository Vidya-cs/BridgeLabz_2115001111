using System;

class Program5{
	public static void Main(String[] args){
		int age= int.Parse(Console.ReadLine());
		
		//Checking person is eligible for vote or not
		
		if(age>=18){
			Console.WriteLine("The person's age is " + age + " and can vote");
		}
		else{
			Console.WriteLine("The person's age is " + age + " and cannot vote");
		}
	}
}