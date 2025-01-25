using System;

class Program3{
    public static void Main(string[] args){
	
        int number = int.Parse(Console.ReadLine());
		
        int[] table = new int[10];

        //Fill multiplication table
        for(int i= 1; i<=10; i++){
            table[i-1] = number * i;
        }

        //Display the multiplication table
        for(int i = 0; i<table.Length; i++){
            Console.WriteLine(number +" * " + (i + 1) + " = " + table[i]);
        }
    }
}
