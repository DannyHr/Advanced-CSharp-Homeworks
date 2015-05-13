using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Subset_Sums
{
    class SubsetSums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            input = input.Distinct().ToArray();

            int count = 1 << input.Length; // 2^n
            bool subsetMatchSum = false;
            for (int i = 0; i < count; i++)
            {
                List<int> items = new List<int>();
                BitArray b = new BitArray(BitConverter.GetBytes(i));
                for(int j = 0; j < input.Length; j++)
                {
                    if (b[j])
                    {
                        items.Add(input[j]);
                    }
                }

                if (items.Any() && items.Sum() == n)
                {
                    subsetMatchSum = true;
                    Console.Write(String.Join(" + ", items));
                    Console.WriteLine(" = {0}",n);
                }
            }
            if (!subsetMatchSum)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
