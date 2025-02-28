using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute{
    public string Name;
    public AuthorAttribute(string name) { Name = name; }
}

[Author("Vidya Sagar")]
class MyClass { }

class Program6{
    static void Main(string[] args){
        Type type = typeof(MyClass);
        object[] attributes = type.GetCustomAttributes(false);
        foreach (AuthorAttribute attr in attributes){
            Console.WriteLine("Author: " + attr.Name);
        }
    }
}
