using System;

class Program11{
    

    public static void GenerateEmployeeData(int[,] salaryAndYears){
        Random rand = new Random();
        for (int i = 0; i < 10; i++){
            salaryAndYears[i, 0] = rand.Next(10000, 100000);
            salaryAndYears[i, 1] = rand.Next(1, 21);
        }
    }

    public static int[,] CalculateBonusAndNewSalary(int[,] salaryAndYears){
        int[,] updatedData = new int[10, 3];

        for (int i = 0; i < 10; i++){
            int oldSalary = salaryAndYears[i, 0];
            int yearsOfService = salaryAndYears[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            
            double bonus = oldSalary * bonusPercentage;
            int newSalary = (int)(oldSalary + bonus);

            updatedData[i, 0] = newSalary;
            updatedData[i, 1] = (int)bonus;
            updatedData[i, 2] = oldSalary;
        }

        return updatedData;
    }

    public static void CalculateAndDisplayResults(int[,] salaryAndYears, int[,] updatedData){
        int totalOldSalary = 0;
        int totalNewSalary = 0;
        int totalBonus = 0;


        for (int i = 0; i < 10; i++){
            int oldSalary = salaryAndYears[i, 0];
            int newSalary = updatedData[i, 0];
            int bonus = updatedData[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine(oldSalary + " " + salaryAndYears[i, 1] + " " +  newSalary + " " + bonus);
        }

        Console.WriteLine(totalOldSalary+ " " +totalNewSalary+ " " +totalBonus);
    }
	
	public static void Main(String[] args){
        int[,] salaryAndYears = new int[10, 2];
        GenerateEmployeeData(salaryAndYears);

        int[,] updatedSalaryData = CalculateBonusAndNewSalary(salaryAndYears);

        CalculateAndDisplayResults(salaryAndYears, updatedSalaryData);
    }
}
