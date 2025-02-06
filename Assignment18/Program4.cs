using System;


class Course{
    string Name { get; set; }
    List<Student> EnrolledStudents { get; set; }

    public Course(string name){
        Name = name;
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student){
        if(!EnrolledStudents.Contains(student)){
            EnrolledStudents.Add(student);
            student.EnrollInCourse(this);
        }
    }

    public void DisplayEnrolledStudents(){
        Console.WriteLine($"Course {Name} - Enrolled Students");
        foreach(var student in EnrolledStudents){
            Console.WriteLine($"{student.Name}");
        }
    }
}

class Student{
    string Name { get; set; }
    List<Course> Courses { get; set; }

    public Student(string name){
        Name = name;
        Courses = new List<Course>();
    }

    public void EnrollInCourse(Course course){
        if(!Courses.Contains(course)){
            Courses.Add(course);
        }
    }

    public void ViewEnrolledCourses(){
        Console.WriteLine($"Student {Name} - Enrolled Courses");
        foreach(var course in Courses){
            Console.WriteLine($"{course.Name}");
        }
    }
}


class School{
    string Name { get; set; }
    List<Student> Students { get; set; }

    public School(string name){
        Name = name;
        Students = new List<Student>();
    }

    public void AddStudent(Student student){
        if(!Students.Contains(student)){
            Students.Add(student);
        }
    }

    public void DisplayStudents(){
        Console.WriteLine($"School {Name} Students");
        foreach(var student in Students){
            Console.WriteLine($"{student.Name}");
        }
    }
}

class Program4{
    public static void Main(String[] args){
		
        School school = new School("DAV Public School");
        Student student1 = new Student("Vidya Sagar");
        Student student2 = new Student("Rockstar");

        school.AddStudent(student1);
        school.AddStudent(student2);

        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        math.EnrollStudent(student1);
        math.EnrollStudent(student2);
        science.EnrollStudent(student1);

        school.DisplayStudents();
        Console.WriteLine();

        student1.ViewEnrolledCourses();
        student2.ViewEnrolledCourses();
        Console.WriteLine();

        math.DisplayEnrolledStudents();
        science.DisplayEnrolledStudents();
    }
}