using System;

class Program5{
	public static void Main(String[] args){
		int pen= int.Parse(Console.ReadLine());
		int students= int.Parse(Console.ReadLine());
		int equal= pen/students;
		int undis= pen%students;
		Console.WriteLine("The Pen Per Student is "+ equal+ " and the remaining pen not distributed is "+ undis);
	}
}