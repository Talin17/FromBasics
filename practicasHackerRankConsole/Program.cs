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

    public static int diagonalDifference(List<List<int>> arr)
    {
        int diference = 0;
        List<int> diagIzq = new List<int>();
        List<int> diagDer = new List<int>();
        List<int> diagIzqSum = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                diagIzqSum = arr[i];
            }
        }
       

    }
