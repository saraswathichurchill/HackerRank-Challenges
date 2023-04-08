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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
       string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    char ch = (char)(((int)s[i] + k - 65) % 26 + 65);
                    result = result + ch;
                }
                else if (char.IsLower(s[i]))
                {
                    char ch = (char)(((int)s[i] + k - 97) % 26 + 97);
                    result = result + ch; 
                }
                else
                {
                    result = result +s[i];
                }
            }
        return result;
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
