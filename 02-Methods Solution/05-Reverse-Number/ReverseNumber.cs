using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Reverse_Number
{
    class ReverseNumber
    {
        static double GetReversedNumber(double number)
        {
            char[] strNum = number.ToString().ToCharArray();
            strNum = strNum.Reverse().ToArray();

            return double.Parse(new string(strNum));
        }

        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            double reversed = GetReversedNumber(number);

            Console.WriteLine(reversed);
        }
    }
}
