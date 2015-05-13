using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sort_Array_of_Numbers_Selection_Sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max;

            for (int i = 0; i < input.Length; i++)
            {
                max = i;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[max] > input[j])
                    {
                        max = j;
                    }
                }

                //swapping elements
                int temp = input[max];
                input[max] = input[i];
                input[i] = temp;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
