using System;

class HashNode{
    int Key;
    int Value;
    HashNode Next;
    public HashNode(int key, int value){
        Key = key;
        Value = value;
        Next = null;
    }
}

class CustomHashMap{
    HashNode[] table = new HashNode[10];
    public int HashFunction(int key){
        return key % 10;
    }

    public void Insert(int key, int value){
        int index = HashFunction(key);
        HashNode newNode = new HashNode(key, value);
        if (table[index] == null){
            table[index] = newNode;
        }
        else
        {
            HashNode temp = table[index];
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public int Get(int key)
    {
        int index = HashFunction(key);
        HashNode temp = table[index];

        while (temp != null)
        {
            if (temp.Key == key)
                return temp.Value;
            temp = temp.Next;
        }
        return -1; // not found
    }

    public void Remove(int key)
    {
        int index = HashFunction(key);
        HashNode temp = table[index], prev = null;

        if (temp != null && temp.Key == key)
        {
            table[index] = temp.Next;
            return;
        }

        while (temp != null && temp.Key != key)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null)
            return;

        prev.Next = temp.Next;
    }

    public void Display(){
        for(int i = 0; i < 10; i++)
        {
            Console.Write("Bucket " + i + ": ");
            HashNode temp = table[i];
            while (temp != null)
            {
                Console.Write("(" + temp.Key + "," + temp.Value + ") ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}

class Program9{
    public static void Main(string[] args){
        CustomHashMap hashMap = new CustomHashMap();

        hashMap.Insert(1, 100);
        hashMap.Insert(11, 200);
        hashMap.Insert(21, 300);

        Console.WriteLine("Custom Hash Map:");
        hashMap.Display();

        Console.WriteLine("Get key 11: " + hashMap.Get(11));

        hashMap.Remove(11);
        Console.WriteLine("After removing key 11:");
        hashMap.Display();
    }
}