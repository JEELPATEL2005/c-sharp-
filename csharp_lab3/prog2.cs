using System;
using System.Runtime.CompilerServices;

class Program
{

    delegate int Operation(int a, int b);

    static int Add (int x , int y)
    {
        return x + y;
    }

    static int subtract(int x, int y)
    {
        return x - y;
    }

    static int Mul (int x, int y)
    {
        return x * y;
    }

    static int Division(int x, int y)
    {
        return x / y;
    }

    static void Main()
    {


        char op = char.Parse(Console.ReadLine());

        int x = int.Parse(Console.ReadLine());

        int y = int.Parse(Console.ReadLine());


        Operation ope = Add;
        int result = ope(x, y);
        switch (op)
        {
            case '+':

                 ope = Add;
                 result = ope(x, y);
                Console.WriteLine("addition operation " + result);
                break;

            case '-':
                ope = subtract;
                result = ope(x, y);
                Console.WriteLine("subtraction operation " + result);

                break;

            case '*':
                ope = Mul;
                result = ope(x, y);
                Console.WriteLine("multipication operation " + result);
                break;
            case '/':
                ope = Division;
                result = ope(x, y);
                Console.WriteLine("division operation " + result);
                break;

            default: 
                Console.WriteLine("Unknown operator.");
                break;
        }

           

    }
}
