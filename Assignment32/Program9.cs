using System;
using System.IO;
using System.Collections.Generic;

class Student{
    public string ID, Name, Age, Marks;
}

class Program9{
    static void Main(string[] args){
        string filePath = "students.csv";
        List<Student> students = new List<Student>();
        foreach (string line in File.ReadAllLines(filePath).Skip(1)){
            string[] data = line.Split(',');
            students.Add(new Student { ID = data[0], Name = data[1], Age = data[2], Marks = data[3] });
        }

        foreach (var student in students)
            Console.WriteLine(student.ID + " " + student.Name + " " + student.Age + " " + student.Marks);
    }
}

