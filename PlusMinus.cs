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

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float posi = arr.Where(n=>n>0).Count();
        float nega = arr.Where(n=>n<0).Count();
        float zero = arr.Where(n=>n==0).Count();
        float arrSize = arr.Count;
        
       
        Console.WriteLine(String.Format("{0:0.000000}",Math.Round(posi/arrSize,6)));
        Console.WriteLine(String.Format("{0:0.000000}",Math.Round(nega/arrSize,6)));
        Console.WriteLine(String.Format("{0:0.000000}",Math.Round(zero/arrSize,6)));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
