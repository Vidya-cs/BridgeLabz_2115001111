using System;

class Program6{
    static double CalculateInterest(double amount, double rate, int years){
        if(amount<0 || rate<0)
            throw new ArgumentException("Amount and rate must be positive.");
        return amount*rate*years/100;
    }

    public static void Main(string[] args){
        try{
			
			//taking inputs
            Console.Write("Enter amount ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter years ");
            int years = int.Parse(Console.ReadLine());
            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest= " + interest);
        }
        catch (ArgumentException ex){
            Console.WriteLine(ex.Message);
        }
    }
}
