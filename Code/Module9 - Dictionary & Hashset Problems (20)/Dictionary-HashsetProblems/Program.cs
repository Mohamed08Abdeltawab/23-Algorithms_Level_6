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
            /*
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
            */
            #endregion

            #region Problem 4: Count Word Frequencies in a Text
            /*
                        Dictionary<string, int> WordFreq = new Dictionary<string, int>();
                        string text = "Hello world! Hello everyone. Welcome to the world of programming.";

                        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach(var word in words)
                        {
                            string lowerWord = word.ToLower();
                            if (WordFreq.ContainsKey(lowerWord))
                                WordFreq[lowerWord]++;
                            else
                                WordFreq[lowerWord] = 1;
                        }

                        Console.WriteLine("Word Frequencies:");
                        foreach(var word in WordFreq)
                        {
                            Console.WriteLine($"Word: {word.Key}, Frequency: {word.Value}");
                        }
            */
            #endregion


            #region Problem 5: Phonebook Application

            Dictionary<string, string> Phonebook = new Dictionary<string, string>()
            {
                {"Alice", "123-456-7890" },
                {"Bob", "987-654-3210" },
                {"Charlie", "555-555-5555" },
                {"Diana", "111-222-3333" }
            };

            Console.WriteLine("Phonebook:");
            Console.WriteLine($"Alice phone: {Phonebook["Alice"]}");
            Console.WriteLine($"Bob phone: {Phonebook["Bob"]}");
            Console.WriteLine($"Charlie phone: {Phonebook["Charlie"]}");
            Console.WriteLine($"Diana phone: {Phonebook["Diana"]}");



            #endregion









        }
    }
}
