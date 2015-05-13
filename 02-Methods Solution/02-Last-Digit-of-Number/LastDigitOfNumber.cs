using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Last_Digit_of_Number
{
    class LastDigitOfNumber
    {
        static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number%10;
            string lastDigitAsWord = "";
            switch (lastDigit)
            {
                case 0: lastDigitAsWord = "zero"; break;
                case 1: lastDigitAsWord = "one"; break;
                case 2: lastDigitAsWord = "two"; break;
                case 3: lastDigitAsWord = "three"; break;
                case 4: lastDigitAsWord = "four"; break;
                case 5: lastDigitAsWord = "five"; break;
                case 6: lastDigitAsWord = "six"; break;
                case 7: lastDigitAsWord = "seven"; break;
                case 8: lastDigitAsWord = "eight"; break;
                case 9: lastDigitAsWord = "nine"; break;
            }
            return lastDigitAsWord;
        }

        private static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Last digit is: " + GetLastDigitAsWord(number));
        }
    }
}
