using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Plus_Remove
{
    internal class PlusRemove
    {
        private static void Main()
        {
            List<char[]> inputMatrix = new List<char[]>();
            List<char[]> resultMatrix = new List<char[]>();

            string text = Console.ReadLine();

            while (text != "END")
            {
                inputMatrix.Add(text.ToLower().ToCharArray());
                resultMatrix.Add(text.ToCharArray());
                text = Console.ReadLine();
            }

            for (int i = 0; i < inputMatrix.Count; i++)
            {
                for (int j = 0; j < inputMatrix[i].Length; j++)
                {
                    FindPlus(inputMatrix, resultMatrix, i, j);
                }
            }

            PrintMatrix(resultMatrix);
        }

        private static void FindPlus(List<char[]> lines, List<char[]> result, int row, int col)
        {
            char symbol = lines[row][col];

            if (row - 1 >= 0 &&
                row + 1 < lines.Count &&
                col - 1 >= 0 &&
                col + 1 < lines[row].Length
                && lines[row - 1].Length > col
                && lines[row + 1].Length > col
                && lines[row - 1][col] == symbol
                && lines[row + 1][col] == symbol
                && lines[row][col - 1] == symbol
                && lines[row][col + 1] == symbol)
            {
                result[row][col] = '\0';
                result[row - 1][col] = '\0';
                result[row + 1][col] = '\0';
                result[row][col - 1] = '\0';
                result[row][col + 1] = '\0';
            }
        }

        private static void PrintMatrix(List<char[]> resultMatrix)
        {
            foreach (var line in resultMatrix)
            {
                foreach (var symbol in line)
                {
                    if (symbol != '\0')
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
