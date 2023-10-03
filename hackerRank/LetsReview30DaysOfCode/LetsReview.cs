using System;
using System.Collections.Generic;
using System.IO;
class Solution {
static void Main(String[] args) 
{
/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
int num = int.Parse(Console.ReadLine());

string[] str = new string[num];
string even;
string odd;

for (int i = 0; i < num; i++)
{
    str[i] = Console.ReadLine();
    even = "";
    odd = "";
    
    for (int j = 0; j <= str[i].Length - 1; j++)
    {
        if (j % 2 == 0)
        {
            even += str[i][j];
        }
        else
        {
            odd += str[i][j];
        }
    }
   
    Console.WriteLine(even + " " + odd);

}
    }
}