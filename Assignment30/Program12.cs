using System;
using System.Collections.Generic;
using System.Reflection;

//custom attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class ExpensiveCalculations{
    private static Dictionary<int, int> cache = new Dictionary<int, int>();
    [CacheResult]
    public int ComputeFactorial(int num){
        if (cache.ContainsKey(num)){
            Console.WriteLine("Catched result= " + num);
            return cache[num];
        }
        int result= 1;
        for(int i= 1; i<=num; i++){
            result*= i;
        }
        cache[num] = result;
        Console.WriteLine("Computed and cached result for " + num);
        return result;
    }
}

class Program12{
    public static void Main(string[] args){
        ExpensiveCalculations calc = new ExpensiveCalculations();
        Console.WriteLine(calc.ComputeFactorial(5)); 
        Console.WriteLine(calc.ComputeFactorial(5)); 
        Console.WriteLine(calc.ComputeFactorial(6)); 
    }
}
