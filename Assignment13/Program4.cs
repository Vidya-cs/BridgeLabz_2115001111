using System;

class Program4{
	
    public static void GenerateFibonacci(int n){
		
        int a= 0, b= 1, temp;
        
        for(int i= 0; i<n; i++){
            Console.Write(a + " ");
            temp= a+b;
            a= b;
            b= temp;
        }
    }

    public static void Main(String[] args){
        Console.WriteLine("Enter the limit");
        int count = int.Parse(Console.ReadLine());

        GenerateFibonacci(count);
    }
}
