using System;

class Operators
{
    static void Main(string[] args)
    {
// Arithmetic Operators
        int a = 10, b = 3;
        Console.WriteLine("Addition (a+b)= "+ a+b);
        Console.WriteLine("Subtraction (a-b)= "+ a-b);
        Console.WriteLine("Multiplication (a*b)= "+ a*b);
        Console.WriteLine("Division (a/b)= "+ a/b);
        Console.WriteLine("Modulus (a%b)= "+ a%b);

// Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine($"{a} > {b}: {a > b}");
        Console.WriteLine($"{a} < {b}: {a < b}");
        Console.WriteLine($"{a} >= {b}: {a >= b}");
        Console.WriteLine($"{a} <= {b}: {a <= b}");
        Console.WriteLine($"{a} == {b}: {a == b}");
        Console.WriteLine($"{a} != {b}: {a != b}");

 // Logical Operators
        bool x = true, y = false;
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine($"AND (x && y): {x && y}");
        Console.WriteLine($"OR (x || y): {x || y}");
        Console.WriteLine($"NOT (!x): {!x}");

// Bitwise Operators
        int c = 5;
        int d = 3;
        Console.WriteLine("\nBitwise Operators:");
        Console.WriteLine($"Bitwise AND (c & d): {c & d}");
        Console.WriteLine($"Bitwise OR (c | d): {c | d}");
        Console.WriteLine($"Bitwise XOR (c ^ d): {c ^ d}");
        Console.WriteLine($"Bitwise Complement (~c): {~c}");
        Console.WriteLine($"Left Shift (c << 1): {c << 1}");
        Console.WriteLine($"Right Shift (c >> 1): {c >> 1}");

// Assignment Operators
        int e = 5;
        Console.WriteLine("\nAssignment Operators:");
        Console.WriteLine("e= "+ e);
        e += 3; 
		Console.WriteLine($"e += 3: {e}");
        e -= 2;
		Console.WriteLine($"e -= 2: {e}");
        e *= 2;
		Console.WriteLine($"e *= 2: {e}");
        e /= 2;
		Console.WriteLine($"e /= 2: {e}");
        e %= 2;
		Console.WriteLine($"e %= 2: {e}");

// Unary Operators
        int f = 5;
        Console.WriteLine("\nUnary Operators:");
        Console.WriteLine($"Post-increment (f++): {f++}");
        Console.WriteLine($"After Post-increment: {f}");  
        Console.WriteLine($"Pre-increment (++f): {++f}"); 
        Console.WriteLine($"Post-decrement (f--): {f--}");
        Console.WriteLine($"After Post-decrement: {f}");  
        Console.WriteLine($"Pre-decrement (--f): {--f}"); 

 // Conditional/Ternary Operator
        int age = 18;
        string result = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine(result);
    }
}
