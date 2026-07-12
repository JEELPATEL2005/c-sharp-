int key = 777;
int choice;

do
{
    choice = int.Parse(Console.ReadLine());

    if (key < choice)
    {
        Console.WriteLine("your choice is large");
    }

    else if (key > choice)
    {
        Console.WriteLine("your choice is small");

    }

    else
    {
        Console.WriteLine("Congratulations! you predict right number");
    }


} while (choice != key);
