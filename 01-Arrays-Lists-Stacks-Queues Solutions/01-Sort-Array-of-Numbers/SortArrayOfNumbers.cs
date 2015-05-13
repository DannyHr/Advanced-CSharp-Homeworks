using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sort_Array_of_Numbers
{
    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(input);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
