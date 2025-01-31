using System;

class Program1{
	
    public static void Main(String[] args){
		
        DateTimeOffset utc = DateTimeOffset.UtcNow;
        DateTimeOffset gmtTime = utc;

        //IST
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utc, istZone);

        //PST
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utc, pstZone);

        //Displaying the results
		
        Console.WriteLine("GMT " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("IST " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("PST " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
