using System;

class Program5
{
    static void Main(String[] args){

        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        //Checking if the inputs are valid or not
        if ((month < 1 || month > 12) && (day < 1 || day > 31) && (year < 1582)){
            Console.WriteLine("Invalid Input Given");
        }
		
        //Calculations
		
		else{
			int y0 = year - (14 - month) / 12;
			int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
			int m0 = month + 12 * ((14 - month) / 12) - 2;
			int d0 = (day + x + (31 * m0) / 12) % 7;
			
			//Displaying the result
			Console.WriteLine(d0);
		}
    }
}