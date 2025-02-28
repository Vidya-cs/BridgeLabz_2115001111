using System;
using System.Reflection;

namespace CustomAttributes{
    [AttributeUsage(AttributeTargets.Method)]
    class TaskInfoAttribute : Attribute{
        public string Priority { get; set;}
        public string AssignedTo { get; set;}
        public TaskInfoAttribute(string priority, string assignedTo){
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    class TaskManager{
        [TaskInfo("High", "Vidya Sagar")]
        public void CompleteTask(){
            Console.WriteLine("Task completed");
        }
    }

    class Program4{
        public static void Main(string[] args){
            MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
            TaskInfoAttribute attribute = (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));
            if(attribute!=null){
                Console.WriteLine("Priority= " + attribute.Priority + " Assigned To= " + attribute.AssignedTo);
            }
        }
    }
}
