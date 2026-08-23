class Async_calculator
{

    static async Task<string> Addition (int a , int b)
    {
        int result = a + b;

        await Task.Delay(2000);

        return "addition opperation " + result;
         
    }

    static async Task<string> Subtraction(int a , int b)
    {
        int result = a - b;

        await Task.Delay(2000);

        return "subtraction operation " + result;
    }


    static async Task<string> Multiplication(int a , int b)
    {
        int result = a * b;
        await Task.Delay(1000);

        return "multipication operation " + result;
    }

    static async Task<string> Division(int a , int b)
    {
        int result = a / b;

        await Task.Delay(1000);

        return "division operation " + result;

    }


    static async Task Main(string[] args)
    {

        Task<string> op1 = Addition(5, 6);
        Task<string> op2 = Subtraction(5, 6);
        Task<string> op3 = Multiplication(5, 6);
        Task<string> op4 = Division(5, 6);


        string [] arr = await Task.WhenAll(op1, op2, op3, op4);

        foreach(string s in arr)
        {
            Console.WriteLine(s);
        }


    }

}
