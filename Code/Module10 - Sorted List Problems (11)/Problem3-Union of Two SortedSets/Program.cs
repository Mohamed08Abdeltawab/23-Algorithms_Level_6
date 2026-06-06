using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Union_of_Two_SortedSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> firstSet = new SortedSet<int>(new[] { 1, 2, 3});
            SortedSet<int> secondSet = new SortedSet<int>(new[] { 2, 3, 4, 5});

            SortedSet<int> unionSet = new SortedSet<int>(firstSet);

            unionSet.UnionWith(secondSet);

            Console.WriteLine(string.Join(" ", unionSet));
        }
    }
}
