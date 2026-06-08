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
        }
        //function for problem 1
        static (string Name, int Age, double Grade) GetStudentInfo()
        {
            return ("Alice", 20, 85.5);
        }
    }
}
