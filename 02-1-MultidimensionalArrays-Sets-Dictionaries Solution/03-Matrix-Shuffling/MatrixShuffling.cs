using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Matrix_Shuffling
{
    class MatrixShuffling
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter cols: ");
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            string commandInput = Console.ReadLine();
            while (commandInput != "END")
            {
                string[] command = commandInput.Split(' ');
                bool validInput = false;
                while (!validInput)
                {
                    if (command.Length == 5 && command[0] == "swap")
                    {
                        validInput =
                            int.TryParse(command[1], out x1) &&
                            int.TryParse(command[2], out y1) &&
                            int.TryParse(command[3], out x2) &&
                            int.TryParse(command[4], out y2);
                    }
                    if (x1 > rows || x2 > rows || y1 > cols || y2 > cols)
                    {
                        validInput = false;
                    }
                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input!");
                        break;
                    }

                }
                if (validInput)
                {
                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i,j] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                commandInput = Console.ReadLine();
            }
        }
    }
}
