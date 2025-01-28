using System;

class Program10{

    public static bool CollinearSlope(int x1, int y1, int x2, int y2, int x3, int y3){
        
		double slopeAB = (double)(y2 - y1) / (x2 - x1);
        double slopeBC = (double)(y3 - y2) / (x3 - x2);
        double slopeAC = (double)(y3 - y1) / (x3 - x1);
        if (slopeAB == slopeBC && slopeAB == slopeAC){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CollinearArea(int x1, int y1, int x2, int y2, int x3, int y3){
		
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        if (area == 0){
            return true;
        }
        else{
            return false;
        }
    }

    public static void Main(String[] args){
		
		//user input
        Console.Write("Enter x1 ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Enter y1 ");
        int y1 = int.Parse(Console.ReadLine());
        Console.Write("Enter x2 ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Enter y2 ");
        int y2 = int.Parse(Console.ReadLine());
        Console.Write("Enter x3 ");
        int x3 = int.Parse(Console.ReadLine());
        Console.Write("Enter y3 ");
        int y3 = int.Parse(Console.ReadLine());

        bool isCollinearBySlope = CollinearSlope(x1, y1, x2, y2, x3, y3);
        bool isCollinearByArea = CollinearArea(x1, y1, x2, y2, x3, y3);

		//Displayinh the result	
			
        if (isCollinearBySlope && isCollinearByArea){
            Console.WriteLine("The points are collinear");
        }
        else{
            Console.WriteLine("The points are not collinear");
        }
    }
}
