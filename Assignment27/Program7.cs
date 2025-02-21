using System;
using System.IO;

class Program7{
    public static void Main(string[] args){
        string filePath = "students.dat";
        //writing student data
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs)){
            writer.Write(101);
            writer.Write("Vidya");
            writer.Write(3.8);
            writer.Write(102);
            writer.Write("Sagar");
            writer.Write(3.5);

            Console.WriteLine("Data written to file");
        }

        //reading data
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs)){
            while(fs.Position<fs.Length){
                int rollNo = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine("Roll No= " + rollNo + ", Name= " + name + ", GPA= " + gpa);
            }
        }
    }
}
