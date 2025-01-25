using System;

class Program8{
	
    public static void Main(string[] args){
		
        Console.Write("Enter the number of students ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int[] physicsMarks = new int[numberOfStudents];
        int[] chemistryMarks = new int[numberOfStudents];
        int[] mathsMarks = new int[numberOfStudents]; 
        double[] percentage = new double[numberOfStudents];
		string[] grades = new string[numberOfStudents];

        for(int i= 0; i<numberOfStudents; i++){
			
            Console.Write("For Physics ");
            physicsMarks[i] = int.Parse(Console.ReadLine());

            Console.Write("For Chemistry");
            chemistryMarks[i] = int.Parse(Console.ReadLine());

            Console.Write("For Maths");
            mathsMarks[i] = int.Parse(Console.ReadLine());
			
        }

        //Calculating percentage and grade for each student
        for(int i= 0; i<numberOfStudents; i++){
			
            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathsMarks[i];
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

        //Displaying marks, percentage, and grade
		
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("For student " + i + " Physics " + physicsMarks[i] + " Chemistry " + chemistryMarks[i] + " Maths " + mathsMarks[i] + " Percentage " + percentage[i] + " Grade " + grades[i]);
        }
    }
}
