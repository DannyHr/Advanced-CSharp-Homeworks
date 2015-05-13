using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sorted_Subset_Sums
{
    internal class SortedSubsetSums
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            input = input.Distinct().ToArray();

            List<List<int>> subsets = new List<List<int>>();

            int count = 1 << input.Length; // 2^n
            bool subsetMatchSum = false;
            for (int i = 0; i < count; i++)
            {
                List<int> items = new List<int>();
                BitArray b = new BitArray(BitConverter.GetBytes(i));
                for (int j = 0; j < input.Length; j++)
                {
                    if (b[j])
                    {
                        items.Add(input[j]);
                    }
                }

                if (items.Any() && items.Sum() == n)
                {
                    subsetMatchSum = true;
                    subsets.Add(items); //add matching subsets to list
                }
            }

            //sorting list
            foreach (var list in subsets)
            {
                list.Sort(); //sorting numbers in each list in ascending order
            }

            subsets.Sort((a, b) =>
            {
                int result = a.Count.CompareTo(b.Count);
                return (result != 0) ? result : a.First().CompareTo(b.First());
            });
            //end of sorting

            //print
            for (int i = 0; i < subsets.Count; i++)
            {
                Console.WriteLine(string.Join(" + ", subsets[i]) + " = " + n);
            }

            if (!subsetMatchSum)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
