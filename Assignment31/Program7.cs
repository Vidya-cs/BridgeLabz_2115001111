using System;
using System.Reflection;

class Configuration{
    private static string API_KEY = "12345";
}

class Program7{
    static void Main(string[] args){
        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);
        Console.WriteLine("Original API_KEY: " + field.GetValue(null));
        field.SetValue(null, "67890");
        Console.WriteLine("Updated API_KEY: " + field.GetValue(null));
    }
}
