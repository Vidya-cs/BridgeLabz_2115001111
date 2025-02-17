using System;

class PetrolPump{
    int Petrol;
    int Distance;
    PetrolPump Next;

    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        Distance = distance;
        Next = null;
    }
}

class CircularTour
{
    private PetrolPump head;

    public void AddPump(int petrol, int distance)
    {
        PetrolPump newPump = new PetrolPump(petrol, distance);
        if (head == null)
        {
            head = newPump;
            head.Next = head;
            return;
        }
        PetrolPump temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }
        temp.Next = newPump;
        newPump.Next = head;
    }

    public int FindStartingPump()
    {
        PetrolPump start = head, temp = head;
        int fuel = 0;

        do
        {
            fuel += temp.Petrol - temp.Distance;
            if (fuel < 0)
            {
                start = temp.Next;
                fuel = 0;
            }
            temp = temp.Next;
        } while (temp != head);

        return start.Petrol > 0 ? start.Petrol : -1;
    }
}

class Program5{
    public static void Main(string[] args)
    {
        CircularTour tour = new CircularTour();
        tour.AddPump(4, 6);
        tour.AddPump(6, 5);
        tour.AddPump(7, 3);
        tour.AddPump(4, 5);

        Console.WriteLine("Starting Pump Petrol Amount: " + tour.FindStartingPump());
    }
}