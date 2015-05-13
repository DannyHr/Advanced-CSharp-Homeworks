using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Night_Life
{
    internal class NightLife
    {
        private static void Main(string[] args)
        {
            var clubs = new Dictionary<string, Dictionary<string, List<string>>>();
            string[] input = Console.ReadLine().Split(';');

            do
            {
                string city = input[0];
                string venue = input[1];
                string performer = input[2];
                if (clubs.ContainsKey(city))
                {
                    if (clubs[city].ContainsKey(venue))
                    {
                        if (!PerformersCheck(performer, clubs[city][venue]))
                        {
                            clubs[city][venue].Add(performer);
                            clubs[city][venue].Sort();
                        }
                    }
                    else
                    {
                        clubs[city].Add(venue, new List<string>());
                        clubs[city][venue].Add(performer);
                    }
                }
                else
                {
                    clubs.Add(city, new Dictionary<string, List<string>>());
                    clubs[city].Add(venue, new List<string>());
                    clubs[city][venue].Add(performer);
                }

                input = Console.ReadLine().Split(';');

            } while (input[0] != "END");

            foreach (string city in clubs.Keys)
            {
                Console.WriteLine(city);
                var venueList = clubs[city].Keys.ToList();
                venueList.Sort();
                foreach (string venue in venueList)
                {
                    Console.WriteLine("->{0}: {1}", venue, string.Join(", ", clubs[city][venue]));
                }
            }

        }

        private static bool PerformersCheck(string s, List<string> l)
        {
            bool check = false;
            for (int i = 0; i < l.Count; i++)
            {
                if (s == l[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
