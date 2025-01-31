using System;

class Program5{

    public static bool IsPalindrome(String str){
		
        int start= 0, end= str.Length-1;
        
        while(start<end){
            if(str[start]!=str[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }

    public static void Main(String[] args){
		
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        bool result = IsPalindrome(str);
        
        if(result){
            Console.WriteLine("The string is a palindrome");
        }
        else{
            Console.WriteLine("The string is not a palindrome");
        }
    }
}
