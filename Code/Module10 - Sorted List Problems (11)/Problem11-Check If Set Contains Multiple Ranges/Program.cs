using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11_Check_If_Set_Contains_Multiple_Ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var ranges = new List<(int, int)>()
            {
                (1, 5),
                (6, 10)
            };

            bool containsAllRanges = true;
            foreach (var range in ranges)
            {
                //loop for all element in the range
                int n = range.Item2 - range.Item1 + 1;
                for (int i = 0; i < n; i++)
                {
                    if (!set.Contains(range.Item1 + i))
                    {
                        containsAllRanges = false;
                        break;
                    }
                }
                if (!containsAllRanges)
                {
                    break;
                }
            }

            if (containsAllRanges)
            {
                Console.WriteLine("The set contains all the ranges.");
            }
            else
            {
                Console.WriteLine("The set does not contain all the ranges.");
            }


            //another way using a function
            List<(int, int)> ranges2 = new List<(int, int)>()//using tuple to represent the range
            {
                (1, 5),
                (6, 10)
            };

            bool containsAllRanges2 = ContainsAllRanges(set, ranges2);

            if(containsAllRanges2)
            {
                Console.WriteLine("The set contains all the ranges.");
            }
            else
            {
                Console.WriteLine("The set does not contain all the ranges.");
            }
        }

        static bool ContainsAllRanges(SortedSet<int> set, List<(int, int)> ranges)
        {
            foreach (var (start,end) in ranges)
            {
                int n = end - start + 1;
                var range = set.GetViewBetween(start, end);//if return elements equal that range will be true
                if (range.Count != n)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
