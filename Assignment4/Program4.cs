using System;

class Program4
{
    public static void Main(string[] args){
		
        double weight = double.Parse(Console.ReadLine());
		
        double heightCm = double.Parse(Console.ReadLine());

        //Converting height from cm to m
        double heightMeters = heightCm / 100;

        //BMI
        double bmi = weight / (heightMeters * heightMeters);

        //Weight status based on BMI
        if (bmi <= 18.4)
        {
            Console.WriteLine("Underweight.");
        }
        else if (bmi > 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Normal weight.");
        }
        else if (bmi >= 25 && bmi < 39.9)
        {
            Console.WriteLine("Overweight.");
        }
        else
        {
            Console.WriteLine("Obese.");
        }
    }
}
