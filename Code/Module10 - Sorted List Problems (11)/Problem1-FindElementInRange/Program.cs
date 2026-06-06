using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_FindElementInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(1);
            sortedSet.Add(2);
            sortedSet.Add(3);
            sortedSet.Add(4);
            sortedSet.Add(5);
            sortedSet.Add(6);

            

            List<int> result = GetViewBetweenFunc(sortedSet, 2, 4);
            Console.WriteLine("Elements between 2 and 4: " + string.Join(", ", result));

            //or just using methods of SortedList
            var range = sortedSet.GetViewBetween(2, 4);

            Console.WriteLine("Elements between 2 and 4 using GetViewBetween: " + string.Join(", ", range));
        }

        static List<int> GetViewBetweenFunc(SortedSet<int> sortedSet, int form, int to)
        {
            List<int> result = new List<int>();
            foreach(var item in sortedSet)
            {
                if (item >= form && item <= to)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
