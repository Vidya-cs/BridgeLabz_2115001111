using System;
using System.Reflection;

namespace RepeatableAttribute{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReportAttribute : Attribute{
        public string Description { set; get; }

        public BugReportAttribute(string description){
            Description = description;
        }
    }

    class Software{
        [BugReport("Crash")]
        [BugReport("Program not working correctly")]
        public void FixBugs(){
            Console.WriteLine("Fixing bugs----");
        }
    }

    class Program5{
        public static void Main(string[] args){
            MethodInfo method = typeof(Software).GetMethod("FixBugs");
            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);
            foreach (BugReportAttribute attr in attributes){
                Console.WriteLine("Bug Report: " + attr.Description);
            }
        }
    }
}
