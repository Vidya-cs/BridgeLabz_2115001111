
using System;
using System.Collections.Generic;

abstract class Vehicle{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    public Vehicle(string vehicleNumber, string type, double rentalRate){
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);

    public void DisplayDetails(){
        Console.WriteLine("Vehicle Number " + vehicleNumber);
        Console.WriteLine("Type " + type);
        Console.WriteLine("Rental Rate " + rentalRate + "/day");
    }
}

interface IInsurable{
    double CalculateInsurance();
    void GetInsuranceDetails();
}

class Car : Vehicle, IInsurable{
    public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Car", rentalRate) { }

    public override double CalculateRentalCost(int days){
        return rentalRate * days;
    }

    public double CalculateInsurance(){
        return rentalRate * 5; 
}

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance for " + vehicleNumber + ": $" + CalculateInsurance());
    }
}

class Program3{
    public static void Main(string[] args){
        Car car = new Car("ABC123", 40);
        car.DisplayDetails();
        Console.WriteLine("Total Rental Cost for 3 days: $" + car.CalculateRentalCost(3));
        car.GetInsuranceDetails();
    }
}





