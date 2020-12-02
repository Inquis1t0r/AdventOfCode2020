using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("input.txt");
            var passwordsWithRulesList = new List<string>(inputFile);
            int validPasswordsCount = 0;

            Console.WriteLine("Part 1:");
            foreach (var line in passwordsWithRulesList)
            {          

                string[] parts = line.Split(' ');
                //Console.WriteLine("[{0}]", string.Join(", ", parts));

                string rules = parts[0];

                String[] MinMaxValues = rules.Split('-');

                //Console.WriteLine("[{0}]", string.Join(", ", MinMaxValues));


                int minNumberOfLetters = Int32.Parse(MinMaxValues[0]);
                int maxNumberOfLetters = Int32.Parse(MinMaxValues[1]);


               // Console.WriteLine("Min num " + minNumberOfLetters + " max num "  + maxNumberOfLetters);

                char letterToCheck = char.Parse(parts[1].Substring(0,1));
                String checkedPassword = parts[2];
               // Console.WriteLine("Password to check: " + checkedPassword);
               // Console.WriteLine("Char to check: " + letterToCheck);

                //int frequencyOfChar = line.Where(x => (x.Equals(letterToCheck))).Count();
                int frequencyOfChar = line.Split(letterToCheck).Length - 2;  //This accutalu counts resulting subststrings
              //  Console.WriteLine("Occurences of char: " + frequencyOfChar);

                if (frequencyOfChar >= minNumberOfLetters && frequencyOfChar <= maxNumberOfLetters)
                {
                    validPasswordsCount++;
                  //  Console.WriteLine("Valid password");
                }
                else
                {
                   // Console.WriteLine("Invalid password");
                }

               // Console.WriteLine();

            }

            //Console.WriteLine("Number of valid password: " + validPasswordsCount);



            Console.WriteLine("Part 2:");
            foreach (var line in passwordsWithRulesList)
            {

                string[] parts = line.Split(' ');
                //Console.WriteLine("[{0}]", string.Join(", ", parts));

                string rules = parts[0];

                String[] MinMaxValues = rules.Split('-');

                //Console.WriteLine("[{0}]", string.Join(", ", MinMaxValues));


                int pos1 = Int32.Parse(MinMaxValues[0]);
                int pos2 = Int32.Parse(MinMaxValues[1]);


                Console.WriteLine("Pos1 " + pos1 + " Pos2 " + pos2);

                char letterToCheck = char.Parse(parts[1].Substring(0, 1));
                String checkedPassword = parts[2];
                Console.WriteLine("Password to check: " + checkedPassword);
                Console.WriteLine("Char to check: " + letterToCheck);

                int temp = 0;

                if(pos2 >= checkedPassword.Length)
                {
                    continue;
                }

                if (checkedPassword[pos1+1].Equals(letterToCheck))
                {
                    temp++;
                   // Console.WriteLine("Valid password");
                }
                if (checkedPassword[pos2+1].Equals(letterToCheck))
                {
                    temp++;
                    //Console.WriteLine("Valid password");
                }

                if(temp == 1)
                {
                    validPasswordsCount++;
                }

                Console.WriteLine("temp " + temp);
                Console.WriteLine();

            }

            Console.WriteLine("Number of valid password: " + validPasswordsCount);

        }
    }
}