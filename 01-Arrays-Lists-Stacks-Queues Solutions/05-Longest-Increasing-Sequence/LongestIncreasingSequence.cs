using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Longest_Increasing_Sequence
{
    class LongestIncreasingSequence
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int index = 0;
            List<List<int>> sequences = new List<List<int>>();
            sequences.Add(new List<int>());

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0)
                {
                    if (input[i] > input[i - 1])
                    {
                        sequences[index].Add(input[i]);
                    }
                    else
                    {
                        sequences.Add(new List<int>());
                        index++;
                        sequences[index].Add(input[i]);
                    }
                }
                else
                {
                    sequences[index].Add(input[i]);
                }
            }
            
            //print sequences
            foreach (var list in sequences)
            {
                foreach (var entry in list)
                {
                    Console.Write(entry + " ");
                }
                Console.WriteLine();
            }
            //

            //finding longest sequence
            int longestSeqIndex = 0;

            for (int i = 1; i < sequences.Count; i++)
            {
                if (sequences[i].Count > sequences[longestSeqIndex].Count)
                {
                    longestSeqIndex = i;
                }
            }
            //

            Console.WriteLine("Longest: " + string.Join(" ",sequences[longestSeqIndex]));
        }
    }
}
