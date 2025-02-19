using System;
using System.Collections.Generic;

class Program16{
    static void Main(string[] args){
        HashSet<string> uniquePolicies = new HashSet<string>();
        List<string> orderedPolicies = new List<string>(); 
        SortedSet<string> sortedPolicies = new SortedSet<string>();
        Dictionary<string, DateTime> policyExpiryDates = new Dictionary<string, DateTime>();
        Dictionary<string, string> policyCoverageType = new Dictionary<string, string>();
        Dictionary<string, int> policyNumberCount = new Dictionary<string, int>();
        string[] policies = { "P101", "P102", "P103", "P101", "P104", "P102" };
        DateTime today = DateTime.Now;

        for(int i= 0; i<policies.Length; i++){
            string policy = policies[i];
            uniquePolicies.Add(policy);
            orderedPolicies.Add(policy);
            sortedPolicies.Add(policy);

            DateTime expiryDate = today.AddDays(new Random().Next(1, 60));
            policyExpiryDates[policy] = expiryDate;
            policyCoverageType[policy] = i%2==0 ? "Health" : "Auto";

            if(!policyNumberCount.ContainsKey(policy)){
                policyNumberCount[policy] = 0;
            }
            policyNumberCount[policy]++;
        }

        Console.WriteLine("All unique policies");
        List<string> uniqueList = new List<string>(uniquePolicies);
        for (int i = 0; i < uniqueList.Count; i++){
            Console.Write(uniqueList[i] + " ");
        }

        Console.WriteLine("\n\nPolicies Expiring Soon (Next 30 Days):");
        List<string> expiryKeys = new List<string>(policyExpiryDates.Keys);
        for (int i = 0; i < expiryKeys.Count; i++){
            string key = expiryKeys[i];
            if((policyExpiryDates[key]-today).TotalDays <= 30){
                Console.WriteLine(key + " (Expiry: " + policyExpiryDates[key].ToShortDateString() + ")");
            }
        }

        Console.WriteLine("Duplicate policies");
        List<string> policyKeys = new List<string>(policyNumberCount.Keys);
        for (int i = 0; i < policyKeys.Count; i++){
            string key = policyKeys[i];
            if (policyNumberCount[key]>1){
                Console.WriteLine(key + " (Count: " + policyNumberCount[key] + ")");
            }
        }
    }
}
