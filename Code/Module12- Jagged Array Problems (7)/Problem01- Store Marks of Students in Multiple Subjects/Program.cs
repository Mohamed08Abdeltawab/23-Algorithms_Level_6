using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem1: Store Marks of Students in Multiple Subjects
            int[][] StudentMarks = new int[3][]
            {
                new int[] {90, 85, 88},
                new int[] {76, 80 },
                new int[] { 92, 93, 89, 85 }
            };

            for(int i =0;i< StudentMarks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: ");
                for(int j = 0;j< StudentMarks[i].Length; j++)
                {
                    Console.Write($"{StudentMarks[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
