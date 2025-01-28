using System;

class Program6{
	
    public static int[] FindFactors(int number){
        
		int count = 0;
        for(int i=1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for(int i=1; i<=number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }

    public static int GreatestFactor(int[] factors){
        return factors[factors.Length - 1];
    }

    public static int SumOfFactors(int[] factors){
        int sum = 0;
        for (int i = 0; i < factors.Length; i++){
            sum += factors[i];
        }
        return sum;
    }

    public static int ProductOfFactors(int[] factors){
        int product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
        }
        return product;
    }

    public static double ProductOfCubes(int[] factors){
        double product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3); // Using Math.Pow() to find the cube
        }
        return product;
    }

    public static bool IsPerfect(int number)
    {
        int[] factors = FindFactors(number);
        int sumOfProperDivisors = 0;

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sumOfProperDivisors += factors[i];
        }

        return sumOfProperDivisors == number;
    }

    public static bool IsAbundant(int number)
    {
        int[] factors = FindFactors(number);
        int sumOfProperDivisors = 0;

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sumOfProperDivisors += factors[i];
        }

        return sumOfProperDivisors > number;
    }

    public static bool IsDeficient(int number){
        int[] factors = FindFactors(number);
        int sumOfProperDivisors = 0;

        for (int i = 0; i < factors.Length - 1; i++)
        {
            sumOfProperDivisors += factors[i];
        }

        return sumOfProperDivisors < number;
    }

    public static bool IsStrong(int number){
        int originalNumber = number;
        int sumOfFactorials = 0;

        while (number > 0){
            int digit = number % 10;
            sumOfFactorials += Factorial(digit);
            number = number / 10;
        }

        return sumOfFactorials == originalNumber;
    }

    public static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main(string[] args)
    {
        int number = 145;

        //factors
        int[] factors = FindFactors(number);

        //Displaying factors
        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));

        //Greatest factor
        int greatestFactor = GreatestFactor(factors);
        Console.WriteLine("Greatest factor: " + greatestFactor);

        //Sum of factors
        int sumOfFactors = SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);

        //Product of factors
        int productOfFactors = ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);

        //Product of cubes of factors
        double productOfCubes = ProductOfCubes(factors);
        Console.WriteLine("Product of cubes of factors: " + productOfCubes);

        // Checking if the number is perfect
        bool isPerfect = IsPerfect(number);
        Console.WriteLine("Is the number perfect? " + isPerfect);

        // Checking if the number is abundant
        bool isAbundant = IsAbundant(number);
        Console.WriteLine("Is the number abundant? " + isAbundant);

        // Checking if the number is deficient
        bool isDeficient = IsDeficient(number);
        Console.WriteLine("Is the number deficient? " + isDeficient);

        // Checking if the number is strong
        bool isStrong = IsStrong(number);
        Console.WriteLine("Is the number strong? " + isStrong);
    }
}
