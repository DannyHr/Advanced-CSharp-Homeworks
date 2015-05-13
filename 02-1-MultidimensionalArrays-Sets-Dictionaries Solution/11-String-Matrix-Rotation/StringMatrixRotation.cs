using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_Matrix_Rotation
{
    internal class StringMatrixRotation
    {
        private static void Main(string[] args)
        {
            string[] rotation = (Console.ReadLine().Split(new char[] {' ', '(', ')'},
                StringSplitOptions.RemoveEmptyEntries));
            int degrees = (int.Parse(rotation[1]))%360;
            var words = new List<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                words.Add(input);
                input = Console.ReadLine();
            }
            int height = words.Count();
            int width = words.OrderBy(x => x.Length).Last().Length;
            string[] matrix = new string[height];
            for (int i = 0; i < height; i++)
            {
                matrix[i] = words[i].PadRight(width, ' ');
            }
            if (degrees == 0)
            {
                for (int row = 0; row < height; row++)
                {
                    Console.WriteLine(matrix[row]);
                }
            }
            if (degrees == 90)
            {
                for (int col = 0; col < width; col++)
                {
                    for (int row = height - 1; row >= 0; row--)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            if (degrees == 180)
            {
                for (int row = height - 1; row >= 0; row--)
                {
                    for (int col = width - 1; col >= 0; col--)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            if (degrees == 270)
            {
                for (int col = width - 1; col >= 0; col--)
                {
                    for (int row = 0; row < height; row++)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
