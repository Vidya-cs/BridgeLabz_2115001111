using System;

class Program4{
    public static void Main(string[] args){
        double[] numbers = new double[10]; 
        double total = 0.0; 
        int index = 0;

        while(true){
            // Take user input
            double input = double.Parse(Console.ReadLine());

            if(input <= 0 || index == 10){
                break;
            }

            //Store the number in the array
            numbers[index] = input;
            index++;
        }

        //Calculating the sum of all entered numbers
        for (int i = 0; i < index; i++){
            total += numbers[i];
        }

        //Displaying the result
		
        for (int i = 0; i < index; i++){
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("The sum of all entered numbers is " + total);
    }
}
