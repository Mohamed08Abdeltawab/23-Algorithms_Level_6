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
            Console.WriteLine("====== Problem 2 ======");
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


            #region Problem 2: Store Sales Data by Quarter
            Console.WriteLine("====== Problem 2 ======");
            int[][] jag2 = new int[][]
            {
            new int[] { 10000, 12000, 11000 },
            new int[] { 15000, 16000 },
            new int[] { 9000, 9500, 9800, 10200 }
            };

            for (int i = 0; i < jag2.Length; i++)
            {
                Console.Write($"Region {i + 1}: ");
                Console.WriteLine(string.Join(", ", jag2[i]));
            }

            #endregion


            #region Problem 3: Dynamic Seating Arrangement in a Classroom

            Console.WriteLine("====== Problem 3 ======");
            int[][] jag3 = new int[][]
            {
                new int[] { 1, 2, 3 }, // Row 1
                new int[] { 4, 5 },    // Row 2
                new int[] { 6, 7, 8, 9 } // Row 3
            };

            for(int i = 0; i< jag3.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                foreach(var seat in jag3[i])
                {
                    Console.Write($"{seat} ");
                }
                Console.WriteLine();
            }

            #endregion


            #region Problem 4: Daily Sales for Different Products - Solution

            Console.WriteLine("====== Problem 4 ======");
            int[][] jag4 = new int[][]
            {
                new int[] { 100, 200, 150 }, // Product 1
                new int[] { 300, 400 },      // Product 2
                new int[] { 500, 600, 550, 700 } // Product 3
        };

            for (int i = 0; i < jag4.Length; i++)
            {
                Console.Write($"Product {i + 1}: ");
                foreach (var sale in jag4[i])
                {
                    Console.Write($"{sale} ");
                }
                Console.WriteLine();
            }

            #endregion


            #region Problem 5: Flight Seat Reservations

            Console.WriteLine("====== Problem 5 ======");
            bool[][] jag5 = new bool[][]
            {
                new bool[] { true, false, true }, // Product 1
                new bool[] { false, true },      // Product 2
        };

            for (int i = 0; i < jag5.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                foreach (var seat in jag5[i])
                {
                    Console.Write(seat ? "Available " : "Occupied ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
