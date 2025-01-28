using System;

class Program12{


    public static int[,] GenerateScores(int numStudents){
        Random rand = new Random();
        int[,] scores = new int[numStudents, 3];

        for(int i= 0; i<numStudents; i++){
            scores[i, 0] = rand.Next(10, 100);  //physics
            scores[i, 1] = rand.Next(10, 100);  // chemistry
            scores[i, 2] = rand.Next(10, 100);  //maths
        }

        return scores;
    }

    public static double[,] CalculateResults(int[,] scores){
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 4];

        for (int i = 0; i < numStudents; i++){
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total/3.0;
            double percentage = (total/300.0) * 100;

            results[i,0] = total;
            results[i,1] = Math.Round(average, 2);
            results[i,2] = Math.Round(percentage, 2);
        }

        return results;
    }
	    public static void Main(String[] args){
        int numStudents;
        Console.Write("Enter number of students ");
        numStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(numStudents);
        double[,] results = CalculateResults(scores);

        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++){
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}", i + 1, scores[i, 0], scores[i, 1], scores[i, 2], results[i, 0], results[i, 1], results[i, 2]);
        }
    }

}
