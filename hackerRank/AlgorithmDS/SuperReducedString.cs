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
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
    {
        int length = s.Length;
        char[] reducedString = new char[length];
        int reducedLength = 0;
        
        for(int i = 0; i < length; i++)
        {
            if(reducedLength > 0 && reducedString[reducedLength -1] == s[i])
            {
                reducedLength--;
            }
            else
            {
                reducedString[reducedLength] = s[i];
                reducedLength++;
            }
        }
        if (reducedLength == 0)
        {
            return "Empty String";
        }

        return new string(reducedString, 0, reducedLength);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
