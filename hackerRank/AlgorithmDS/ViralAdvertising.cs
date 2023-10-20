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
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {
        double shared = 5;
        double liked = Math.Floor(shared / 2);
        double cumulative = liked;
        for (int i= 1; i <= n ; i++) 
        {
            if(i == 1)
            {
                shared = 5;
                liked = Math.Floor(shared / 2);
            }
            else if(i > 1)
            {
                shared = 3 * liked;
                liked = Math.Floor(shared / 2);
                cumulative = cumulative + liked;
            }
        }
        return((int)cumulative);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
