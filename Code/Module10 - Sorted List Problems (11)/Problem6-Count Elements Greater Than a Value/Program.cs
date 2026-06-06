using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_Count_Elements_Greater_Than_a_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>(new[] { 1, 2, 3, 4, 5 });
            int value = 3;

            var greaterElementsCount = set.Count(x => x > value);
            Console.WriteLine($"Elements greater than {value}: {greaterElementsCount}");

            var greaterElements = set.Where(x => x > value).Count();
            Console.WriteLine($"Elements greater than {value} (using LINQ): {greaterElements}");

            var greaterElements2 = set.GetViewBetween(value + 1, int.MaxValue).Count();
            Console.WriteLine($"Elements greater than {value} (using GetViewBetween): {greaterElements2}");

            var greaterElements3 = set.SkipWhile(x => x <= value).Count();
            Console.WriteLine($"Elements greater than {value} (using SkipWhile): {greaterElements3}");

            var greaterElements4 = set.Take(set.Count - value).Count();
            Console.WriteLine($"Elements greater than {value} (using Take): {greaterElements4}");
        }
    }
}
