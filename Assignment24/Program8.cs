using System;

class Program8{
    public static int FindFirstNegative(int[] numbers){
        for(int i= 0; i<numbers.Length; i++){
            if(numbers[i]<0)
                return numbers[i];
        }
        return -1;
    }

    public static void Main(string[] args){
        int[] numbers= { 4, 3, -2, 7, -5, 10 };
        Console.WriteLine("First negative number " + FindFirstNegative(numbers));
    }
}
