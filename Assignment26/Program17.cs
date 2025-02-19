using System;
using System.Collections.Generic;

class Program17{
    static void Main(string[] args){
        Dictionary<string, int> votes = new Dictionary<string, int>();
        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
        List<string> voteOrder = new List<string>();

        string[] castVotes = { "Vidya", "Pragyan", "Rahul", "Sanskar", "Sagar", "Vidya" };
        for(int i= 0; i<castVotes.Length; i++)[
            string candidate = castVotes[i];
            if (!votes.ContainsKey(candidate)){
                votes[candidate] = 0;
            }
            votes[candidate]++;
            voteOrder.Add(candidate);
        }

        List<string> keys = new List<string>(votes.Keys);
        for (int i = 0; i < keys.Count; i++){
            sortedVotes[keys[i]] = votes[keys[i]];
        }

        Console.WriteLine("Vote Count:");
        List<string> voteKeys = new List<string>(votes.Keys);
        for (int i = 0; i < voteKeys.Count; i++){
            Console.WriteLine(voteKeys[i] + ": " + votes[voteKeys[i]]);
        }

        Console.WriteLine("\nSorted Results:");
        List<string> sortedKeys = new List<string>(sortedVotes.Keys);
        for (int i = 0; i < sortedKeys.Count; i++){
            Console.WriteLine(sortedKeys[i] + ": " + sortedVotes[sortedKeys[i]]);
        }

        Console.WriteLine("\nOrder of Votes Cast:");
        for (int i = 0; i < voteOrder.Count; i++){
            Console.Write(voteOrder[i] + " ");
        }
    }
}
