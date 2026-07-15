using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>();
        int choice;
        string name, newName;

        do
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Student Name: ");
                    name = Console.ReadLine();

                    students.Add(name);
                    Console.WriteLine("Student Added Successfully.");
                    break;

                case 2:
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No Students Found.");
                    }
                    else
                    {
                        Console.WriteLine("\nStudent List:");
                        foreach (string student in students)
                        {
                            Console.WriteLine(student);
                        }
                    }
                    break;

                case 3:
                    Console.Write("Enter Student Name to Search: ");
                    name = Console.ReadLine();

                    if (students.Contains(name))
                    {
                        Console.WriteLine("Student Found.");
                    }
                    else
                    {
                        Console.WriteLine("Student Not Found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter Existing Student Name: ");
                    name = Console.ReadLine();

                    if (students.Contains(name))
                    {
                        int index = students.IndexOf(name);

                        Console.Write("Enter New Student Name: ");
                        newName = Console.ReadLine();

                        students[index] = newName;

                        Console.WriteLine("Student Updated Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student Not Found.");
                    }
                    break;

                case 5:
                    Console.Write("Enter Student Name to Delete: ");
                    name = Console.ReadLine();

                    if (students.Contains(name))
                    {
                        students.Remove(name);
                        Console.WriteLine("Student Deleted Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student Not Found.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Exiting Application...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 6);
    }
}

