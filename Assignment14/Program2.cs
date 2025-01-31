using System;

class Circle{
	
    double radius;

	public Circle(double radius){
        this.radius = radius;
    }

    //Method to calculate area of circle
    public double CalculateArea(){
        return Math.PI*radius*radius;
    }

    //Method to calculate circumference of circle
    public double Circumference(){
        return 2*Math.PI*radius;
    }

    //Method to display area and circumference
    public void DisplayDetails(){
        Console.WriteLine("Area of Circle is " + CalculateArea());
        Console.WriteLine("Circumference of Circle is " + Circumference());
    }
}

class Program2{

    public static void Main(String[] args){
		
        Circle obj = new Circle(5);

        obj.DisplayDetails();
    }
}
