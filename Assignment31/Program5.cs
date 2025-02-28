using System;
using System.Reflection;

class MathOperations{
    public int Add(int a, int b){
		return a+b;
	}
    public int Subtract(int a, int b){
		return a-b;
	}
}

class Program5{
    static void Main(string[] args){
        MathOperations obj = new MathOperations();
        Type type = typeof(MathOperations);
        Console.Write("Enter method name Add/Subtract ");
        string methodName = Console.ReadLine();
        MethodInfo method = type.GetMethod(methodName);
        object result = method.Invoke(obj, new object[] {10, 5});
        Console.WriteLine("Result: " + result);
    }
}
