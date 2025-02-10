using System;
using System.Collections.Generic;


//abstract class
abstract class Employee{
    protected int employeeId;
    protected string name;
    protected double baseSalary;

    public Employee(int employeeId, string name, double baseSalary){
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails(){
        Console.WriteLine("ID " + employeeId);
        Console.WriteLine("Name " + name);
        Console.WriteLine("Base salary " + baseSalary);
        Console.WriteLine("Total salary " + CalculateSalary());
    }
}

class FullTimeEmployee : Employee{
    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary) { }

    public override double CalculateSalary(){
        return baseSalary;
    }
}

class PartTimeEmployee : Employee{
    private int hoursWorked;
    private double hourlyRate;
    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int hoursWorked)
        : base(employeeId, name, hourlyRate * hoursWorked){
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    public override double CalculateSalary(){
        return hourlyRate * hoursWorked;
    }
}

interface IDepartment{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

class Department : IDepartment{
    private string departmentName;

    public void AssignDepartment(string department){
        departmentName = department;
    }

    public string GetDepartmentDetails(){
        return "Department: " + departmentName;
    }
}

class Program1{
    public static void Main(string[] args){
        List<Employee> employees = new List<Employee>();
        employees.Add(new FullTimeEmployee(101, "Alice", 50000));
        employees.Add(new PartTimeEmployee(102, "Bob", 20, 100));

        foreach (var emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine();
        }

        Department dept = new Department();
        dept.AssignDepartment("HR");
        Console.WriteLine(dept.GetDepartmentDetails());
    }
}