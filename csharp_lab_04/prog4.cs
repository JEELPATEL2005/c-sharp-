abstract class shape
{
    public int length
    {
        get; set;
    }
    public int breath
    { get; set; }

    public int radius { get; set; }
    public abstract void CalculateArea();
    

    
}

class regtangle : shape
{
    public override void CalculateArea()
    {
        Console.WriteLine("area of rectangle" + length * breath);
    }



}

class circle : shape
{
    public override void CalculateArea()
    {
        Console.WriteLine("area of circle " + 3.14f * radius * radius);
    }
}


class Main_invoke
{
    static void Main(string[] args)
    {
        regtangle s = new regtangle();
        s.length = 10;
        s.breath = 20;

        s.CalculateArea();
        circle c = new circle();

        
        c.radius = 5;

        c.CalculateArea();
    }
}

