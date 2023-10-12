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
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     *  3. INTEGER k
     */

    public static string appendAndDelete(string s, string t, int k)
    {
       
          int sLength = s.Length;
          int tLength = t.Length;
          int commonLength = 0;
          
          while(commonLength < sLength && commonLength < tLength &&
          s[commonLength] == t[commonLength])
          {
              commonLength++;
          }
          
          int totalOperations = sLength-commonLength + tLength - commonLength;
          
          if(totalOperations <= k && (k - totalOperations) % 2 == 0)
          {
              return "Yes";
          }
          else if(k >= sLength + tLength)
          {
              return "Yes";
          }
          else
          {
              return "No";
          }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
