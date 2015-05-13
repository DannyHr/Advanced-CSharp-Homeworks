using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sequence_in_Matrix
{
    class SequenceInMatrix
    {
        private static List<string> CheckSequence(string[,] matrix, int row, int col, int rowChange, int colChange, List<string> maxSequence)
        {
            int count = 1;
            while (row + rowChange >= 0 && 
                row + rowChange < matrix.GetLength(0) && 
                col + colChange >= 0 &&
                col + colChange < matrix.GetLength(1))
            {
                if (matrix[row,col] == matrix[row + rowChange,col + colChange])
                {
                    count++;
                }
                else
                {
                    break;
                }
                row += rowChange;
                col += colChange;
            }
            if (count > maxSequence.Count)
            {
                maxSequence.Clear();
                for (int i = 0; i < count; i++)
                {
                    maxSequence.Add(matrix[row,col].ToString());
                }
            }
            return maxSequence;
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter cols: ");
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] currentRow = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            List<string> maxSequence = new List<string>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    maxSequence = CheckSequence(matrix, row, col, 1, 0, maxSequence);
                    maxSequence = CheckSequence(matrix, row, col, 0, 1, maxSequence);
                    maxSequence = CheckSequence(matrix, row, col, 1, 1, maxSequence);
                    maxSequence = CheckSequence(matrix, row, col, 1, -1, maxSequence);
                }
            }
            Console.WriteLine(string.Join(", ", maxSequence));

        }
    }
}
