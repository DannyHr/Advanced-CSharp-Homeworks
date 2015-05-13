using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Activity_Tracker
{
    internal class ActivityTracker
    {
        private static void Main(string[] args)
        {
            SortedDictionary<int, SortedDictionary<string, int>> activityData =
                new SortedDictionary<int, SortedDictionary<string, int>>();
            SortedDictionary<string, int> userData = new SortedDictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                DateTime date = DateTime.Parse(inputData[0]);
                int month = date.Month;
                string userName = inputData[1];
                int distance = int.Parse(inputData[2]);

                if (!activityData.ContainsKey(month))
                {
                    userData = new SortedDictionary<string, int>();
                    userData.Add(userName, distance);
                    activityData.Add(month, userData);
                }
                else
                {
                    if (!userData.ContainsKey(userName))
                    {
                        userData.Add(userName, distance);
                    }
                    else
                    {
                        int currentDist = userData[userName];
                        int newDistance = currentDist + distance;
                        userData[userName] = newDistance;

                    }
                    activityData[month] = userData;
                }
            }
            foreach (var key in activityData.Keys)
            {
                Console.Write(key + ":");
                SortedDictionary<string, int> data = activityData[key];
                foreach (var entry in data)
                {
                    Console.Write("{0} ({1}),", entry.Key, entry.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
