using System;

class Program6{
	
    public static void Main(string[] args){
		
        Console.Write("Enter the number of persons");
        int numberOfPersons = int.Parse(Console.ReadLine());

        double[] weight = new double[numberOfPersons];
        double[] height = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] status = new string[numberOfPersons];

        for(int i= 0; i<numberOfPersons; i++){
            
            //weight
            Console.Write("Weight");
            weight[i] = double.Parse(Console.ReadLine());

            //height
            Console.Write("Height");
            height[i] = double.Parse(Console.ReadLine());
        }

        for(int i= 0; i<numberOfPersons; i++){
            
            double heightMeter = height[i] / 100;
			
            bmi[i] = weight[i] / (heightMeter * heightMeter);

            //Weight status based on BMI
            if(bmi[i]<= 18.4){
                status[i] = "Underweight";
            }
            else if(bmi[i] >= 18.5 && bmi[i]< 24.9){
                status[i] = "Normal";
            }
            else if(bmi[i]>= 25 && bmi[i]< 39.9){
                status[i] = "Overweight";
            }
            else{
                status[i] = "Obesity";
            }
        }

        //Printing the results
		
        for(int i= 0; i<numberOfPersons; i++){
			Console.WriteLine(" Status of person " + i + " is " + status[i]);
        }
    }
}
