using System;

class Program2
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for(int i= 0; i<numbers.Length; i++){
            numbers[i]= int.Parse(Console.ReadLine());
        }

        for(int i = 0; i<numbers.Length; i++){
            if(numbers[i] > 0){
                Console.WriteLine("Number " + numbers[i] + " is positive");
                if(numbers[i]%2 == 0){
                    Console.WriteLine("Number " + numbers[i] + " is even");
                }
                else{
                    Console.WriteLine("Number " + numbers[i] + " is odd");
                }
            }
            else if(numbers[i] < 0){
                Console.WriteLine("Number " + numbers[i] + " is negative");
            }
            else{
                Console.WriteLine("The number is zero");
            }
        }

        //Compare the first and last elements of the array
        if(numbers[0] == numbers[numbers.Length-1]){
            Console.WriteLine("The first and last numbers are equal");
        }
        else if(numbers[0] > numbers[numbers.Length-1]){
            Console.WriteLine("The first number is greater than the last number");
        }
        else{
            Console.WriteLine("The first number is less than the last number");
        }
    }
}
