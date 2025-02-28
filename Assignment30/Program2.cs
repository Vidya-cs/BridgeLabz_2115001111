using System;

class LegacyAPI{
        [Obsolete("This method is old use NewFeature() instead")]
        public void OldFeature(){
            Console.WriteLine("This is old feature");
        }

        public void NewFeature(){
            Console.WriteLine("This is a new feature");
        }
    }

    class Program2{
        public static void Main(string[] args){
            LegacyAPI feature= new LegacyAPI();
            feature.OldFeature();
            feature.NewFeature();
        }
    }

