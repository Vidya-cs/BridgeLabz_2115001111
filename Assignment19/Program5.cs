
using System;

class Device{
    public int DeviceId;
    public string Status;

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

class Thermostat : Device {
    public int TemperatureSetting;

    public Thermostat(int deviceId, string status, int temperatureSetting) : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

class Program5
{
    public static void Main(String[] args){
        Thermostat thermostat1 = new Thermostat(101, "ON", 22);

        Console.WriteLine("Device Status:");
        thermostat1.DisplayStatus();
    }
}



