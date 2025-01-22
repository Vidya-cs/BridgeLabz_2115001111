using System;

class Program16
{
    public static void Main(string[] args){
		
        int students = int.Parse(Console.ReadLine());

        // Calculating the maximum number of handshakes 
        int maximumHandshakes = (students * (students - 1)) / 2;

        // Displaying the result
        Console.WriteLine("The maximum number of handshakes among " + students + " students is " + maximumHandshakes);
    }
}
