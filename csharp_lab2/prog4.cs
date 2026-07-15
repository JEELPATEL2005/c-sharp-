using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> browserHistory = new Stack<string>();
        List<string> completeHistory = new List<string>();

        int choice;
        string page;

        do
        {
            Console.WriteLine("\n===== BROWSER HISTORY =====");
            Console.WriteLine("1. Visit New Webpage");
            Console.WriteLine("2. Go Back");
            Console.WriteLine("3. View Current Page");
            Console.WriteLine("4. Display Browsing History");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Webpage Name: ");
                    page = Console.ReadLine();

                    browserHistory.Push(page);
                    completeHistory.Add(page);

                    Console.WriteLine("Webpage Visited Successfully.");
                    break;


                case 2:
                    if (browserHistory.Count > 0)
                    {
                        string removedPage = browserHistory.Pop();
                        
                        if (browserHistory.Count > 0){
                            completeHistory.Add(browserHistory.Peek());
                        }

                        Console.WriteLine("Previous Page Removed: " + removedPage);
                    }
                    else
                    {
                        Console.WriteLine("No Browsing History Available.");
                    }
                    break;


                case 3:
                    if (browserHistory.Count > 0)
                    {
                        Console.WriteLine("Current Page: " + browserHistory.Peek());
                    }
                    else
                    {
                        Console.WriteLine("No Current Page.");
                    }
                    break;


                case 4:
                    Console.WriteLine("\nBrowsing History:");

                    foreach (string item in completeHistory)
                    {
                        Console.WriteLine(item);
                    }

                    break;


                case 5:
                    Console.WriteLine("Exiting Application...");
                    break;


                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 5);
    }
}
