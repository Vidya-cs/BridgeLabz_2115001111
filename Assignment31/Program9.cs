using System;
using System.Text;
using System.Reflection;

class Product{
    public string Name = "Laptop";
    public int Price = 1000;
}

class Program9{
    static string ToJson(object obj){
        Type type = obj.GetType();
        var json = new StringBuilder("{ ");
        foreach (var field in type.GetFields())
            json.Append($"\"{field.Name}\": \"{field.GetValue(obj)}\", ");
        return json.ToString().TrimEnd(',', ' ') + " }";
    }

    static void Main(string[] args){
        Product product = new Product();
        Console.WriteLine(ToJson(product));
    }
}
