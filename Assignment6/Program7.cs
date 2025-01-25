using System;

class Program7{
    public static void Main(string[] args){
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        double[,] personData = new double[numberOfPersons, 3];
        string[] weightStatus = new string[numberOfPersons];
		
        for(int i = 0; i < numberOfPersons; i++){
			
            personData[i, 0] = double.Parse(Console.ReadLine());
            personData[i, 1] = double.Parse(Console.ReadLine());
			
        }

        //weight status for each person
        for(int i = 0; i < numberOfPersons; i++){
            double heightInMeters = personData[i, 1] / 100;
            personData[i, 2] = personData[i, 0]/(heightInMeters * heightInMeters);

            if(personData[i, 2] <= 18.4){
                weightStatus[i] = "Underweight";
            }
            else if(personData[i, 2] >= 18.5 && personData[i, 2] < 24.9){
                weightStatus[i] = "Normal";
            }
            else if(personData[i, 2] >= 25 && personData[i, 2] < 39.9){
                weightStatus[i] = "Overweight";
            }
            else{
                weightStatus[i] = "Obesity";
            }
        }

        // Display the results
        for(int i = 0; i < numberOfPersons; i++){
            Console.WriteLine("Height is " + personData[i, 1] + " weight is " + personData[i, 0] + " and Weight Status is " + weightStatus[i]);
        }
    }
}
