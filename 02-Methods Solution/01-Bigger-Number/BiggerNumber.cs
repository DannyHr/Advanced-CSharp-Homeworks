using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bigger_Number
{
    class BiggerNumber
    {
        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;
        }

        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }
    }
}
