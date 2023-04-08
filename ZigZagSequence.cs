using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;


class Result{
    public static List<int> ZigZag(List<int> arr)
    {
        int n=arr.Count;
        int midIndex = n/2;
        int lastIndex = n-1;
        arr.Sort();
        
        int max = arr[lastIndex];
        arr[lastIndex] = arr[midIndex];
        arr[midIndex] = max;
        
        int leftIndex = midIndex+1;
        int rightIndex = lastIndex-1;
        while (leftIndex < rightIndex)
        {
                int tmp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = tmp;

                leftIndex++;
                rightIndex--;
        }
       // Console.WriteLine(String.Join(" ", arr));
        return arr;
    }
}
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        if((t>=1) || (t<=20))
        {
            for(int i=0; i<t; i++)
            {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
                if((n%2==1) && ((n>=1) || (n<=10000)))
                {
                    //List<int> arr = new List<int>(n);
                    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                    //for(int j=0; j<n; j++)
                    //{
                    //    int temp = Convert.ToInt32(Console.ReadLine().Trim());
                    //    arr.Add(temp);
                    //}
                    Int64 arrSize = arr.Count;
                    double maxSize = Math.Pow(10,9);
                    if((arrSize>=(Int64)1) || (arrSize<=maxSize))
                    {
                        List<int> result = Result.ZigZag(arr);
                        
                        textWriter.WriteLine(String.Join(" ", result));

                    
                    }
                }
            }
        }
        textWriter.Flush();
        textWriter.Close();

    }
}
