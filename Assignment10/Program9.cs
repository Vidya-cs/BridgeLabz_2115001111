using System;

class Program9{
    public static double CalculateDistance(int x1, int y1, int x2, int y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    public static double[] FindLineEquation(int x1, int y1, int x2, int y2)
    {
        double[] lineEquation = new double[2];
        double m = (double)(y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        lineEquation[0] = m;
        lineEquation[1] = b;
        return lineEquation;
    }

    public static void Main(String[] args){
		
        Console.Write("Enter x1 ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("enter y1 ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("enter x2 ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("enter y2 ");
        int y2 = int.Parse(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean distance: " + distance);

        double[] line = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of the line: y = " + line[0] + "x + " + line[1]);
    }
}
