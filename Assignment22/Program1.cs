
using System;

class QueueUsingStacks
{
    private int[] stack1 = new int[100];
    private int[] stack2 = new int[100];
    private int top1 = -1, top2 = -1;

    public void Enqueue(int value)
    {
        stack1[++top1] = value;
    }

    public int Dequeue()
    {
        if (top1 == -1 && top2 == -1)
        {
            Console.WriteLine("Queue is empty.");
            return -1;
        }

        if (top2 == -1)
        {
            while (top1 >= 0)
            {
                stack2[++top2] = stack1[top1--];
            }
        }

        return stack2[top2--];
    }

    public void Display()
    {
        if (top1 == -1 && top2 == -1)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        for (int i = top2; i >= 0; i--)
            Console.Write(stack2[i] + " ");
        for (int i = 0; i <= top1; i++)
            Console.Write(stack1[i] + " ");
        Console.WriteLine();
    }
}

class Program1
{
    public static void Main(string[] args)
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Queue after enqueue:");
        queue.Display();

        Console.WriteLine("Dequeued: " + queue.Dequeue());
        queue.Display();
    }
}

