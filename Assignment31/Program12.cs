using System;
using System.Diagnostics;
using System.Reflection;


class MathOperations{
    public void Add(){
        int sum = 0;
        for(int i= 0; i < 1000000; i++){
			sum += i;
		}
        Console.WriteLine("Addition Done");
    }

    public void Multiply(){
        int product = 1;
        for (int i = 1; i <= 10000; i++){
			product*= i%10+1; 
		}
        Console.WriteLine("Multiplication done");
    }
}

class Program12{
    static void MeasureExecutionTime(object instance, string methodName){
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null){
            Console.WriteLine("Method not found");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        method.Invoke(instance, null); 

        stopwatch.Stop();
        Console.WriteLine("Execution Time for " + methodName " is " + stopwatch.ElapsedMilliseconds);
    }

    static void Main(string[] args){
        MathOperations obj = new MathOperations();

        Console.Write("Enter method name Add/Multiply ");
        string methodName = Console.ReadLine();
        MeasureExecutionTime(obj, methodName);
    }
}
