using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _09_Stuck_Numbers
{
    internal class StuckNumbers
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<string> numbersConc = new List<string>();

            //concatenating all pairs of numbers and add them in list
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    string number = "" + input[i].ToString() + "|" + input[j].ToString();
                    numbersConc.Add(number);
                    number = "" + input[j].ToString() + "|" + input[i].ToString();
                    numbersConc.Add(number);
                }
            }
            //

            bool printed = false, distinct = true;

            for (int i = 0; i < numbersConc.Count; i++)
            {
                for (int j = 0; j < numbersConc.Count; j++)
                {
                    //check if a,b,c,d are distinct
                    List<int> currentNums = numbersConc[i].Split('|').Select(int.Parse).ToList();
                    currentNums.AddRange(numbersConc[j].Split('|').Select(int.Parse).ToList());

                    for (int k = 0; k < currentNums.Count; k++)
                    {
                        for (int l = k + 1; l < currentNums.Count; l++)
                        {
                            if (currentNums[k] == currentNums[l])
                            {
                                distinct = false;
                            }
                        }
                    }
                    //

                    if (i == j)
                    {
                        continue;
                    }
                    if (String.Compare(
                        numbersConc[i],
                        numbersConc[j],
                        CultureInfo.InvariantCulture,
                        CompareOptions.IgnoreSymbols) == 0 && distinct) //compare every two strings ignoring "|"
                    {
                        printed = true;
                        Console.WriteLine(numbersConc[i] + "==" + numbersConc[j]);
                    }
                    distinct = true;
                }
            }

            if (!printed)
            {
                Console.WriteLine("No");
            }
        }
    }
}
