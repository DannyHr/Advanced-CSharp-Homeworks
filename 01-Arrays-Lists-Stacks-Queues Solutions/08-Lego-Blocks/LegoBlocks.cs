using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lego_Blocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] firstArr = new int[n][];
            int[][] secondArr = new int[n][];

            char[] separator = {' '};

            for (int i = 0; i < n; i++)
            {
                firstArr[i] = Console.ReadLine()
                    .Split(separator,StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                secondArr[i] = Console.ReadLine()
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                secondArr[i] = secondArr[i].Reverse().ToArray();
            }


            int countElements = firstArr[0].Length + secondArr[0].Length;
            bool fit = true;

            for (int i = 0; i < n; i++)
            {
                if ((firstArr[i].Length+ secondArr[i].Length)!=countElements)
                {
                    fit = false;
                }
            }
            int count = 0;
            if (fit)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("[" + String.Join(", ", firstArr[i]) +", " +String.Join(", ", secondArr[i])+"]");
                }
            }
            else // !fit
            {
                for (int i = 0; i < n; i++)
                {
                    count += (firstArr[i].Length + secondArr[i].Length);
                }
                Console.WriteLine("The total number of cells is: {0}",count);
            }

            
            
        }
    }
}
