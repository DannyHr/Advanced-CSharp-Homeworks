using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Categorize_Numbers_Min_Max_Sum_Avg
{
    class CategorizeNumbersMinMaxAvg
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine();

            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();

            bool isInt = false;

            for(int i=0;i<input.Length;i++)
            {
                double current;
                current = double.Parse(input[i]);

                isInt = current == (int)current;

                if(isInt)
                {
                    ints.Add((int)current);
                }
                else
                {
                    doubles.Add(current);
                }
            }

            if(ints.Count==0)
            {
                ints.Add(0);
            }
            if(doubles.Count==0)
            {
                doubles.Add(0);
            }

            Console.WriteLine("[" + string.Join(", ", doubles) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}\n", doubles.Min(), doubles.Max(), doubles.Sum(), doubles.Average());

            Console.WriteLine("[" + string.Join(", ", ints) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}", ints.Min(), ints.Max(), ints.Sum(), ints.Average());

            
        }
    }
}
