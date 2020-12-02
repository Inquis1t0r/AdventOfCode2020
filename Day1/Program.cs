using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    internal class Program
    {
        static void findTriplets(int[] arr, int n, int sum)
        {
            //TODO refactor and analyse 
            for (int i = 0; i < n - 1; i++)
            {
                HashSet<int> s = new HashSet<int>();
                for (int j = i + 1; j < n; j++)
                {
                    int x = sum - (arr[i] + arr[j]);
                    if (s.Contains(x))
                    {
                        Console.Write("{0} {1} {2}\n", x, arr[i], arr[j]);
                        Console.WriteLine(x * arr[i] * arr[j]);
                    } 
                    else
                        s.Add(arr[j]);
                }
            }
        }
        private static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("input.txt");
            var numberList = new List<string>(inputFile);
            var numberListAsInts = new List<int>();

            int searchedValue = 2020;

            foreach (var number in numberList)
            {
                //System.Console.WriteLine(number);
                numberListAsInts.Add(Int32.Parse(number));
            }

            #region Part1
            for (int i = 0; i < numberListAsInts.Count - 1; i++)
                for (int j = i + 1; j < numberListAsInts.Count; j++)
                {
                    var tempSumResult = numberListAsInts[i] + numberListAsInts[j];
                    if (tempSumResult == searchedValue)
                    {
                        Console.WriteLine("Result numbers = " + numberListAsInts[i] + " " + numberListAsInts[j]);
                        Console.WriteLine("Multiplication of result numbers = " + numberListAsInts[i] * numberListAsInts[j]);
                    }
                }
            #endregion

            #region Part2
            findTriplets(numberListAsInts.ToArray(), numberListAsInts.ToArray().Length, searchedValue);
            #endregion





        }




    }
}
    
