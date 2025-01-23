using System;

class Program12
{
    public static void Main(string[] args){
		
        int n = int.Parse(Console.ReadLine());

        //Check if the number is natural number
        if (n >= 0){

			//sum using the formula
			int sumFormula = n * (n + 1) / 2;

			//sum using a while loop
			int sumLoop = 0;
			int i = 1;
			while (i <= n)
			{
				sumLoop += i;
				i++;
			}
			
			//Comparing and printing if they are same
			if (sumFormula == sumLoop)
			{
				Console.WriteLine("Result matches for both = " + sumLoop);
			}
			else
			{
				Console.WriteLine("Results do not match ");
			}
		}
		else{
			Console.WriteLine("Not a Natural Number");
		}
    }
}
