using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_HashsetProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Store and Retrieve Student Grades

            Dictionary<string, double> studentGrades = new Dictionary<string, double>()
            {
                {"Alice", 85.5},
                {"Bob", 92.0},
                {"Charlie", 78.0},
                {"Diana", 88.5 }
            };

            Console.WriteLine("Student Grades:");
            foreach(var student in studentGrades)
            {
                Console.WriteLine("Student: " + student.Key + ", Grade: " + student.Value);
            }


            #endregion
        }
    }
}
