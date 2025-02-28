using System;
using System.Collections;

    class Program3{
        #pragma warning disable CS8600
        public static void Main(string[] args){
            ArrayList list = new ArrayList(); 
            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);
            foreach(var item in list){
                Console.WriteLine(item);
            }
        }
		//restores the warning
        #pragma warning restore CS8600 
    }
