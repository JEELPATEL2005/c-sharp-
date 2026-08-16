
using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int RollNumber;
    public string Course;
}

class Main_Start
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                Name = "jeel",
                RollNumber = 1,
                Course = "ML"
            },
            new Student
            {
                Name = "john",
                RollNumber = 2,
                Course = "devops"
            },
            new Student
            {
                Name = "david",
                RollNumber = 3,
                Course = "gen ai"
            },
            new Student
            {
                Name = "bob",
                RollNumber = 4,
                Course = "deployment"
            }
        };

        foreach (Student stu in students)
        {
            Console.WriteLine("Name: " + stu.Name);
            Console.WriteLine("Roll Number: " + stu.RollNumber);
            Console.WriteLine("Course: " + stu.Course);
            Console.WriteLine();
        }
    }
}

