using System;

class Program1{
    public static void Main(string[] args){
		
        int numberOfStudents = 10;

        int[] ages = new int[numberOfStudents];

        for(int i= 0; i<ages.Length; i++){
			
            Console.Write("Enter the age ");
            ages[i] = int.Parse(Console.ReadLine());
			
        }

        //Checking if students can vote based on their age
        for(int i= 0; i<ages.Length; i++){
			
            if(ages[i] >= 18){
                Console.WriteLine("This student can vote as he/she is " + ages[i] + " years of age");
            }
            else{
                Console.WriteLine("The student with age " + ages[i] + "cannot vote");
            }
        }
    }
}
