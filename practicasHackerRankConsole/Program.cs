//using System;
//using System.Collections.Generic;
//using System.IO;
//class Solution
//{

//    static int solveMeFirst(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(String[] args)
//    {
//        int val1 = Convert.ToInt32(Console.ReadLine());
//        if (val1 < 1)
//        {
//            val1 = Convert.ToInt32(Console.ReadLine());
//        }
//        int val2 = Convert.ToInt32(Console.ReadLine());
//        if (val2 > 1000)
//        {
//            val2 = Convert.ToInt32(Console.ReadLine());
//        }

//        int sum = solveMeFirst(val1, val2);
//        Console.WriteLine(sum);
//    }
//}
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
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    //    public static int simpleArraySum(List<int> ar)
    //    {
    //        int a = 0;
    //        for (int i = 0; i < ar.Count; i++)
    //        {
    //            a = a + ar[i];
    //        }
    //        return a;
    //    }

    //}

    //class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

    //        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

    //        int result = Result.simpleArraySum(ar);

    //        textWriter.WriteLine(result);

    //        textWriter.Flush();
    //        textWriter.Close();
    //    }
    //}

    //public static List<int> compareTriplets(List<int> a, List<int> b)
    //{
    //    int alice = 0;
    //    int bob = 0;
    //    List<int> result = new List<int>(); 
    //    for (int i = 0; i < a.Count; i++)
    //    {
    //        if (a[i] > b[i])
    //        {
    //            alice++;
    //        }
    //        else if (a[i] < b[i])
    //        {
    //            bob++;  
    //        }

    //    }
    //    result.Add(alice);
    //    result.Add(bob);
    //    return result;
    //}

    //public static long aVeryBigSum(List<long> ar)
    //{
    //    long result = 0;
    //    for (int i = 0; i < ar.Count; i++)
    //    {
    //        result = result + ar[i];
    //    }

    //    return result;
    //}

    //public static int diagonalDifference(List<List<int>> arr)
    //{
    //    int sumIzq = 0;
    //    int sumDer = 0;
    //    for (int i = 0; i < arr.Count; i++)
    //    {
    //        sumIzq += arr[i][i];

    //    }

    //    for (int k = 0; k < arr.Count; k++)
    //    {
    //        var j = arr.Count - 1 - k;
    //        sumDer += arr[k][j];
    //    }

    //    return Math.Abs(sumIzq - sumDer);
    //}

    //public static void plusMinus(List<int> arr)
    //{
    //    float countPosit = 0;
    //    float countNeg = 0;
    //    float countZero = 0;
    //    float resultPosit, resultNegit, resultZero;
    //    const string formato = "0.######";
    //    for (int i = 0; i < arr.Count; i++)
    //    {
    //        if (arr[i] > 0)
    //        {
    //            countPosit++;
    //        }
    //        else if (arr[i] < 0)
    //        {
    //            countNeg++;
    //        }
    //        else
    //        {
    //            countZero++;
    //        }
    //    }
    //    resultPosit = (countPosit / arr.Count);
    //    resultNegit = (countNeg / arr.Count);
    //    resultZero = (countZero / arr.Count);
    //    Console.WriteLine(resultPosit.ToString(formato));
    //    Console.WriteLine(resultNegit.ToString(formato));
    //    Console.WriteLine(resultZero.ToString(formato));
    //}

    //public static void staircase(int n)
    //{



    //    for (int i = 1; i <= n ; i++)
    //    {
    //        string espacio ="";
    //        espacio = new string(' ', n - i) + new string('#', i);

    //        Console.WriteLine(espacio);
    //    }


    //}

    //public static void miniMaxSum(List<int> arr)
    //{
    //    long minVal = 0;
    //    long maxVal = 0;
    //    for (int i = 0; i < arr.Count; i++)
    //    {
    //        if (arr[i] > arr.Min())
    //        {
    //            maxVal += arr[i];
    //        }
    //    }
    //    for (int j = 0; j < arr.Count; j++)
    //    {
    //        if (arr[j] < arr.Max())
    //        {
    //            minVal += arr[j];
    //        }
    //    }
    //    if (minVal == maxVal)
    //    {
    //        minVal = arr.Sum() - arr.Max();
    //        maxVal = arr.Sum() - arr.Min();
    //        Console.WriteLine($"{minVal} {maxVal}");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{minVal} {maxVal}");
    //    }

    //}

    //public static void miniMaxSum(List<int> arr)
    //{
    //    long minVal = 0;
    //    long maxVal = 0;

    //    minVal = arr.Sum() - arr.Max();
    //    maxVal = arr.Sum() - arr.Min();

    //    Console.WriteLine($"{minVal} {maxVal}");
    //}

    //public static int birthdayCakeCandles(List<long> candles)
    //{
    //    long tallest = 0;
    //    long count = 0;
    //    var maxVal = candles.Max();
    //    for (int i = 0; i < candles.Count; i++)
    //    {
    //        tallest = candles[i];
    //        if (tallest == maxVal)
    //        {
    //            count++;
    //        }
    //    }

    //    return (int)count;
    //}

    public static string timeConversion(string s)
    {
        TimeOnly timeOnly = new TimeOnly();
        s = timeOnly.ToString("HH:mm");
       return s;
    }
