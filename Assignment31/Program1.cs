using System;
using System.Reflection;

class SampleClass{
    public int Number;
    public string Name;
    public SampleClass() { }
    public SampleClass(int num, string name) { Number = num; Name = name; }
    public void Display(){
		Console.WriteLine("SampleClass");
	}
}

class Program1{
    public static void Main(string[] args){
        Console.WriteLine("Enter class name ");
        string className = Console.ReadLine();
        Type type = Type.GetType(className);
        if (type != null){
            Console.WriteLine("Methods");
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
				Console.WriteLine(method.Name);

            Console.WriteLine("Fields");
            FieldInfo[] fields = type.GetFields();
            foreach (var field in fields)
				Console.WriteLine(field.Name);

            Console.WriteLine("Constructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var ctor in constructors)
				Console.WriteLine(ctor);
        }
        else{
            Console.WriteLine("Class not found");
        }
    }
}
