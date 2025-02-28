using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

[AttributeUsage(AttributeTargets.Property)]
class JsonFieldAttribute : Attribute{
    public string Name { get; }
    public JsonFieldAttribute(string name){Name = name;}
}

class User{
    [JsonField("user_name")]
    public string Name { get; set; }
    [JsonField("user_age")]
    public int Age { get; set; }
}

class Program11{
    static string SerializeToJson(object obj){
        Type type = obj.GetType();
        var properties = type.GetProperties();
        var jsonDict = new Dictionary<string, object>();

        foreach (var prop in properties){
            string key = prop.Name;
            var attr = (JsonFieldAttribute)Attribute.GetCustomAttribute(prop, typeof(JsonFieldAttribute));
            if (attr != null){
                key = attr.Name;
            }
            jsonDict[key] = prop.GetValue(obj);
        }
        return JsonConvert.SerializeObject(jsonDict, Formatting.Indented);
    }

    public static void Main(string[] args){
        User user = new User { Name = "Vidya Sagar", Age = 21 };
        string json = SerializeToJson(user);
        Console.WriteLine(json);
    }
}
