using System;
using System.Reflection;

//custom attribute
[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute{
    public string Level {set; get;}
    public ImportantMethodAttribute(string level = "HIGH"){
        Level = level;
    }
}

class MyClass{
    [ImportantMethod("CRITICAL")]
    public void CriticalMethod(){
        Console.WriteLine("Executing critical method");
    }

    [ImportantMethod] 
    public void ImportantMethod(){
        Console.WriteLine("Executing important method");
    }
}

class Program6{
    public static void Main(string[] args){
        Type type = typeof(MyClass);
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods){
            ImportantMethodAttribute attr = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));
            if (attr != null){
                Console.WriteLine("Method= " + method.Name + " Importance Level= " + attr.Level);
            }
        }
    }
}
