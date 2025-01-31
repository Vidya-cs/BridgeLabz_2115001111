using System;

class Program4{

    public static void Main(String[] args){
	
        Console.WriteLine("Enter first date in yyyy-MM-dd format ");
        String userDate1 = Console.ReadLine();
        
        Console.WriteLine("Enter second date in yyyy-MM-dd format ");
        String userDate2 = Console.ReadLine();

        DateTime date1 = Convert.ToDateTime(userDate1);
        DateTime date2 = Convert.ToDateTime(userDate2);

       
        if(date1<date2){
            Console.WriteLine("First date is before the second date");
        }
        else if(date1>date2){
            Console.WriteLine("First date is after the second date");
        }
        else{
            Console.WriteLine("Both dates are the same");
        }
    }
}
