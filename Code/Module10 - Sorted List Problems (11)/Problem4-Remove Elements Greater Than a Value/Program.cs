using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_Remove_Elements_Greater_Than_a_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int value = 3;

            for (int i = 0;i< set.Count;i++)
            {
                if(set.ElementAt(i) > value)
                {
                    set.Remove(set.ElementAt(i));
                    i--; // Adjust the index after removal
                }
            }
            Console.WriteLine(string.Join(", ", set));

            // or using getviewbetween
            set = set.GetViewBetween(set.Min, value);
            Console.WriteLine(string.Join(", ", set));
        }
    }
}
