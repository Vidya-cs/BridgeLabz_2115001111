using System;
using System.Collections.Generic;


abstract class CourseType{
    public string CourseName { get; set; }
    public int Duration { get; set; } 

    public CourseType(string courseName, int duration){
        CourseName = courseName;
        Duration = duration;
    }

    public abstract void Display();
}

class ExamCourse : CourseType{
    public bool HasFinalExam { get; set; }
    public ExamCourse(string courseName, int duration, bool hasFinalExam) : base(courseName, duration){
        HasFinalExam = hasFinalExam;
    }

    public override void Display(){
        Console.WriteLine($"[Exam Course] Name: {CourseName}, Duration: {Duration} weeks, Final Exam: {HasFinalExam}");
    }
}

class PaidExamCourse : ExamCourse{
    public double Fee { get; set; }
    public double Discount { get; set; }
    public PaidExamCourse(string courseName, int duration, bool hasFinalExam, double fee, double discount) : base(courseName, duration, hasFinalExam){
        Fee = fee;
        Discount = discount;
    }

    public override void Display(){
        double finalFee= Fee-(Fee*Discount/100);
        Console.WriteLine($"[Paid Exam Course] Name: {CourseName}, Duration: {Duration} weeks, Final Exam: {HasFinalExam}, Fee: {Fee}, Discount: {Discount}%, Final Fee: {finalFee}");
    }
}

class CourseCatalog<T> where T : CourseType{
    private List<T> courses = new List<T>();

    public void AddCourse(T course){
        courses.Add(course);
    }

    public void DisplayCourses(){
        Console.WriteLine("University Course Catalog:");
        foreach (var course in courses){
            course.Display();
        }
    }
}
class Program3{
    public static void Main(string[] args){
        
        CourseCatalog<ExamCourse> examCatalog = new CourseCatalog<ExamCourse>();
        CourseCatalog<PaidExamCourse> paidExamCatalog = new CourseCatalog<PaidExamCourse>();
		
        ExamCourse course1 = new ExamCourse("Mathematics", 12, true);
        ExamCourse course2 = new ExamCourse("Physics", 10, false);
        examCatalog.AddCourse(course1);
        examCatalog.AddCourse(course2);

        PaidExamCourse paidCourse1 = new PaidExamCourse("Data Science", 16, true, 5000, 10);
        PaidExamCourse paidCourse2 = new PaidExamCourse("Cyber Security", 20, true, 8000, 15);
        paidExamCatalog.AddCourse(paidCourse1);
        paidExamCatalog.AddCourse(paidCourse2);

        examCatalog.DisplayCourses();
        paidExamCatalog.DisplayCourses();
    }
}
