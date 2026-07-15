using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("----- LIST -----");

        List<int> list = new List<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        list.Insert(2, 25);

        Console.WriteLine("List Elements:");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nCount = " + list.Count);
        Console.WriteLine("Contains 30? " + list.Contains(30));
        list.Remove(40);
        list.RemoveAt(0);

        Console.WriteLine("After Removing:");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nFirst Element = " + list[0]);

        
        Console.WriteLine("\n\n----- DICTIONARY -----");

        Dictionary<int, int> dict = new Dictionary<int, int>();

        dict.Add(1, 100);
        dict.Add(2, 200);
        dict.Add(3, 300);
        dict.Add(4, 400);
        dict.Add(5, 500);

        foreach (KeyValuePair<int, int> item in dict)
        {
            Console.WriteLine("Key = " + item.Key + " Value = " + item.Value);
        }

        Console.WriteLine("Count = " + dict.Count);
        Console.WriteLine("Contains Key 3? " + dict.ContainsKey(3));
        Console.WriteLine("Contains Value 500? " + dict.ContainsValue(500));
        Console.WriteLine("Value of Key 2 = " + dict[2]);
        dict.Remove(4);

        Console.WriteLine("After Removing Key 4:");
        foreach (KeyValuePair<int, int> item in dict)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }

        Console.WriteLine("\n----- STACK -----");

        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        Console.WriteLine("Stack Elements:");
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nCount = " + stack.Count);
        Console.WriteLine("Top Element = " + stack.Peek());
        Console.WriteLine("Removed = " + stack.Pop());

        Console.WriteLine("After Pop:");
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nContains 20? " + stack.Contains(20));

        Console.WriteLine("\n\n----- QUEUE -----");

        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.WriteLine("Queue Elements:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nCount = " + queue.Count);
        Console.WriteLine("Front Element = " + queue.Peek());
        Console.WriteLine("Removed = " + queue.Dequeue());

        Console.WriteLine("After Dequeue:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nContains 40? " + queue.Contains(40));

        Console.ReadLine();
    }
}
