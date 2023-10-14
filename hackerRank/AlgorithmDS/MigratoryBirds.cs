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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
           
        int[] birdCounts = new int[6]; // Since bird types are in the range 1 to 5

        foreach (int birdType in arr)
        {
            birdCounts[birdType]++;
        }
         int mostCommonBird = 1; // Initialize to bird type 1
        int maxCount = birdCounts[mostCommonBird];

        for (int birdType = 2; birdType < birdCounts.Length; birdType++)
        {
            if (birdCounts[birdType] > maxCount)
            {
                mostCommonBird = birdType;
                maxCount = birdCounts[birdType];
            }
        }

        return mostCommonBird;   
    }

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
