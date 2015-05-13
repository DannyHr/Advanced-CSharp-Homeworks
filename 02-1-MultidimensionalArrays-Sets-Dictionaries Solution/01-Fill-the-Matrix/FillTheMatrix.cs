using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fill_the_Matrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            //fill matrix using pattern A
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i+(j*n)+1;
                }
            }

            //print Pattern A
            Console.WriteLine("Pattern A");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //fill matrix pattern B
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j%2 == 0)
                    {
                        matrix[i, j] = i + (j*n) + 1;
                    }
                    else
                    {
                        matrix[i, j] = (j + 1)*n - i;
                    }
                }
            }

            //print Pattern B
            Console.WriteLine("Pattern B");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }


        }
    }
}
