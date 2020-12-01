using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    internal class Program
    {
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

            for (int i = 0; i < numberListAsInts.Count - 1; i++)
                for (int j = i + 1; j < numberListAsInts.Count; j++)
                {
                    var tempSumResult = numberListAsInts[i] + numberListAsInts[j];
                    if (tempSumResult == searchedValue)
                    {
                        Console.WriteLine("Result numbers = " + numberListAsInts[i] +" "+ numberListAsInts[j]);
                        Console.WriteLine("Multiplication of result numbers = " + numberListAsInts[i] * numberListAsInts[j]);
                    }
                }
        }
    }
}