using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Employee{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}

class Program4{
    static void Main(string[] args){
        List<Employee> employees = new List<Employee>{
            new Employee { Id = 1, Name = "Vidya", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Sagar", Department = "IT", Salary = 70000 }
        };

        //serialize
        using (FileStream fs = new FileStream("employees.dat", FileMode.Create)){
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, employees);
        }
        Console.WriteLine("Employees saved");

        //deserialize
        using (FileStream fs = new FileStream("employees.dat", FileMode.Open)){
            BinaryFormatter formatter = new BinaryFormatter();
            List<Employee> loadedEmployees = (List<Employee>)formatter.Deserialize(fs);
            foreach(var emp in loadedEmployees){
                Console.WriteLine(emp.Name + " ----- " + emp.Department);
            }
        }
    }
}
