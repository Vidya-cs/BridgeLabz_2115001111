using System;
using System.Reflection;

class Calculator{
    private int Multiply(int a, int b){
	return a*b;
	}
}

class Program3{
    public static void Main(string[] args){
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);
        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        object result = method.Invoke(calc, new object[] { 5, 6 });
        Console.WriteLine("Multiplication Result: " + result);
    }
}
