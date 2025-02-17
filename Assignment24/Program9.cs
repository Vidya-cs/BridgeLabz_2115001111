using System;

class Program9{
    public static string FindSentence(string[] sentences, string word){
        for(int i= 0; i<sentences.Length; i++){
            if(sentences[i].Contains(word)){
                return sentences[i]; 
            }
        }
        return "Word not found";
    }

    public static void Main(string[] args){
        string[] sentences= {
            "Lorem ipsum",
            "hello world",
            "Linear search",
            "Capgemini India"
        };

        Console.Write("Enter the word to search for ");
        string word = Console.ReadLine();
        string result = FindSentence(sentences, word);
        Console.WriteLine("First matching sentence " + result);
    }
}



