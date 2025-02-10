using System;

abstract class Patient{
    protected int patientId;
    protected string name;
    protected int age;

    public Patient(int patientId, string name, int age){
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill(); 

    public void GetPatientDetails(){
        Console.WriteLine("Patient ID " + patientId);
        Console.WriteLine("Name " + name);
        Console.WriteLine("Age " + age);
        Console.WriteLine("Total bill " + CalculateBill());
    }
}

class InPatient : Patient {
    private int daysAdmitted;
    private double dailyCharge;
    public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge)
        : base(patientId, name, age){
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill(){
        return daysAdmitted * dailyCharge; 
    }
}

class OutPatient : Patient {
    private double consultationFee;
    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age){
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee; 
    }
}

interface IMedicalRecord{
    void AddRecord(string record);
    void ViewRecords();
}

class MedicalRecord : IMedicalRecord{
    private string record;
    public void AddRecord(string record){
        this.record = record;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Record: " + record);
    }
}

class Program7{
    public static void Main(String[] args)
    {
        InPatient inPatient = new InPatient(101, "Alice", 30, 5, 100);
        OutPatient outPatient = new OutPatient(102, "Bob", 25, 50);

        Console.WriteLine("Hospital Patient Details:\n");

        inPatient.GetPatientDetails();
        Console.WriteLine();

        outPatient.GetPatientDetails();
        Console.WriteLine();

        MedicalRecord record = new MedicalRecord();
        record.AddRecord("Patient had a fever and was prescribed medication.");
        record.ViewRecords();
    }
}