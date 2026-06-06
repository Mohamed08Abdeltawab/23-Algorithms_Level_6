using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10_Real_Time_Leaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> leaderboard = new SortedList<string, int>()
            {
                {"Alice", 100},
                {"Bob", 150},
                {"Charlie", 120}
             };


            Console.WriteLine("Initial Leaderboard:");
            foreach (var entry in leaderboard)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
