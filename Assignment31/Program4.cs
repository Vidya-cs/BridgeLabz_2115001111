using System;
using System.Reflection;

class Student{
    public string Name;
    public int Age;
    public Student(){
		Name = "Vidya";
		Age = 21;
	}
    public void Show(){
		Console.WriteLine("Student: " + Name + " Age: " + Age);
	}
}

class Program4{
    static void Main(string[] args){
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);
        MethodInfo method = type.GetMethod("Show");
        method.Invoke(obj, null);
    }
}
