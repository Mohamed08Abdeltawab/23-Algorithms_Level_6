using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Remove_All_Elements_Within_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SortedSet<int> cpyset = new SortedSet<int>(set);

            set.RemoveWhere(x => x >= 3 && x <= 7);

            cpyset.GetViewBetween(3, 7).Clear();

            Console.WriteLine(string.Join(", ", set));
            Console.WriteLine(string.Join(", ", cpyset));
        }
    }
}
