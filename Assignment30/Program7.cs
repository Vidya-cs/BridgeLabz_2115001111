using System;
using System.Reflection;

//custom attribute
[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute{
    public string Task { set; get; }
    public string AssignedTo { set; get; }
    public string Priority { set; get; }
    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM"){
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}


class Project{
    [Todo("Implement login", "Vidya", "HIGH")]
    public void LoginFeature() { }

    [Todo("update", "Sagar")]
    public void OptimizeCode() { }
}

class Program7{
    public static void Main(string[] args){
        Type type = typeof(Project);
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods){
            TodoAttribute attr = (TodoAttribute)Attribute.GetCustomAttribute(method, typeof(TodoAttribute));
            if (attr != null){
                Console.WriteLine("Task= " + attr.Task + " Assigned to= " + attr.AssignedTo + " Priority= " + attr.Priority);
            }
        }
    }
}
