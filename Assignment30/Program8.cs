using System;
using System.Diagnostics;
using System.Reflection;

//custom attribute
[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class PerformanceTest{
    [LogExecutionTime]
    public void SlowMethod(){
        System.Threading.Thread.Sleep(2000); 
    }
}

class Program8{
    public static void Main(string[] args){
        Type type = typeof(PerformanceTest);
        MethodInfo method = type.GetMethod("SlowMethod");
        if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) != null){
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(new PerformanceTest(), null);
            stopwatch.Stop();
            Console.WriteLine("Execution Time= " + stopwatch.ElapsedMilliseconds);
        }
    }
}
