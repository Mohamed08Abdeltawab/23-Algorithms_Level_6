using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Find_Smallest_and_Largest_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>(new[] { 1, 2, 6, 4, 5, 3});

            Console.WriteLine("Smallest element: " + set.Min);
            Console.WriteLine("Largest element: " + set.Max);
        }
    }
}
