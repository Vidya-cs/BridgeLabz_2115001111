using System;
using System.Reflection;

class Person{
    private int age = 25;
}

class Program{
    public static void Main(string[] args){
        Person person = new Person();
        Type type = typeof(Person);
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine("Original Age: " + field.GetValue(person));
        field.SetValue(person, 30);
        Console.WriteLine("Modified Age: " + field.GetValue(person));
    }
}
