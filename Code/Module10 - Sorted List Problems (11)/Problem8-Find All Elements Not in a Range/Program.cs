using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_Find_All_Elements_Not_in_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            var result = GetElementNotInRange(set, 3, 7).ToList();
            Console.WriteLine(string.Join(", ", result));
        }

        static IEnumerable<int> GetElementNotInRange(SortedSet<int> set, int start, int end)
        {
            var range = set.GetViewBetween(start, end);
            SortedSet<int> resultSet = new SortedSet<int>(set);
            resultSet.ExceptWith(range);
            return resultSet;
        }
    }
}
