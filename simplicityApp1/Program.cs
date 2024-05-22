// See https://aka.ms/new-console-template for more information

/*string characterName = "Kojo Wusu";
int characterAge;
characterAge = 3;

Console.WriteLine(" There is a man named " + characterName ) ;
Console.WriteLine(" He is my husband");
Console.WriteLine(" He really like learning new things");

characterName = " Janice";
Console.WriteLine(  characterName + "  is having twins this year ");
Console.WriteLine(" She is " + characterAge + "  years old");

Console.ReadLine();
*/

/*int[] marks = new int[5];
marks[0] = 25;
marks[1] = 10;
marks[2] = 91;
marks[3] = 42;
marks[4] = 13;

foreach (int nark in marks)
    Console.WriteLine(nark);

Console.WriteLine();

for (int i = 0; i < marks.Length; i++)
    Console.WriteLine(marks[0]);

Console.WriteLine();

int[,] multiArray = new int[3, 4]
{ { 1, 2, 3, 4}, { 1, 2, 3, 4}, { 1, 2, 3, 4} };

for (int i = 0; i <=2; i++)
{
    for (int j = 0; j <=3; j++)
    {
        Console.Write(multiArray[i, j] + "\t");
    }
    Console.WriteLine();

}

Console.WriteLine();

/*int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[4];


string str1 = "Hello world";
string str2 = "C# Programming";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
string str3 = string.Concat(str1, str2);
Console.WriteLine(str3);
Console.WriteLine(str1.Equals(str2));
*/


using System;
using System.Collections.Generic;

class TodoList
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Task added: " + task);
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            Console.WriteLine("Task removed: " + tasks[index]);
            tasks.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
        }
        else
        {
            Console.WriteLine("To-Do List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    public void ClearTasks()
    {
        tasks.Clear();
        Console.WriteLine("All tasks have been cleared.");
    }
}

class Program
{
    static void Main()
    {
        TodoList todoList = new TodoList();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nTo-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Clear Tasks");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the task description: ");
                    string task = Console.ReadLine();
                    todoList.AddTask(task);
                    break;
                case "2":
                    Console.Write("Enter the task number to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0)
                    {
                        todoList.RemoveTask(taskNumber - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    break;
                case "3":
                    todoList.ViewTasks();
                    break;
                case "4":
                    todoList.ClearTasks();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting To-Do List Application.");
    }
}
