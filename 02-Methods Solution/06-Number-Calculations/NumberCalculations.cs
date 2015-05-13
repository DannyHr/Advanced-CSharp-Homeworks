using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Number_Calculations
{
    internal class NumberCalculations
    {
        private static double FindMinimum(double[] array)
        {
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        private static decimal FindMinimum(decimal[] array)
        {
            decimal min = Decimal.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        private static double FindMaximum(double[] array)
        {
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        private static decimal FindMaximum(decimal[] array)
        {
            decimal max = Decimal.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        private static double FindAverage(double[] array)
        {
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;
            return avg;
        }

        private static decimal FindAverage(decimal[] array)
        {
            decimal avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;
            return avg;
        }

        private static double FindSum(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static decimal FindSum(decimal[] array)
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static double FindProduct(double[] array)
        {
            double prod = 1;
            for (int i = 0; i < array.Length; i++)
            {
                prod *= array[i];
            }
            return prod;
        }

        private static decimal FindProduct(decimal[] array)
        {
            decimal prod = 1;
            for (int i = 0; i < array.Length; i++)
            {
                prod *= array[i];
            }
            return prod;
        }
        
        private static void Main(string[] args)
        {
            double[] doubleArray =
            {
                1.2365,
                2.2476,
                45.21096,
                5.12454,
                24.3412,
                221.534243
            };

            decimal[] decimalArray =
            {
                12.152342342m,
                23.42134523m,
                2.92384237423m,
                923.3242348569m,
                23124.213192412323m,
                8124723.982148217412m
            };

            Console.WriteLine("Double array:\nMin: {0}\nMax: {1}\nAvg: {2}\nSum: {3}\nProduct: {4}",
                FindMinimum(doubleArray),
                FindMaximum(doubleArray),
                FindAverage(doubleArray),
                FindSum(doubleArray),
                FindProduct(doubleArray)
                );

            Console.WriteLine();
            Console.WriteLine("Decimal array:\nMin: {0}\nMax: {1}\nAvg: {2}\nSum: {3}\nProduct: {4}",
                FindMinimum(decimalArray),
                FindMaximum(decimalArray),
                FindAverage(decimalArray),
                FindSum(decimalArray),
                FindProduct(decimalArray)
                );
        }
    }
}
