using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                    Console.WriteLine("{0} against {1}", numberListAsInts[i], numberListAsInts[j]);
                }


        }
    }
}