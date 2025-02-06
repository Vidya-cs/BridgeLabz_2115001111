using System;


class Employee{
    string Name { get; set; }

    Employee(string name){
        Name = name;
    }
}


class Department{
    string Name { get; set; }
    List<Employee> Employees { get; set; }

    public Department(string name){
        Name = name;
        Employees = new List<Employee>();
    }

    public void AddEmployee(string employeeName){
        Employees.Add(new Employee(employeeName));
    }
}

class Company{
    string Name { get; set; }
    List<Department> Departments;

    public Company(string name){
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(string departmentName){
        Departments.Add(new Department(departmentName));
    }

    public void AddEmployeeToDepartment(string departmentName, string employeeName){
        var department = Departments.Find(d => d.Name == departmentName);
        if(department!=null){
            department.AddEmployee(employeeName);
        }
    }

    public void DisplayCompanyStructure(){
        Console.WriteLine($"Company {Name}");
        foreach(var department in Departments){
            Console.WriteLine($"Department {department.Name}");
            foreach(var employee in department.Employees){
                Console.WriteLine($"Employee {employee.Name}");
            }
        }
    }
}

class Program3{
    public static void Main(String[] args){
        Company company = new Company("TechCorp");
        company.AddDepartment("IT");
        company.AddDepartment("HR");

        company.AddEmployeeToDepartment("IT", "Aarti");
        company.AddEmployeeToDepartment("IT", "Rahul");
        company.AddEmployeeToDepartment("HR", "Sudhanshu");

        company.DisplayCompanyStructure();
    }
}