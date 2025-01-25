using System;

class Program5{
	public static void Main(String[] args){
		
		int num= int.Parse(Console.ReadLine());
		
		int d= num, count=0;
		
		//counting the number of digit
		
		while(d!=0){
			count++;
			d/=10;
		}
		
		int[] ar= new int[count];
		int[] revArr= new int[count];
		d= num;
		
		for(int i=0; i< count; i++){
			ar[i]= d%10;
			d/=10;
			revArr[i]= ar[i];
		}
		
		//Displaying the array
		
		for(int i=0; i< count; i++){
			Console.Write(revArr[i] + " ");
		}
	}
}
