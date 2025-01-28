using System;

class Program8{
	
    public static string GetMonthName(int month){
        string[] months = {
            "January", "February", "March", "April", "May", "June", 
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1]; 
    }

    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    //to get the number of days in a given month
    public static int GetDaysInMonth(int month, int year){
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year)){
            return 29;
        }

        return daysInMonth[month - 1];  
    }

    //to get the first day of the month 
    public static int GetFirstDayOfMonth(int month, int year){
        if (month < 3)
        {
            month += 12;
            year--;
        }

        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;

        return d0; 
    }
	
    public static void DisplayCalendar(int month, int year)
    {
        // Get the month name and number of days in the month
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);

        // Display the month and year
        Console.WriteLine(monthName + "  " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Get the first day of the month
        int firstDay = GetFirstDayOfMonth(month, year);

        // Add spaces for indentation based on the first day of the month
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");  // Empty spaces before the first day
        }

        // Display the days of the month
        for (int day = 1; day <= daysInMonth; day++){
			
            Console.Write(day);

            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }

    public static void Main(String[] args)
    {
        // Take user input for month and year
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        // Display the calendar for the entered month and year
        DisplayCalendar(month, year);
    }
}
