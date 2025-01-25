using System;

class Program1{
	
    public static void Main(string[] args){
		
        int numberOfEmployees = 10;
        
        double[] salary = new double[numberOfEmployees];
        int[] yearsOfService = new int[numberOfEmployees];
        double[] newSalary = new double[numberOfEmployees];
        double[] bonus = new double[numberOfEmployees];

        double totalBonus = 0;
        double totalsalary = 0;
        double totalNewSalary = 0;

        for(int i= 0; i<numberOfEmployees; i++){

            Console.Write("Enter salary ");
            salary[i] = double.Parse(Console.ReadLine());
			
            Console.Write("Enter years of service ");
            yearsOfService[i] = int.Parse(Console.ReadLine());
        }

        //Calculating bonus, new salary, and total salary
        for(int i = 0; i < numberOfEmployees; i++){
			
            if(yearsOfService[i] > 5){
                bonus[i] = salary[i] * 0.05;
            }
            else{
                bonus[i] = salary[i] * 0.02;
            }

            //Calculating new salary
            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalsalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        //Displaying results
		
        for(int i= 0; i<numberOfEmployees; i++){
			Console.WriteLine(" Employee " + (i+1) + " Old Salary " + salary[i] + ", Bonus " + bonus[i] + " New Salary " + newSalary[i]);
        }

        // Display total bonus and total salaries
        Console.WriteLine("Total Bonus " + totalBonus);
    }
}
