using System;

class Student{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public Student Next;

    public Student(int rollNumber, string name, int age, char grade){
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentList{
    private Student head;

    public void AddStudentAtEnd(int rollNumber, string name, int age, char grade){
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null){
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }

    public void AddStudentAtBeginning(int rollNumber, string name, int age, char grade){
        Student newStudent = new Student(rollNumber, name, age, grade);
        newStudent.Next = head;
        head = newStudent;
    }

    public void AddStudentAtPosition(int rollNumber, string name, int age, char grade, int position){
        Student newStudent = new Student(rollNumber, name, age, grade);
        if(position == 1){
            newStudent.Next = head;
            head = newStudent;
            return;
        }
        Student temp = head;
        for (int i = 1; temp != null && i < position - 1; i++){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Invalid position.");
            return;
        }
        newStudent.Next = temp.Next;
        temp.Next = newStudent;
    }

    public void DeleteStudent(int rollNumber){
        Student temp = head, prev = null;
        if (temp != null && temp.RollNumber == rollNumber){
            head = temp.Next;
            return;
        }
        while (temp != null && temp.RollNumber != rollNumber){
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Student not found.");
            return;
        }
        prev.Next = temp.Next;
    }

    public Student SearchStudent(int rollNumber){
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateStudentGrade(int rollNumber, char newGrade)
    {
        Student student = SearchStudent(rollNumber);
        if (student != null)
        {
            student.Grade = newGrade;
            Console.WriteLine("Grade updated successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    public void DisplayAllStudents()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine("Roll Number: " + temp.RollNumber + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
            temp = temp.Next;
        }
    }
}

class Program1
{
    public static void Main(string[] args)
    {
        StudentList studentList = new StudentList();

        studentList.AddStudentAtEnd(101, "Alice", 20, 'A');
        studentList.AddStudentAtEnd(102, "Bob", 21, 'B');
        studentList.AddStudentAtBeginning(100, "Charlie", 19, 'C');
        studentList.AddStudentAtPosition(103, "David", 22, 'A', 2);

        Console.WriteLine("\nStudent Records:");
        studentList.DisplayAllStudents();

        Console.WriteLine("\nSearching for Roll Number 102:");
        Student student = studentList.SearchStudent(102);
        if (student != null)
            Console.WriteLine("Found: " + student.Name);
        else
            Console.WriteLine("Student not found.");

        Console.WriteLine("\nUpdating Grade for Roll Number 101:");
        studentList.UpdateStudentGrade(101, 'A');

        Console.WriteLine("\nDeleting Student with Roll Number 100:");
        studentList.DeleteStudent(100);

        Console.WriteLine("\nUpdated Student Records:");
        studentList.DisplayAllStudents();
    }
}
