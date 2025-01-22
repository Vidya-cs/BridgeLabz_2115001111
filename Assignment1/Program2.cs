using System;

class Program2{
	public static void Main(String[] args){
	int maths= int.Parse(Console.ReadLine());
	int physics= int.Parse(Console.ReadLine());
	int chem= int.Parse(Console.ReadLine());
	double avg= (maths+physics+chem)/3;
	Console.WriteLine(avg);
	}
}
		