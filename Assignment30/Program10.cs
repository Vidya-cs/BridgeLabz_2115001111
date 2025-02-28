using System;
using System.Reflection;

//custom attribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute{
    public string Role { set; get; }
    public RoleAllowedAttribute(string role) { Role = role; }
}

class SecureOperations{
    [RoleAllowed("ADMIN")]
    public void DeleteUser(){
        Console.WriteLine("User deleted");
    }
}

class Program10{
    public static void Main(string[] args){
        string currentUserRole = "USER";
        MethodInfo method = typeof(SecureOperations).GetMethod("DeleteUser");
        RoleAllowedAttribute attr = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));
        if (attr != null && attr.Role != currentUserRole){
            Console.WriteLine("Access Denied");
        }
        else{
            method.Invoke(new SecureOperations(), null);
        }
    }
}
