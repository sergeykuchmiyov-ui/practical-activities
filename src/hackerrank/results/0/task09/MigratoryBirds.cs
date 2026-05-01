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

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        
        int maxCount = 0;
        int result = 0;
        
        foreach (int bird in arr)
{
     if (counts.ContainsKey(bird))
    {
        counts[bird]++;
    }
    else
    {
        counts[bird] = 1;
    }  
}

foreach (var pair in counts)
{
    if (pair.Value > maxCount)
{
    maxCount = pair.Value;
    result = pair.Key;
}
    else if (pair.Value == maxCount && pair.Key < result)
{
    result = pair.Key;
}
}

return result;

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
}
