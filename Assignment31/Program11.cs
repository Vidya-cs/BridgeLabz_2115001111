using System;
using System.Reflection;

class Service{
    public void Execute(){
		Console.WriteLine("Service executed");
	}
}

class Client{
    public Service MyService;
}

class Program11{
    static void Main(string[] args){
        Client client = new Client();
        Type type = typeof(Client);
        FieldInfo field = type.GetField("MyService");
        field.SetValue(client, new Service());
        ((Service)field.GetValue(client)).Execute();
    }
}
