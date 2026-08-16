using System.Runtime.CompilerServices;
using System.Xml;

class Person
{

   
    public int age
    {
        get; set;

    }


    public string  Name
    {
        get; set;

    }


    public  virtual void DisplayInfo()
    {
        Console.WriteLine("base class method");
        Console.WriteLine(age + " " + Name);
    }

};


class Teacher : Person
{

    public override void DisplayInfo(){
        Console.WriteLine("overriden method");
        Console.WriteLine(age + " " + Name);
    }



    static void Main(string[] args)
    {
        Person person = new Teacher();
        person.Name = "jeel";
        person.age = 20;
        person.DisplayInfo();
    }

};
