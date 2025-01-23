using System;

class Program8
{
    public static void Main(string[] args){
		
        int num = int.Parse(Console.ReadLine());

        // Loop to find all factors of the number
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
