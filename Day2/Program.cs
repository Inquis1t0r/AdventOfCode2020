using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("input.txt");
            var passwordsWithRulesList = new List<string>(inputFile);
            int validPasswordsCound = 0;

            foreach (var line in passwordsWithRulesList)
            {
                //System.Console.WriteLine(line);

                if (true)
                {
                    validPasswordsCound++;
                }
            }

            Console.WriteLine(validPasswordsCound);

        }
    }
}
