using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table__SortedList__SortedSet_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1: Copy Hashtable to Another Hashtable
            Console.WriteLine("====== Problem 1 ======");

            Hashtable ht1_1 = new Hashtable()
            {
                {"A", 1},
                {"B", 2},
                {"C", 3},
                {5, "D"},
                {6, "E"},
            };

            Hashtable ht1_2 = new Hashtable(ht1_1);

            foreach(DictionaryEntry item in ht1_2)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            #endregion


            #region Problem2: Sort and Remove Duplicates from a List
            Console.WriteLine("\n====== Problem 2 ======");

            List<int> list2 = new List<int>() { 5, 3, 8, 1, 2, 5, 3 };

            SortedSet<int> sortedList2 = new SortedSet<int>(list2);

            foreach (int item in sortedList2)
            {
                Console.WriteLine(item);
            }


            #endregion
        }
    }
}
