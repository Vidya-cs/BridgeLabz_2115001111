using System;

class Program5
{
    public static void Main(string[] args){
		
        int ageAmar = int.Parse(Console.ReadLine());
        int heightAmar = int.Parse(Console.ReadLine());
		
        int ageAkbar = int.Parse(Console.ReadLine());
        int heightAkbar = int.Parse(Console.ReadLine());

        int ageAnthony = int.Parse(Console.ReadLine());
        int heightAnthony = int.Parse(Console.ReadLine());

        //Finding the youngest one
		int minAge = ageAmar < ageAkbar && ageAmar < ageAnthony ? ageAmar : ageAkbar < ageAnthony ? ageAkbar : ageAnthony;

        if (minAge == ageAmar)
        {
            Console.WriteLine("Youngest is Amar");
        }
        else if (minAge == ageAkbar)
        {
            Console.WriteLine("Youngest is Akbar");
        }
        else
        {
            Console.WriteLine("Youngest is Anthony");
        }

        //Finding the tallest one
        int maxHeight = heightAmar > heightAkbar && heightAmar > heightAnthony ? heightAmar: heightAkbar > heightAnthony ? heightAkbar : heightAnthony;

        if (maxHeight == heightAmar)
        {
            Console.WriteLine("Amar is tallest");
        }
        else if (maxHeight == heightAkbar)
        {
            Console.WriteLine("Akbar is tallest");
        }
        else
        {
            Console.WriteLine("Anthony is tallest");
        }
    }
}
