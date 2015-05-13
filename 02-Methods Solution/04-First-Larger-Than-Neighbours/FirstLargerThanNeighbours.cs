using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_First_Larger_Than_Neighbours
{
    internal class FirstLargerThanNeighbours
    {
        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        return i;
                    }
                }
                else if (i == (array.Length - 1))
                {
                    if (array[i] > array[i - 1])
                    {
                        return i;
                    }
                }
                else
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter sequence of numbers, separated by a space: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(numbers));
        }
    }
}
