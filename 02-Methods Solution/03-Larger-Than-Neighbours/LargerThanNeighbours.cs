using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Larger_Than_Neighbours
{
    class LargerThanNeighbours
    {
        private static bool IsLargerThanNeighbours(int[] array, int element)
        {
            if (element < 0 || element > (array.Length - 1))
            {
                return false;
            }
            else if (element == 0)
            {
                if (array[element] > array[element + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (element == (array.Length - 1) && array[array.Length - 1] > array[array.Length - 2])
            {
                return true;
            }
            else
            {
                if (array[element] > array[element - 1] && array[element] > array[element + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter sequence of numbers, separated by a space: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers,i));
            }
        }
    }
}
