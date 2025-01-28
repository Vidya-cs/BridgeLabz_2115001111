using System;


class Program1{

    public static int ShortestHeight(int[] heights){
        int shortest= heights[0];
        for(int i= 1; i<heights.Length; i++){
            if(heights[i]<shortest)
                shortest = heights[i];
        }
        return shortest;
    }

    public static int TallestHeight(int[] heights){
        int tallest = heights[0];
        for(int i= 1; i<heights.Length; i++){
            if (heights[i] > tallest)
                tallest = heights[i];
        }
        return tallest;
    }

    public static double MeanHeight(int[] heights)
    {
        int sum= 0;
        for(int i= 0; i<heights.Length; i++){
            sum += heights[i];
        }
        return (double)sum/heights.Length;
    }
	
	public static void Main(String[] args){
		
		Random random = new Random();
        int[] heights = new int[11];
		for(int i= 0; i<heights.Length; i++){
            heights[i] = random.Next(150, 251);
        }

        Console.Write("Player Heights ");
		for(int i= 0; i<heights.Length; i++){
			Console.Write(heights[i] + " " );
		}

        Console.WriteLine("Shortest Height " + ShortestHeight(heights));
        Console.WriteLine("Tallest Height " + TallestHeight(heights));
        Console.WriteLine("Mean Height " + MeanHeight(heights));
    }

}
