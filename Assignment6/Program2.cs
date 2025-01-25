using System;

class Program2{
	public static void Main(String[] args){
		
		string[] names= {"Amar", "Akbar", "Anthony"};
		int[] age= new int[3];
		int[] height= new int[3];
		
		
		//Taking input
		Console.WriteLine("First enter age and then the height of same person");
		
		for(int i=0; i<3; i++){
			age[i]= int.Parse(Console.ReadLine());
			height[i]= int.Parse(Console.ReadLine());
		}
		
		//Finding the youngest and the tallest among them
		
		int minAge= age[0];
		int maxHeight= height[0];
		string youngest= names[0];
		string tallest= names[0];
		
		for(int i=0; i<2; i++){
			if( minAge > age[i]){
				youngest= names[i];
				minAge= age[i];
			}
			if(maxHeight < height[i]){
				tallest= names[i];
				maxHeight= height[i];
			}
		}
		
		//Printing the result
		
		Console.WriteLine("Youngest among them is " + youngest + " and the tallest among them is " + tallest);
	}
}