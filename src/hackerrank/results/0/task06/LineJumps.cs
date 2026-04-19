using System;

class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (x1 < x2 && v1 <= v2)
        {
            return "NO";
        }

        while (x1 <= x2)
        {
            if (x1 == x2)
            {
                return "YES";
            }

            x1 += v1;
            x2 += v2;
        }

        return "NO";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int x1 = 0;
        int v1 = 3;
        int x2 = 4;
        int v2 = 2;

        string result = Result.kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}