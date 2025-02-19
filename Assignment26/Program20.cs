using System;
using System.Collections.Generic;

class Program20{
    static void Main(string[] args){
        Dictionary<int, double> accountBalances = new Dictionary<int, double>();
        SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>();
        Queue<int> withdrawalQueue = new Queue<int>();
        accountBalances[101] = 5000;
        accountBalances[102] = 3000;
        accountBalances[103] = 7000;
        accountBalances[104] = 2000;

        List<int> keys = new List<int>(accountBalances.Keys);
        for (int i = 0; i < keys.Count; i++){
            sortedAccounts[keys[i]] = accountBalances[keys[i]];
        }

        withdrawalQueue.Enqueue(102);
        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        Console.WriteLine("Account Balances");
        List<int> accountKeys = new List<int>(accountBalances.Keys);
        for (int i = 0; i < accountKeys.Count; i++){
            Console.WriteLine("Account " + accountKeys[i] + ": $" + accountBalances[accountKeys[i]]);
        }

        Console.WriteLine("Sorted Accounts by Balance");
        List<int> sortedKeys = new List<int>(sortedAccounts.Keys);
        for (int i = 0; i < sortedKeys.Count; i++){
            Console.WriteLine("Account " + sortedKeys[i] + ": $" + sortedAccounts[sortedKeys[i]]);
        }

        Console.WriteLine("Processing Withdrawals");
        while(withdrawalQueue.Count > 0){
            int account = withdrawalQueue.Dequeue();
            Console.WriteLine("Processing withdrawal for account " + account);
        }
    }
}
