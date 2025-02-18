using System;
using System.Collections.Generic;

abstract class JobRole{
    public string CandidateName { get; set; }
    public int Experience { get; set; } 

    public JobRole(string candidateName, int exp){
        CandidateName = candidateName;
        Experience = exp;
    }
    public abstract void DisplayResume();
}

class SoftwareEngineer : JobRole{
    public string ProgrammingLanguage { get; set; }
    public SoftwareEngineer(string candidateName, int experience, string programmingLanguage) : base(candidateName, experience){
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayResume(){
        Console.WriteLine($"[Software Engineer] Name: {CandidateName}, Experience: {Experience} years, Skills: {ProgrammingLanguage}");
    }
}

class DataScientist : JobRole{
    public string Specialization { get; set; }
    public DataScientist(string candidateName, int experience, string specialization) : base(candidateName, experience){
        Specialization = specialization;
    }

    public override void DisplayResume(){
        Console.WriteLine($"[Data Scientist] Name: {CandidateName}, Experience: {Experience} years, Specialization: {Specialization}");
    }
}

class Resume<T> where T : JobRole{
    private List<T> resumes = new List<T>();
    public void AddResume(T resume){
        resumes.Add(resume);
    }

    public void DisplayResumes(){
        Console.WriteLine("Screened Resumes:");
        foreach(var resume in resumes){
            resume.DisplayResume();
        }
    }
}

class Program5{
    public static void Main(string[] args){
        Resume<SoftwareEngineer> softwareResumes = new Resume<SoftwareEngineer>();
        Resume<DataScientist> dataResumes = new Resume<DataScientist>();

        softwareResumes.AddResume(new SoftwareEngineer("Alice", 5, "C#, Java"));
        softwareResumes.AddResume(new SoftwareEngineer("Bob", 3, "Python, JavaScript"));

        dataResumes.AddResume(new DataScientist("Charlie", 4, "Machine Learning"));
        dataResumes.AddResume(new DataScientist("David", 2, "Deep Learning"));

        softwareResumes.DisplayResumes();
        dataResumes.DisplayResumes();
    }
}