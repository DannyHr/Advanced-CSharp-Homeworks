using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Maximal_Sum
{
    class MaximalSum
    {
        private static int[,] SubmatrixWithMaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue, indexI = -1, indexJ = -1;
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    int currentSum = matrix[i - 1, j - 1] +
                                     matrix[i - 1, j] +
                                     matrix[i - 1, j + 1] +
                                     matrix[i, j - 1] +
                                     matrix[i, j] +
                                     matrix[i, j + 1] +
                                     matrix[i + 1, j - 1] +
                                     matrix[i + 1, j] +
                                     matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        indexI = i;
                        indexJ = j;
                    }
                }
            }

            int[,] maxSumMatrix =
            {
                {
                    matrix[indexI - 1, indexJ - 1],
                    matrix[indexI - 1, indexJ],
                    matrix[indexI - 1, indexJ + 1]
                },
                {
                    matrix[indexI, indexJ - 1],
                    matrix[indexI, indexJ],
                    matrix[indexI, indexJ + 1]
                },
                {
                    matrix[indexI + 1, indexJ - 1],
                    matrix[indexI + 1, indexJ],
                    matrix[indexI + 1, indexJ + 1]
                }
            };

            return maxSumMatrix;
        }

        static void Main()
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0],size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                int[] currentRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            int[,] matrixWithMaxSum = SubmatrixWithMaxSum(matrix);
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += matrixWithMaxSum[i, j];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sum = {0}",sum);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrixWithMaxSum[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            

        }
    }
}
