using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> FindFrequency(string[] words)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (frequency.ContainsKey(words[i]))
            {
                frequency[words[i]]++;
            }
            else
            {
                frequency[words[i]] = 1;
            }
        }
        return frequency;
    }

    public static void Main()
    {
        string[] words = { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> result = FindFrequency(words);

        Console.WriteLine("Frequency of elements:");
        List<string> keys = new List<string>(result.Keys);
        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine(keys[i] + ": " + result[keys[i]]);
        }
    }
}
