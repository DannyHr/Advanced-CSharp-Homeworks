using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Count_Symbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            SortedDictionary<char, int> charCounts = new SortedDictionary<char, int>();
            foreach (char symbol in inputText)
            {
                if (charCounts.ContainsKey(symbol))
                {
                    charCounts[symbol]++;
                }
                else
                {
                    charCounts.Add(symbol, 1);
                }
            }

            foreach (var pair in charCounts)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
