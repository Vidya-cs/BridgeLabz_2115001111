using System;
using System.Reflection;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;

public interface IGreeting{
    void SayHello();
}

public class Greeting : IGreeting{
    public void SayHello(){
        Console.WriteLine("Hello");
    }
}

public class LoggingProxy<T> : RealProxy where T : class{
    private readonly T instance;
    public LoggingProxy(T instance) : base(typeof(T)){
        instance = instance;
    }

    public override IMessage Invoke(IMessage msg){
        IMethodCallMessage callMessage = msg as IMethodCallMessage;

        //calling the original method
        object returnValue = callMessage.MethodBase.Invoke(instance, callMessage.Args);
        return new ReturnMessage(returnValue, null, 0, callMessage.LogicalCallContext, callMessage);
    }
}

class Program10{
    static void Main(string[] args){
		
        IGreeting original = new Greeting();
        IGreeting proxy = (IGreeting)new LoggingProxy<IGreeting>(original).GetTransparentProxy();
        proxy.SayHello();
    }
}
