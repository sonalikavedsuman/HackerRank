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
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
    // Return the minimum number of characters to make the password strong
    
        string numbers = "0123456789";
        string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string specialChar = "!@#$%^&*()-+";
        
        //initialize each boolean flags to false
        bool hasNumbers = false;
        bool hasLowercase = false;
        bool hasUppercase = false;
        bool hasSpecialChar = false;
        
        foreach(char c in password)
        {
            if(numbers.Contains(c))
            {
                hasNumbers = true;
            }
            else if(lowerCase.Contains(c))
            {
                hasLowercase = true;
            }
            else if(upperCase.Contains(c))
            {
                hasUppercase = true;
            }
            else if(specialChar.Contains(c))
            {
                hasSpecialChar = true;
            }
        }
     int missingFromFour = 4 
                           -(hasNumbers ? 1 : 0) 
                           - (hasLowercase ? 1 : 0)
                           - (hasUppercase ? 1 : 0)
                           - (hasSpecialChar ? 1 : 0);
                           
     int requiredCharacters = Math.Max(0, 6 - n);
    
     return Math.Max(requiredCharacters, missingFromFour);
    }
   
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
