using System;

class Employee{
	
    String name;
    int id;
    double salary;
	
    public Employee(String name, int id, double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

	//Method to display details
    public void DisplayDetails(){
        Console.WriteLine("Employee Name " + name);
        Console.WriteLine("Employee ID " + id);
        Console.WriteLine("Employee Salary " + salary);
    }
}

class Program1{
	
    public static void Main(String[] args){
		
        Employee employee1 = new Employee("Vidya Sagar Singh", 6171, 50000000000);
		
        employee1.DisplayDetails();
    }
}
