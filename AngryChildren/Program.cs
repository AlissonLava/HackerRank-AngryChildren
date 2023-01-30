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
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     *  
     *  https://www.hackerrank.com/challenges/one-month-preparation-kit-angry-children
     */

    public static int maxMin(int k, List<int> arr)
    {
        arr.Sort();
        List<int> unfairness = new List<int>();

        for (int i = 0; i < arr.Count() - (k - 1); i++)
        {
            //first and k-1th element
            int diff = arr[k + i - 1] - arr[i];
            unfairness.Add(diff);
        }

        unfairness.Sort();
        return unfairness[0];
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.maxMin(k, arr);

        Console.WriteLine(result);
    }
}
