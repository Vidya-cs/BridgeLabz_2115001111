using System;

class Program6{
    public static void Main(string[] args){
		
        double[] heights = new double[11];
        double sum = 0.0;

        for (int i = 0; i < heights.Length; i++){
			
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
			
        }

        //Mean height
        double mean= sum/heights.Length;

        //Display the mean height
        Console.WriteLine("The mean height of the football team is: " + mean);
    }
}
