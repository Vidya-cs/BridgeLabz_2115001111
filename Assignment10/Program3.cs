using System;

class Program3{
	
    public static int CountDigits(int number){
        int count = 0;
        while (number > 0)
        {
            number = number / 10;
            count++;
        }
        return count;
    }

    public static void StoreDigits(int number, ref int[] digits){
        int i = 0;
        while (number > 0)
        {
            digits[i] = number % 10;
            number = number / 10;
            i++;
        }
    }

    public static int SumOfDigits(int[] digits){
        int sum = 0;
        for (int i = 0; i < digits.Length; i++){
            sum += digits[i];
        }
        return sum;
    }

    public static double SumOfSquares(int[] digits)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sumOfSquares += Math.Pow(digits[i], 2);
        }
        return sumOfSquares;
    }

    // Method to check if a number is a Harshad number
    public static bool IsHarshad(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        if (number % sum == 0)
        {
            return true;
        }
        return false;
    }

    //to find the frequency of each digit in the number
    public static void DigitFrequency(int[] digits){
        int[,] frequency = new int[10, 2]; // First column: digit, second column: frequency
        for (int i = 0; i < digits.Length; i++)
        {
            frequency[digits[i], 1]++;
        }

        Console.WriteLine("Digit Frequency:");
        for(int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine("Digit " + i + " appears " + frequency[i, 1] + " times");
            }
        }
    }

    public static void Main(string[] args){
        int number = 12345;
        int digitCount = CountDigits(number);
        int[] digits = new int[digitCount];

        StoreDigits(number, ref digits);

        Console.WriteLine("Number of digits in " + number + " is " + digitCount);

        int sumOfDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumOfDigits);

        double sumOfSquares = SumOfSquares(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        bool isHarshad = IsHarshad(number, digits);
        Console.WriteLine("Is the number Harshad? " + isHarshad);

        // Display digit frequency
        DigitFrequency(digits);
    }
}
