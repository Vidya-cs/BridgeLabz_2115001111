using System;

class Course{
    public string CourseName;
    public int Duration; 

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " weeks");
    }
}

class OnlineCourse : Course {
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) 
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayCourseDetails()
    {
        base.DisplayCourseDetails();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse{
    public double Fee;
    public double Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) 
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayCourseDetails()
    {
        base.DisplayCourseDetails();
        Console.WriteLine("Fee: $" + Fee);
        Console.WriteLine("Discount: " + Discount);
        Console.WriteLine("Final Price: $" + (Fee - (Fee * Discount / 100)));
    }
}

class Program7
{
    public static void Main()
    {
        Course generalCourse = new Course("Mathematics", 8);
        generalCourse.DisplayCourseDetails();

        Console.WriteLine();

        OnlineCourse online = new OnlineCourse("Python Programming", 6, "Udemy", true);
        online.DisplayCourseDetails();

        Console.WriteLine();

        PaidOnlineCourse paid = new PaidOnlineCourse("C# Mastery", 10, "Coursera", true, 200, 20);
        paid.DisplayCourseDetails();
    }
}
