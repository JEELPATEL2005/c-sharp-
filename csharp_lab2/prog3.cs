
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;      
            }
            else
            {
                wordCount.Add(word, 1); 
            }
        }

        Console.WriteLine("\nWord Frequency:");
        foreach (KeyValuePair<string, int> item in wordCount)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.ReadLine();
    }
}
