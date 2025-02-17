using System;

class Program6{
    public static void Sort(int[] salary){
        int n= salary.Length;
        for(int i= (n/2-1); i>=0; i--)
            Heapify(salary, n, i);

        for(int i= n-1; i>0; i--){
            (salary[0], salary[i])= (salary[i], salary[0]);
            Heapify(salary, i, 0);
        }
    }

    private static void Heapify(int[] arr, int n, int i){
        int largest= i;
        int left = 2*i+1;
        int right= 2*i+2;
        if(left < n && arr[left] > arr[largest])
             largest = left;
        if(right < n && arr[right] > arr[largest]) 
             largest = right;
        if(largest!=i){
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }

    public static void Main(string[] args){
        int[] salary= {70000, 50000, 90000, 60000, 80000};
        Sort(salary);
        Console.WriteLine("Sorted salaries are");
        foreach(int salary in salary)
            Console.Write(salary + " ");
    }
}
