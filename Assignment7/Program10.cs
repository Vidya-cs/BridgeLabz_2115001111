using System;

class Program10{
	
    public static void Main(string[] args){
		
        int number = int.Parse(Console.ReadLine());

        string[] results = new string[number + 1];

        for(int i= 1; i<=number; i++){
			
            if(i%3 == 0 && i%5 == 0){
                results[i-1] = "FizzBuzz";
            }
            else if(i%3 == 0){
                results[i-1] = "Fizz";
            }
            else{
                results[i-1] = "Buzz";      
            }
        }

        //Displaying the results
        for(int i= 0; i<results.Length-1; i++){
            Console.WriteLine("Position " + (i+1) + " = " + results[i]);
        }
    }
}
