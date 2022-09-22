//Un-comment below code and fix the issues
//Push to github
int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    int newnumber = first + second;
    first = second;
    second = newnumber;

    if (count == 0)
    {
        return newnumber;
    }
    else
    {
        return RecursiveFibonacci(first, second, count);
    }
}

int lastFibo = RecursiveFibonacci(1, 1, 5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine();


