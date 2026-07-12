
List<int> arr = new List<int>();

int total = 0;
for(int i=0; i<5; i++)
{ 
     arr.Add(int.Parse(Console.ReadLine()));

}



for (int i=0; i<5; i++)
{
    total += arr[i];

}
Console.WriteLine("total score is " + total);


double percentage = (total/500.0) * 100;

Console.WriteLine(percentage);

if (percentage > 90)
{
    Console.WriteLine("grade "+"AA");
}

else if (percentage > 80)
{
    Console.WriteLine("grade " + "AB");
}
else if (percentage > 70)
{
    Console.WriteLine("grade " + "BB");
}
else if (percentage > 60)
{
    Console.WriteLine("grade " + "BC");
}
else if (percentage > 50)
{
    Console.WriteLine("grade " + "CC");

}
else Console.WriteLine("grade " + "Fail");
