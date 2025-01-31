using System;

class Program2{
	
    public static void Main(){
		
        Console.WriteLine("Enter date in yyyy-MM-dd format ");
        string date = Console.ReadLine();

        DateTime oldDate = Convert.ToDateTime(date);

        //Adding 7 days, 1 month, 2 years
        DateTime newDate = oldDate.AddDays(7);
        newDate = newDate.AddMonths(1);
        newDate = newDate.AddYears(2);

        newDate = newDate.AddDays(-21);

        //Displaying result
        Console.WriteLine("NEW DATE " + newDate.ToString("yyyy-MM-dd"));
    }
}
