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
            /*
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
            */

            #endregion


            #region Problem 2: Store Book Information
            /*
                        Dictionary<int, (string Title, string Author)> BokkInfo = new Dictionary<int, (string Title, string Author)>()
                        {
                            { 1, ("The Great Gatsby", "F. Scott Fitzgerald") },
                            { 2, ("To Kill a Mockingbird", "Harper Lee") },
                            { 3, ("1984", "George Orwell") },
                            { 4, ("Pride and Prejudice", "Jane Austen") }
                        };

                        Console.WriteLine("Book Information:");
                        foreach(var book in BokkInfo)
                        {
                            Console.WriteLine($"Book ID: {book.Key}, Title: {book.Value.Title}, Author: {book.Value.Author}");
                        }
            */
            #endregion


            #region Problem 3: Translate Words Between Languages

            Dictionary<string, string> Translate = new Dictionary<string, string>()
            {
                {"Hello in Spanish", "Hola" },
                {"Goodbye in French", "Au revoir" },
                {"Thank you in German", "Danke" },
                {"Please in Italian", "Per favore" }
            };

            Console.WriteLine("Translations:");
            foreach(var translation in Translate)
            {
                Console.WriteLine($"Phrase: {translation.Key}, Translation: {Translate[translation.Key]}");
            }


            #endregion
        }
    }
}
