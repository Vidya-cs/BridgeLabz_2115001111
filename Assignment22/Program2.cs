using System;

class StackSort
{
    private int[] stack = new int[100];
    private int top = -1;

    public void Push(int value)
    {
        stack[++top] = value;
    }

    public int Pop()
    {
        return top == -1 ? -1 : stack[top--];
    }

    public void SortStack()
    {
        if (top >= 0)
        {
            int temp = Pop();
            SortStack();
            InsertSorted(temp);
        }
    }

    private void InsertSorted(int value)
    {
        if (top == -1 || stack[top] <= value)
        {
            Push(value);
        }
        else
        {
            int temp = Pop();
            InsertSorted(value);
            Push(temp);
        }
    }

    public void Display()
    {
        for (int i = 0; i <= top; i++)
            Console.Write(stack[i] + " ");
        Console.WriteLine();
    }
}

class Program2{
    public static void Main(string[] args){
        StackSort stack = new StackSort();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);

        Console.WriteLine("Stack before sorting:");
        stack.Display();

        stack.SortStack();

        Console.WriteLine("Stack after sorting:");
        stack.Display();
    }
}
