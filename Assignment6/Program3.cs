using System;

class Program3{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		int d= num, count=0, largest=0, smallest= int.MaxValue;
		
		//counting the number of digit
		
		while(d!=0){
			count++;
			d/=10;
		}
		
		int[] ar= new int[count];
		d= num;
		
		for(int i=0; i< count; i++){
			ar[i]= d%10;
			d/=10;
			
			//Finding the smallest and largest digit in the same loop
			
			if(largest < ar[i]){
				largest= ar[i];
			}
			if(smallest > ar[i]){
				smallest= ar[i];
			}
		}
		
		Console.WriteLine("Smalles digit is " + smallest + " and the largest digit is " + largest);
	}
}
