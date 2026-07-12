
int num1, num2;

Console.WriteLine("num1");
num1 = int.Parse(Console.ReadLine());


Console.WriteLine("num2");
num2 = int.Parse(Console.ReadLine());


char c;


Console.WriteLine("choose arithmetic operation ");
c = char.Parse(Console.ReadLine());

switch (c)
{
    case '/':
        Console.WriteLine("divide operation");
        Console.WriteLine("answer : "+ num1/num2);
        break;

    case '+':

        Console.WriteLine("addition operation");
        Console.WriteLine("answer : " + num1 + num2);

        break;


    case '-':

        Console.WriteLine("subtraction operation");
        Console.WriteLine("answer : ", + num1 - num2);

        break;


    case '*':

        Console.WriteLine("multipication operation");
        Console.WriteLine("answer : ",+ num1 * num2);

        break;

    case '%':

        Console.WriteLine("modulo operation");
        Console.WriteLine("answer : ",+ num1 % num2);

        break;


    default:

        Console.WriteLine("you have choose wrong operation");
       
        break;

}
