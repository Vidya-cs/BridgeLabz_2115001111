using System;

class Program2{

    public static int CountDigits(int num){
        int count = 0;
        while (num > 0)
        {
            count++;
            num /= 10;
        }
        return count;
    }

    public static int[] GetDigits(int num){
        int count = CountDigits(num);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int num){
        while (num > 0){
            if (num % 10 == 0)
                return true;
            num /= 10;
        }
        return false;
    }

    // Method to check if a number is an Armstrong number
    public static bool IsArmstrong(int num)
    {
        int count = CountDigits(num);
        int sum = 0, temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            int power = 1;
            for (int i = 0; i < count; i++)
                power *= digit;
            sum += power;
            temp /= 10;
        }
        return sum == num;
    }

    // Method to find largest and second largest digit
    public static int[] FindLargestTwo(int[] digits)
    {
        int largest = int.MinValue, secondLargest = int.MinValue;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }
        return new int[] { largest, secondLargest };
    }

    // Method to find smallest and second smallest digit
    public static int[] FindSmallestTwo(int[] digits)
    {
        int smallest = int.MaxValue, secondSmallest = int.MaxValue;
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < smallest){
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest){
                secondSmallest = digits[i];
            }
        }
        return new int[] { smallest, secondSmallest };
    }

    public static void Main(String[] args){
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Count of digits: " + CountDigits(num));

        int[] digits = GetDigits(num);
        Console.Write("Digits: ");
        for (int i = 0; i < digits.Length; i++)
            Console.Write(digits[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Is Duck Number: " + IsDuckNumber(num));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrong(num));

        int[] largestTwo = FindLargestTwo(digits);
        Console.WriteLine("Largest: " + largestTwo[0] + ", Second Largest: " + largestTwo[1]);

        int[] smallestTwo = FindSmallestTwo(digits);
        Console.WriteLine("Smallest: " + smallestTwo[0] + ", Second Smallest: " + smallestTwo[1]);
    }
}
