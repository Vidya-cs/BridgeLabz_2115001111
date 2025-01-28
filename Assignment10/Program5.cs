using System;

class Program5{
	
    public static bool IsPrime(int number){
        if (number <= 1){
            return false;
        }
        for(int i=2; i < number; i++){
            if (number%i==0){
                return false;
            }
        }
        return true;
    }

    public static bool IsNeon(int number){
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0){
            sumOfDigits += square % 10;
            square = square / 10;
        }
        return sumOfDigits == number;
    }

    public static bool IsSpy(int number){
        int sum = 0;
        int product = 1;
        while (number > 0){
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number = number / 10;
        }
        return sum == product;
    }

    public static bool IsAutomorphic(int number){
        int square = number * number;
        while (square> 0){
            if (square%10!=number%10){
                return false;
            }
            square = square / 10;
            number = number / 10;
        }
        return true;
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    public static void Main(string[] args){
        int number = 7;

        //prime number
        bool isPrime = IsPrime(number);
        Console.WriteLine("Is the number prime? " + isPrime);

        //neon number
        bool isNeon = IsNeon(number);
        Console.WriteLine("Is the number neon? " + isNeon);

        //spy number
        bool isSpy = IsSpy(number);
        Console.WriteLine("Is the number spy? " + isSpy);

        //automorphic number
        bool isAutomorphic = IsAutomorphic(number);
        Console.WriteLine("Is the number automorphic? " + isAutomorphic);

        //buzz number
        bool isBuzz = IsBuzz(number);
        Console.WriteLine("Is the number buzz? " + isBuzz);
    }
}
