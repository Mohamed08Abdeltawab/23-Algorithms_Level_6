using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_Find_Count_Less_Than_or_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5, 6 };
            int value = 4;
            int count = sortedSet.GetViewBetween(sortedSet.Min, value).Count;
            Console.WriteLine($"Count of elements less than or equal to {value}: {count}");

            int count2 = sortedSet.Where(x => x <= value).Count();
            Console.WriteLine($"Count of elements less than or equal to {value} using LINQ: {count2}");
            
            int count3 = sortedSet.Count(x => x <= value);
            Console.WriteLine($"Count of elements less than or equal to {value} using Count method: {count3}");

            int count4 = sortedSet.TakeWhile(x => x <= value).Count();
            Console.WriteLine($"Count of elements less than or equal to {value} using TakeWhile: {count4}");

            
        }
    }
}
