using System;

class Program3{
    public static void Main(String[] cs){
		
		//taking current date
        DateTime today = DateTime.Now;


        Console.WriteLine("In format dd/MM/yyyy " + today.ToString("dd/MM/yyyy"));
        Console.WriteLine("In format yyyy-MM-dd " + today.ToString("yyyy-MM-dd"));
        Console.WriteLine("In format EEE, MMM dd, yyyy " + today.ToString("ddd, MMM dd, yyyy"));
    }
}
