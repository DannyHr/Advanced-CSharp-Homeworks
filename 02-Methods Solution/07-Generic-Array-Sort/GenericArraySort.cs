using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Generic_Array_Sort
{
    class GenericArraySort
    {
        private static T[] SortArray<T>(T[] array) where T : System.IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                int max = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[max].CompareTo(array[j]) > 0)
                    {
                        max = j;
                    }
                }
                //swapping elements
                T temp = array[max];
                array[max] = array[i];
                array[i] = temp;
            }
            return array;
        }

        static void Main(string[] args)
        {
            double[] doubles = {11.23,5.3457,93.235,2.4,0.2341};
            int[] numbers = {1, 3, 4, 5, 1, 0, 5};
            string[] strings = {"zaz", "cba", "baa", "azis"};
            DateTime[] dates =
            {
                new DateTime(2002, 3, 1),
                new DateTime(2015, 5, 6),
                new DateTime(2014, 1, 1)
            };

            SortArray(doubles);
            SortArray(numbers);
            SortArray(strings);
            SortArray(dates);

            Console.WriteLine(String.Join("; ",doubles));
            Console.WriteLine(String.Join(", ",numbers));
            Console.WriteLine(String.Join(", ", strings));
            Console.WriteLine(String.Join(", ", dates));
        }
    }
}
