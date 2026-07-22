class Student
{

    public int sid { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }

    public string  Department { get; set;}
    public int Semester { get; set; }

    public double CGPA { get; set; }
       
}

class Program
{


    static void Main()
    {
        List<Student> student = new List<Student>()
        {
            new Student { sid = 1, Name = "john", Department = "CE", Semester = 4, Age = 20, CGPA = 8.5 },
            new Student { sid = 2, Name = "adam", Department = "IT", Semester = 6, Age = 21, CGPA = 9.5 },
            new Student { sid = 3, Name = "david", Department = "ML", Semester = 5, Age = 19, CGPA = 8.2 },
            new Student { sid = 4, Name = "lary", Department = "EC", Semester = 4, Age = 20, CGPA = 8.0 },
           new Student { sid = 5, Name = "bob", Department = "CE", Semester = 4, Age = 20, CGPA = 9.5 },

        };

        var result = from n in student  where n.CGPA > 8.0 select n;

        Console.WriteLine("Display the names of students whose CGPA is greater than 8.0.\n");
        foreach(var item in result)
        {

            Console.WriteLine("name of the student " + item.Name);
            Console.WriteLine("student CGPA " + item.CGPA);

        }

        Console.WriteLine("Display all students belonging to the Computer Engineering department, sorted by CGPA in descending order.  \r\n");

            var result1 = from n in student where n.Department == "CE" orderby n.CGPA descending select n;

        foreach (var item in result1)
        {
            Console.WriteLine("name of the student " + item.Name);
            Console.WriteLine("student CGPA " + item.CGPA);
        }

        Console.WriteLine("  Display the top three students based on CGPA.\n");

      var result2 = student.OrderByDescending(student => student.CGPA).Take(3);

        foreach (var item in result2)
        {
            Console.WriteLine("name of the student " + item.Name);
            Console.WriteLine("student CGPA " + item.CGPA);
        }



       Console.WriteLine(" Count the number of students in each department and display the result.\n");


      var result3 = student
    .GroupBy(s => s.Department)
    .Select(g => new
    {
        Department = g.Key,
        Count = g.Count()
    });

        foreach (var item in result3)
        {
            Console.WriteLine($"Department: {item.Department}, Total Students: {item.Count}");
        }



    }

}
