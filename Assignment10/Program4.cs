using System;

class Program4{

    public static int CountDigits(int number){
        int count = 0;
        while (number > 0){
            number = number / 10;
            count++;
        }
        return count;
    }

    public static void StoreDigits(int number, ref int[] digits){
        int i = 0;
        while (number > 0){
            digits[i] = number % 10;
            number = number / 10;
            i++;
        }
    }

    public static void ReverseDigits(ref int[] digits)
    {
        int start = 0;
        int end = digits.Length - 1;
        while (start < end)
        {
            int temp = digits[start];
            digits[start] = digits[end];
            digits[end] = temp;
            start++;
            end--;
        }
    }

    public static bool CompareArrays(int[] array1, int[] array2){
        if (array1.Length != array2.Length){
            return false;
        }

        for (int i = 0; i < array1.Length; i++){
            if (array1[i] != array2[i]){
                return false;
            }
        }
        return true;
    }

    public static bool IsPalindrome(int number, int[] digits){
        int[] reversedDigits = new int[digits.Length];
        Array.Copy(digits, reversedDigits, digits.Length);
        ReverseDigits(ref reversedDigits);

        return CompareArrays(digits, reversedDigits);
    }

    public static bool IsDuckNumber(int number, int[] digits){
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != 0){
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args){
        int number = 10230; // Sample number to check
        int digitCount = CountDigits(number);
        int[] digits = new int[digitCount];

        //Store digits in the array
        StoreDigits(number, ref digits);

        // Display count of digits
        Console.WriteLine("Number of digits in " + number + " is " + digitCount);

        // Check if the number is a palindrome
        bool isPalindrome = IsPalindrome(number, digits);
        Console.WriteLine("Is the number a palindrome? " + isPalindrome);

        // Check if the number is a duck number
        bool isDuckNumber = IsDuckNumber(number, digits);
        Console.WriteLine("Is the number a duck number? " + isDuckNumber);
    }
}
