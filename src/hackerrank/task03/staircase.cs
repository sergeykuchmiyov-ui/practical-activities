using System;

class Result
{
    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string spaces = new string(' ', n - i);
            string steps = new string('#', i);
            Console.WriteLine(spaces + steps);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Result.staircase(n);
    }
}