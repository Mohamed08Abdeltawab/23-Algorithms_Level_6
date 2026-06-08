using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Store Marks of Students in Multiple Subjects
            int[][] jag1 = new int[][]
            {
                new int[] { 85, 90, 78 }, // Marks for Student 1
                new int[] { 92, 88 },     // Marks for Student 2
                new int[] { 75, 80, 82, 89 } // Marks for Student 3
            };

            Console.WriteLine("Marks of Students in Multiple Subjects:");
            for (int i = 0; i < jag1.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {string.Join(", ", jag1[i])}");
            }

            #endregion
        }
    }
}
