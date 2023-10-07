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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        //07:05:45PM
      string am_pm = s.Substring(8);
      string hour = s.Substring(0, 2);
      string minSec = s.Substring(2, 6);
      
      if(am_pm == "AM" && hour == "12")
      {
          hour = "00";
      }
      else if(am_pm == "PM")
      {
          int hourInInt = int.Parse(hour);
          if(hourInInt != 12)
          {
              hour = Convert.ToString(12 + hourInInt);
          }
      }
     return $"{hour}{minSec}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
