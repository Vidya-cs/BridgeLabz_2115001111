using System;

class Program7{
    
	public static void Main(string[] args){
	
        int number= int.Parse(Console.ReadLine());

        //Arrays to store odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];

        int oddIndex = 0, evenIndex = 0;

        for(int i= 1; i<=number; i++){
            if(i%2 == 0){
                evenNumbers[evenIndex++] = i;
            }
            else{
                oddNumbers[oddIndex++] = i;
            }
        }

        Console.WriteLine("Odd numbers ");
        for(int i= 0; i<oddIndex; i++){
            Console.Write(oddNumbers[i] + " ");
        }
        
        Console.WriteLine();

        Console.WriteLine("Even numbers ");
        for (int i= 0; i<evenIndex; i++){
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
