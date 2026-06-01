using Microsoft.Win32;
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
            /*
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
            */
            #endregion


            #region Problem 6: Track Unique Visitors to a Website
            /*
                        //uising hashset to track unique visitors
                        Dictionary<string, HashSet<string>> WebsiteVisitors = new Dictionary<string, HashSet<string>>()
                        {
                            {"http://example.com", new HashSet<string> {"mohamed", "Ali", "Ali"} },// HashSet will automatically handle duplicates
                            {"http://example.com/page1", new HashSet<string> {"Bob", "Diana", "Bob" } },
                            {"http://example.com/page2", new HashSet<string> {"Alice", "Charlie", "Diana", "Diana"} }
                        };

                        Console.WriteLine("Unique Visitors:");
                        foreach(var page in WebsiteVisitors)
                        {
                            Console.WriteLine($"Page: {page.Key}, Visitors: {string.Join(", ", page.Value)}");
                        }
            */
            #endregion


            #region Problem 7: Check for Duplicate Entries in Real-Time
            /*
                        HashSet<char> UniqueEntries = new HashSet<char>();
                        char[] chars = { 'a', 'b', 'c', 'a', 'd', 'e', 'b' };

                        Console.WriteLine("Checking for duplicate entries:");
                        foreach(var ch in chars)
                        {
                            if(!UniqueEntries.Add(ch))
                                Console.WriteLine($"Duplicate entry found: {ch}");
                            else
                                Console.WriteLine($"Unique entry added: {ch}");
                        }

                        Console.WriteLine("Unique characters in the set: " + string.Join(", ", UniqueEntries));
            */
            #endregion


            #region Problem 8: Dynamic Skill Matching

            HashSet<string> RequiredSkills = new HashSet<string>() { "C#", "SQL", "JavaScript",};
            HashSet<string> CandidateSkills = new HashSet<string>() { "C#", "SQL", "Python", };

            Console.WriteLine("Required Skills: " + string.Join(", ", RequiredSkills));
            Console.WriteLine("Candidate Skills: " + string.Join(", ", CandidateSkills));

            // Check if candidate has all required skills
            HashSet<string> matchingSkills = new HashSet<string>(RequiredSkills);
            matchingSkills.IntersectWith(CandidateSkills);

            Console.WriteLine("Matching Skills: " + string.Join(", ", matchingSkills));

            #endregion


            #region Problem 9: Find the Frequency of Each Character

            string input = "hello";
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach(var ch in input)
            {
                if (charFrequency.ContainsKey(ch))
                    charFrequency[ch]++;
                else
                    charFrequency[ch] = 1;
            }

            Console.WriteLine("Character Frequencies:");
            foreach(var entry in charFrequency)
            {
                Console.WriteLine($"{entry.Key}, {entry.Value}");
            }


            #endregion




        }
    }
}
