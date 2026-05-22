using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static int sockMerchant(int n, List<int> ar)
    {
        
    int pairs = 0;
    Dictionary<int, int> counts = new Dictionary<int, int>();
   
    foreach (int sock in ar)
    {
        if (counts.ContainsKey(sock))
     {
    counts[sock]++;
     }
    else
     {
    counts[sock] = 1;
     }
    }

    foreach (var pair in counts)
    {
       pairs += pair.Value / 2; 
    }

    return pairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
