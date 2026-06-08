using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Return Multiple Values from a Function
            Console.WriteLine("====== Problem 1 ======");
            var studentInfo = GetStudentInfo();
            Console.WriteLine($"Name: {studentInfo.Name}, Age: {studentInfo.Age}, Grade: {studentInfo.Grade}");

            #endregion


            #region Problem 2: Track Player Stats in a Game
            Console.WriteLine("\n====== Problem 2 ======");
            var playerStats = (Name: "John", Score: 1500, Level: 10);
            Console.WriteLine($"Player: {playerStats.Name}, Score: {playerStats.Score}, Level: {playerStats.Level}");

            #endregion
        }
        //function for problem 1
        static (string Name, int Age, double Grade) GetStudentInfo()
        {
            return ("Alice", 20, 85.5);
        }
    }
}
