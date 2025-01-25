using System;

class Program8{
	
    public static void Main(string[] args){
		
        int number = int.Parse(Console.ReadLine());

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for(int i= 1; i<=number; i++){
            if(number%i == 0){
                if(index == maxFactor){
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    for(int j= 0; j<factors.Length; j++){
                        temp[j] = factors[j];
                    }
                    factors = temp; 
                }
                factors[index++] = i;
            }
        }

        //Displaying the factors
		
        for(int i= 0; i<index; i++){
            Console.Write(factors[i] + " ");
        }
    }
}
