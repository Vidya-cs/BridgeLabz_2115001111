using System;

class Program9{
	
    public static void Main(string[] args){
		
        Console.Write("Enter the number of rows ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

		//Taking input
		
        Console.WriteLine("Enter the elements of the matrix ");
        for(int i= 0; i<rows; i++){
            for (int j= 0; j<columns; j++){
                matrix[i,j] = int.Parse(Console.ReadLine());
            }
        }

        int[] array = new int[rows*columns];
        int index = 0;

        for(int i= 0; i<rows; i++){
		for(int j= 0; j<columns; j++){
                array[index] = matrix[i,j];
                index++;
            }
        }

		//Displaying the required output
		
        for(int i= 0; i<array.Length; i++){
            Console.Write(array[i] + " ");
        }
    }
}
