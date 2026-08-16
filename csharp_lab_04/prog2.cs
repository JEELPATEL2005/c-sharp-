using System;
using System.Collections.Generic;

class Student
{
    private string name;
    private int rollNumber;
    private string course;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int RollNumber
    {
        get { return rollNumber; }
        set
        {
            if (value > 0)
            {
                rollNumber = value;
            }
            else
            {
                Console.WriteLine("Roll Number must be positive.");
            }
        }
    }

    public string Course
    {
        get { return course; }
        set { course = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                Name = "Jeel",
                RollNumber = 1,
                Course = "ML"
            },
            new Student
            {
                Name = "John",
                RollNumber = 2,
                Course = "DevOps"
            },
            new Student
            {
                Name = "David",
                RollNumber = -3,  
                Course = "Gen AI"
            },
            new Student
            {
                Name = "Bob",
                RollNumber = 4,
                Course = "Deployment"
            }
        };

        foreach (Student stu in students)
        {
            Console.WriteLine($"Name: {stu.Name}");
            Console.WriteLine($"Roll Number: {stu.RollNumber}");
            Console.WriteLine($"Course: {stu.Course}");
            Console.WriteLine();
        }
    }
}
