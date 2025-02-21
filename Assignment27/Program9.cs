using System;
using System.IO;

class LargeFileReader
{
    static void Main()
    {
        string filePath = "largefile.log";

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.ToLower().Contains("error")) // Case insensitive search
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
