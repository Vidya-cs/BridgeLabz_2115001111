using System;

class Program8{
    public static void Method1(){
        throw new ArithmeticException("Division by zero");
    }

    static void Method2(){
        Method1();
    }

    public static void Main(string[] args){
        try{
            Method2();
        }
        catch (ArithmeticException ex){
            Console.WriteLine("Handled in Main " + ex.Message);
        }
    }
}
