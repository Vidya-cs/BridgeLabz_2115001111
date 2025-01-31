using System;

class Program1{

    public static int Guess(int low, int high){
		Random rand = new Random();
        return rand.Next(low, high + 1);
    }

    public static void Main(String[] args){

        int low= 1, high= 100;
        bool found= false;

        while(!found){
			
			Console.WriteLine("Guess a number");
            int guess = Guess(low, high);
			Console.WriteLine("Is your number " + guess);
			Console.WriteLine("Type C for correct, H if guess is greater, L if guess is lesser");
			String reply= Console.ReadLine();

            if(reply=="C"){
                Console.WriteLine("I guessed your number correctly");
                found = true;
            }
            else if(reply=="H"){
                high= guess-1;
            }
            else if(reply=="L"){
                low= guess+1;
            }
            else{
                Console.WriteLine("Please enter H, L, or C");
            }
        }
    }
}
