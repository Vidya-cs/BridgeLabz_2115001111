using System;

class Program2{
    public static void Sort(int[] empID){
        int n= empID.Length;
        for(int i=1; i<n; i++){
            int key= empID[i];
            int j= i-1;
            while(j>=0 && empID[j]>key){
                empID[j+1]= empID[j];
                j--;
            }
            empID[j+1]= key;
        }
    }

    public static void Main(string[] args){
        int[] empID = {104, 102, 101, 105, 103};
        Sort(empID);
        Console.WriteLine("Sorted IDs");
        foreach(int id in empIDs)
            Console.Write(id + " ");
    }
}
