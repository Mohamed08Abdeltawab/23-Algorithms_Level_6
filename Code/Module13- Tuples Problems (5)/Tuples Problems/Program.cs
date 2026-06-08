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


            #region Problem 3: Store and Compare Employee Details
            Console.WriteLine("\n====== Problem 3 ======");
            var emp1 = (Name: "Alice", Age: 30, Salary: 50000);
            var emp2 = (Name: "Bob", Age: 25, Salary: 60000);

            Console.WriteLine($"{emp1.Name} has a {(emp1.Salary > emp2.Salary ? "higher" : "lower")} salary than {emp2.Name}");

            #endregion


            #region Problem 4: Return Success or Failure from a Function
            Console.WriteLine("\n====== Problem 4 ======");
            var result = IsPass(75);
            Console.WriteLine($"Success: {result.Success}, Score: {result.Score}");
            #endregion
        }
        //function for problem 1
        static (string Name, int Age, double Grade) GetStudentInfo()
        {
            return ("Alice", 20, 85.5);
        }

        //function for problem 4
        static (bool Success, double Score) IsPass(double score)
        {
            if(score >= 50)
            {
                return (true, score);
            }
            else
            {
                return (false, score);
            }
        }
    }
}
