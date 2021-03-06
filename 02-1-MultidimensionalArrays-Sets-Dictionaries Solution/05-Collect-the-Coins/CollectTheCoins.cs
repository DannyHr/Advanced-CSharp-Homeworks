﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Collect_the_Coins
{
    class CollectTheCoins
    {
        private static void Main(string[] args)
        {
            string[] board = new string[4];
            for (int i = 0; i < 4; i++)
            {
                board[i] = Console.ReadLine();
            }
            char[] commands = Console.ReadLine().ToCharArray();

            int x = 0;
            int y = 0;
            int coins = 0;
            int hits = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case '>':
                        int temp = y + 1;
                        if (temp < board[x].Length)
                        {
                            y = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;

                    case '<':
                        temp = y - 1;
                        if (temp >= 0)
                        {
                            y = temp;
                            if (board[x][y] == '$')
                            {
                                y = temp;
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;

                    case '^':
                        temp = x - 1;
                        if (temp >= 0)
                        {
                            x = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;

                    case 'v':
                        temp = x + 1;
                        if (temp < 4)
                        {
                            x = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;
                }
            }

            Console.WriteLine("Coins collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", hits);
        }
    }
}
