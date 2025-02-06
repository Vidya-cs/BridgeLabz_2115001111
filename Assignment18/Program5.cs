using System;
using System.Collections.Generic;


class Faculty{
    string Name { get; set; }

    public Faculty(string name){
        Name = name;
    }
}


class Department{
    string Name { get; set; }
    List<Faculty> Faculties { get; set; }

    public Department(string name){
        Name = name;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty){
        Faculties.Add(faculty);
    }
}


class University{
    string Name { get; set; }
    List<Department> Departments;
    List<Faculty> FacultyMembers { get; set; }

    public University(string name){
        Name = name;
        Departments = new List<Department>();
        FacultyMembers = new List<Faculty>();
    }

    public void AddDepartment(string departmentName){
        Departments.Add(new Department(departmentName));
    }

    public void AddFaculty(Faculty faculty){
        FacultyMembers.Add(faculty);
    }

    public void AssignFacultyToDepartment(string departmentName, Faculty faculty){
        var department= Departments.Find(d=>d.Name==departmentName);
        if(department!=null){
            department.AddFaculty(faculty);
        }
    }

    public void DisplayUniversityStructure(){
        Console.WriteLine($"University {Name}");
        Console.WriteLine("Departments");
        foreach(var department in Departments){
            Console.WriteLine($"{department.Name}");
            Console.WriteLine("Faculty Members");
            foreach(var faculty in department.Faculties){
                Console.WriteLine($"{faculty.Name}");
            }
        }
        Console.WriteLine("Independent Faculty Members");
        foreach(var faculty in FacultyMembers){
            Console.WriteLine($"{faculty.Name}");
        }
    }
}

class Program5{
    public static void Main(String[] args){
        University university = new University("GLA University");
        university.AddDepartment("Computer Science");
        university.AddDepartment("Mathematics");

        Faculty faculty1 = new Faculty("Anup");
        Faculty faculty2 = new Faculty("Anuj");
        Faculty faculty3 = new Faculty("Sikhar");

        university.AddFaculty(faculty1);
        university.AddFaculty(faculty2);
        university.AddFaculty(faculty3);

        university.AssignFacultyToDepartment("Computer Science", faculty1);
        university.AssignFacultyToDepartment("Mathematics", faculty2);

        university.DisplayUniversityStructure();
    }
}