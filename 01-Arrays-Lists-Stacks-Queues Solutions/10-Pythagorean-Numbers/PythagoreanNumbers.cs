using System;
using System.Collections.Generic;

namespace _10_Pythagorean_Numbers
{
    internal class PythagoreanNumbers
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            numbers.Sort();

            bool print = false;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    for (int k = j; k < numbers.Count; k++)
                    {
                        if (numbers[i]*numbers[i] + numbers[j]*numbers[j] == numbers[k]*numbers[k])
                        {
                            print = true;
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[i], numbers[j], numbers[k]);
                        }
                    }
                }
            }
            if (!print)
            {
                Console.WriteLine("No");
            }
        }
    }
}
