using System;

class Program9{
	
    public static void Main(string[] args){
		
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int[,] marks = new int[numberOfStudents, 3];  // 2D array to store marks for Physics, Chemistry, and Maths
        double[] percentage = new double[numberOfStudents];
		string[] grades = new string[numberOfStudents];

        for(int i= 0; i<numberOfStudents; i++){
            // Input marks for each subject (stored in the 2D array)
            Console.Write("For Physics: ");
            marks[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("For Chemistry: ");
            marks[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("For Maths: ");
            marks[i, 2] = int.Parse(Console.ReadLine());
        }

        // Calculating percentage and grade for each student
        for(int i= 0; i<numberOfStudents; i++){
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = (totalMarks / 3.0);

            if(percentage[i] >= 80)
                grades[i] = "A";
            else if(percentage[i] >= 70 && percentage[i] < 80)
                grades[i] = "B";
            else if(percentage[i] >= 60 && percentage[i] < 70)
                grades[i] = "C";
			else if(percentage[i] >= 50 && percentage[i] < 60)
				grades[i] = "D";
			else if(percentage[i] >= 40 && percentage[i] < 50)
				grades[i] = "E";
            else
                grades[i] = "R";
        }

        // Displaying marks, percentage, and grade
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("For student " + (i + 1) + " Physics: " + marks[i, 0] + ", Chemistry: " + marks[i, 1] + ", Maths: " + marks[i, 2] + ", Percentage: " + percentage[i] + ", Grade: " + grades[i]);
        }
    }
}
