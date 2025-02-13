using System;

class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public TaskNode Next;

    public TaskNode(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head = null;
    private TaskNode currentTask = null;

    public void AddTaskAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head; // Circular link
            currentTask = head;
            return;
        }
        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }
        temp.Next = newTask;
        newTask.Next = head;
    }

    public void AddTaskAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head;
            currentTask = head;
            return;
        }
        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }
        temp.Next = newTask;
        newTask.Next = head;
        head = newTask;
    }

    public void AddTaskAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position)
    {
        if (position == 1)
        {
            AddTaskAtBeginning(taskID, taskName, priority, dueDate);
            return;
        }
        TaskNode newTask = new TaskNode(taskID, taskName, priority, dueDate);
        TaskNode temp = head;
        for (int i = 1; temp.Next != head && i < position - 1; i++)
        {
            temp = temp.Next;
        }
        newTask.Next = temp.Next;
        temp.Next = newTask;
    }

    public void RemoveTask(int taskID)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty.");
            return;
        }

        TaskNode temp = head, prev = null;

        if (head.TaskID == taskID && head.Next == head)
        {
            head = null;
            return;
        }

        do
        {
            if (temp.TaskID == taskID)
            {
                if (prev != null)
                {
                    prev.Next = temp.Next;
                    if (temp == head)
                        head = temp.Next;
                }
                else
                {
                    TaskNode last = head;
                    while (last.Next != head)
                    {
                        last = last.Next;
                    }
                    head = head.Next;
                    last.Next = head;
                }
                Console.WriteLine("Task removed successfully.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Task not found.");
    }

    public void ViewCurrentTask()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        Console.WriteLine("Current Task: " + currentTask.TaskName + ", Due: " + currentTask.DueDate.ToShortDateString());
    }

    public void MoveToNextTask()
    {
        if (currentTask != null)
        {
            currentTask = currentTask.Next;
        }
    }

    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        TaskNode temp = head;
        do
        {
            Console.WriteLine("Task ID: " + temp.TaskID + ", Name: " + temp.TaskName + ", Priority: " + temp.Priority + ", Due: " + temp.DueDate.ToShortDateString());
            temp = temp.Next;
        } while (temp != head);
    }

    public TaskNode SearchTaskByPriority(int priority)
    {
        if (head == null)
            return null;

        TaskNode temp = head;
        do
        {
            if (temp.Priority == priority)
                return temp;
            temp = temp.Next;
        } while (temp != head);

        return null;
    }
}

class Program
{
    public static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTaskAtEnd(101, "Complete Report", 2, new DateTime(2024, 2, 20));
        scheduler.AddTaskAtEnd(102, "Submit Assignment", 1, new DateTime(2024, 2, 18));
        scheduler.AddTaskAtBeginning(103, "Meeting with Manager", 3, new DateTime(2024, 2, 25));
        scheduler.AddTaskAtPosition(104, "Code Review", 2, new DateTime(2024, 2, 22), 2);

        Console.WriteLine("\nAll Tasks:");
        scheduler.DisplayAllTasks();

        Console.WriteLine("\nViewing Current Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nMoving to Next Task:");
        scheduler.MoveToNextTask();
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nSearching for Task with Priority 2:");
        TaskNode foundTask = scheduler.SearchTaskByPriority(2);
        if (foundTask != null)
            Console.WriteLine("Found Task: " + foundTask.TaskName);
        else
            Console.WriteLine("No Task Found.");

        Console.WriteLine("\nRemoving Task ID 102:");
        scheduler.RemoveTask(102);

        Console.WriteLine("\nUpdated Task List:");
        scheduler.DisplayAllTasks();
    }
}
