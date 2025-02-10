
using System;

abstract class Vehicle{
    protected int vehicleId;
    protected string driverName;
    protected double ratePerKm;
    public Vehicle(int vehicleId, string driverName, double ratePerKm){
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance); 
    public void GetVehicleDetails(){
        Console.WriteLine("Vehicle ID " + vehicleId);
        Console.WriteLine("Driver Name " + driverName);
        Console.WriteLine("Rate / Km " + ratePerKm);
    }
}

class Car : Vehicle {
    public Car(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }
    public override double CalculateFare(double distance){
        return ratePerKm * distance; 
    }
}

class Bike : Vehicle{
    public Bike(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance){
        return ratePerKm*distance*0.8; 
    }
}

interface IGPS{
    void GetCurrentLocation();
    void UpdateLocation(string location);
}

class GPS : IGPS{
    private string location;

    public void GetCurrentLocation(){
        Console.WriteLine("Current Location " + location);
    }

    public void UpdateLocation(string location){
        this.location = location;
        Console.WriteLine("Updated Location: " + location);
    }
}

class Program8{
    public static void Main(string[] args){
        Car car = new Car(301, "Vidya Sagar", 2.5);
        Bike bike = new Bike(302, "Sanskar", 1.5);

        Console.WriteLine("Ride-Hailing Vehicles ");

        car.GetVehicleDetails();
        Console.WriteLine("Fare for 10 km " + car.CalculateFare(10));
        Console.WriteLine();
        bike.GetVehicleDetails();
        Console.WriteLine("Fare for 10 km " + bike.CalculateFare(10));
        Console.WriteLine();
        GPS gps = new GPS();
        gps.UpdateLocation("Downtown");
        gps.GetCurrentLocation();
    }
}



