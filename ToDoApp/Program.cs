using System;
using System.Collections.Generic;
using System.IO;


class TaskItem
{
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
}
class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();
    static string saveFile = @"Z:\Temp\tasks.txt";

    static void Main(string[] args)
    {
        LoadTasks();
        while (true)
        {
            Console.WriteLine("\n--- To-Do Menu ---");
            Console.WriteLine("1) Add Task");
            Console.WriteLine("2) List Tasks");
            Console.WriteLine("3) Mark Task Complete");
            Console.WriteLine("4) Exit");
            Console.Write("Select an option:");

            string input = Console.ReadLine();

            if (input == "1")
            {
                AddTask();
            }
            else if (input == "2")
            {
                ListTasks();
            }
            else if (input == "3")
            {
                MarkComplete();
            }
            else if (input == "4")
            {
                SaveTasks();
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
    static void AddTask()
    {
        Console.Write("Enter task name: ");
        string taskName = Console.ReadLine();

        TaskItem task = new TaskItem
        {
            Name = taskName,
            IsCompleted = false
        };

        tasks.Add(task);
        Console.WriteLine($"Task \"{task.Name}\" added.");
    }
    static void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        Console.WriteLine("\nYour Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            TaskItem task = tasks[i];
            string status = task.IsCompleted ? "X" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {task.Name}");
        }
    }
    static void MarkComplete()
    {
        ListTasks();

        Console.WriteLine("Enter the task to mark complete");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].IsCompleted = true;
            Console.WriteLine($"Task #{taskNumber} marked complete.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    static void SaveTasks()
    {
        using (StreamWriter writer = new StreamWriter(saveFile))
        {
            foreach (TaskItem task in tasks)
            {
                writer.WriteLine($"{task.Name}|{task.IsCompleted}");
            }
        }

        Console.WriteLine("Tasks saved.");
    }
    static void LoadTasks()
    {
        if (!File.Exists(saveFile))
            return;

        string[] lines = File.ReadAllLines(saveFile);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 2)
            {
                tasks.Add(new TaskItem
                {
                    Name = parts[0],
                    IsCompleted = bool.Parse(parts[1])
                });
            }
        }
    }

}