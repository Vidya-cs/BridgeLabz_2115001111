using System;

class Program4{
	
    public static void Main(String[] args){
		
        int num = int.Parse(Console.ReadLine());
		
        int largest = 0, secondLargest = 0;

        int maxDigit = 10; 
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits from the number
        while(num != 0){
            if(index == maxDigit){
                //Increase the size of the array if needed
                maxDigit += 10; 
                int[] temp = new int[maxDigit];
				for(int j = 0; j < digits.Length; j++){
					temp[j] = digits[j];
				}
                digits = temp;
            }

            //Store the current digit
            digits[index] = num % 10;
            num /= 10;
            index++;
        }

        // Find the largest and second-largest digits
        for(int i= 0; i<index; i++){
            if(digits[i]> largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if(digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Output the results
        Console.WriteLine("Largest digit is: " + largest);
        if(secondLargest != 0){
            Console.WriteLine("Second largest digit is: " + secondLargest);
        }
        else{
            Console.WriteLine("No second largest digit found.");
        }
    }
}
