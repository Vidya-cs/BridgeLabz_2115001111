using System;
using System.Collections.Generic;
using System.Reflection;

class Person{
    public string Name;
    public int Age;
}

class Program8{
    static T ToObject<T>(Dictionary<string, object> properties) where T : new(){
        T obj = new T();
        Type type = typeof(T);
        foreach (var prop in properties){
            FieldInfo field = type.GetField(prop.Key);
            if (field != null) field.SetValue(obj, prop.Value);
        }
        return obj;
    }

    static void Main(string[] args){
        var data = new Dictionary<string, object> { { "Name", "Vidya" }, { "Age", 21 } };
        Person person = ToObject<Person>(data);
        Console.WriteLine(person.Name + " " + person.Age);
    }
}
