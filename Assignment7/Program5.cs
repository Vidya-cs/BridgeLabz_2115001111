using System;

class Program5{
    public static void Main(string[] args){
	
        int number = int.Parse(Console.ReadLine());

        //Array to store the multiplication
        int[,] multiplicationResult = new int[4, 10];

        // Calculate multiplication tables from 6 to 9 and store the result
        for (int i = 6; i <= 9; i++){
            for (int j = 1; j <= 10; j++){
                multiplicationResult[i-6, j-1] = i * j;
            }
        }

        // Display the multiplication tables
        for (int i = 6; i <= 9; i++){
            for (int j = 1; j <= 10; j++){
				Console.WriteLine(i + " * " + j + " = " + multiplicationResult[i-6, j-1]);
            }
        }
    }
}
