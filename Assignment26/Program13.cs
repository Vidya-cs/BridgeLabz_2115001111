using System;
using System.Collections.Generic;

class Program13{
    class Patient{
        public string Name;
        public int Severity;

        public Patient(string name, int severity){
            Name = name;
            Severity = severity;
        }
    }

    static List<string> ProcessTriage(Patient[] patients){
        List<string> treatedPatients = new List<string>();
        int size = patients.Length;
        for(int i= 0; i<size-1; i++){
            for(int j= i+1; j<size; j++){
                if(patients[i].Severity<patients[j].Severity){
                    Patient temp = patients[i];
                    patients[i] = patients[j];
                    patients[j] = temp;
                }
            }
        }

        for(int i= 0; i<size; i++){
            treatedPatients.Add(patients[i].Name);
        }
        return treatedPatients;
    }

    public static void Main(string[] args){
        Patient[] patients = {new Patient("John", 3), new Patient("Alice", 5), new Patient("Bob", 2)};
        List<string> result = ProcessTriage(patients);
        Console.WriteLine("Treatment order");
        for(int i= 0; i<result.Count; i++){
            Console.Write(result[i] + " ");
        }
    }
}
