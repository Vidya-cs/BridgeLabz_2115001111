using System;

class Program9
{
    public static void Main(string[] args){
		
        int num = int.Parse(Console.ReadLine());

        //Loop from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % num == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
