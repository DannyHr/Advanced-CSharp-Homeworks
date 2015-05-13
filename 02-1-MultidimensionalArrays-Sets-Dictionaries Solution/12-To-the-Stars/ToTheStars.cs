using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_To_the_Stars
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            string[] star1 = Console.ReadLine().Split(' ');
            string[] star2 = Console.ReadLine().Split(' ');
            string[] star3 = Console.ReadLine().Split(' ');
            double[] normandy = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int moves = int.Parse(Console.ReadLine());

            for (int i = 0; i <= moves; i++)
            {
                if (isPassingStar(normandy[0], normandy[1], star1))
                {
                    Console.WriteLine(star1[0].ToLower());
                }
                else if (isPassingStar(normandy[0], normandy[1], star2))
                {
                    Console.WriteLine(star2[0].ToLower());
                }
                else if (isPassingStar(normandy[0], normandy[1], star3))
                {
                    Console.WriteLine(star3[0].ToLower());
                }
                else
                {
                    Console.WriteLine("space");
                }
                normandy[1] += 1.0;
            }
        }

        private static bool isPassingStar(double x, double y, string[] star)
        {
            if ((x >= double.Parse(star[1]) - 1.0) && (x <= double.Parse(star[1]) + 1.0) &&
                (y >= double.Parse(star[2]) - 1.0) && (y <= double.Parse(star[2]) + 1.0))
            {
                return true;
            }
            return false;
        }
    }
}
