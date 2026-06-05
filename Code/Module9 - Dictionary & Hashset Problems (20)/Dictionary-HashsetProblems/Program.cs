using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            /*
                        HashSet<string> RequiredSkills = new HashSet<string>() { "C#", "SQL", "JavaScript",};
                        HashSet<string> CandidateSkills = new HashSet<string>() { "C#", "SQL", "Python", };

                        Console.WriteLine("Required Skills: " + string.Join(", ", RequiredSkills));
                        Console.WriteLine("Candidate Skills: " + string.Join(", ", CandidateSkills));

                        // Check if candidate has all required skills
                        HashSet<string> matchingSkills = new HashSet<string>(RequiredSkills);
                        matchingSkills.IntersectWith(CandidateSkills);

                        Console.WriteLine("Matching Skills: " + string.Join(", ", matchingSkills));
            */
            #endregion


            #region Problem 9: Find the Frequency of Each Character
            /*
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
            */
            #endregion


            #region Problem 10: Find Longest Consecutive Sequence
            /*
                        int[] arr = new int[] { 100, 4, 200, 1, 3, 2 };
                        HashSet<int> set = new HashSet<int>(arr);
                        int longestStreak = 0;
                        //step1 : tract all numbers in the set
                        foreach (int num in set)
                        {
                            if (!set.Contains(num - 1))
                            {
                                int currentNum = num;
                                int currentStreak = 1;


                                while (set.Contains(currentNum + 1))
                                {
                                    currentNum++;
                                    currentStreak++;
                                }


                                longestStreak = Math.Max(longestStreak, currentStreak);
                            }
                        }

                        Console.WriteLine("Longest Consecutive Sequence Length: " + longestStreak);
            */
            #endregion

            #region Problem 11: Find Majority Element
            /*
                        Dictionary<int, int> count = new Dictionary<int, int>();
                        int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };

                        foreach(int num in nums)
                        {
                            if(!count.ContainsKey(num))
                                count[num] = 0;

                            count[num]++;

                            if (count[num] > nums.Length / 2)
                            {
                                Console.WriteLine("Majority Element: " + num);
                                break;
                            }


                        }
            */
            #endregion

            #region Problem 12: Find Duplicate Elements
            /*
                        int[] arr = new int[] {1, 2, 3, 4,1, 2, 3, 4, 5};
                        Dictionary<int, int> Dublicates = new Dictionary<int, int>();

                        //HashSet<int> dubSet = new HashSet<int>();
                        foreach(int num in arr)
                        {
                            if (Dublicates.ContainsKey(num))
                            {
                                Dublicates[num]++;
                                //dubSet.Add(num);
                            }
                            else
                                Dublicates[num] = 1;
                        }

                        //get dublicates with linq
                        var dublicatesvars = Dublicates.Where(x => x.Value > 1).Select(x => x.Key).ToList();

                        Console.WriteLine("Dublicates Values: ");
                        //Console.WriteLine(string.Join(", ", dubSet));

                        Console.WriteLine(string.Join(", ", dublicatesvars));
            */
            #endregion


            #region Problem 13: Find All Unique Elements
            /*
                        int[] arr = new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 5 };
                        Dictionary<int, int> Dublicates = new Dictionary<int, int>();

                        foreach (int num in arr)
                        {
                            if (Dublicates.ContainsKey(num))
                            {
                                Dublicates[num]++;
                            }
                            else
                                Dublicates[num] = 1;
                        }

                        //get unique elements with linq
                        var uniqueElements = Dublicates.Where(x => x.Value == 1).Select(x => x.Key).ToList();

                        Console.WriteLine("Unique Values: ");

                        Console.WriteLine(string.Join(", ", uniqueElements));
            */
            #endregion


            #region Problem 14: Find Words That Can Be Typed Using One Row of Keyboard

            /*
                        string[] words = new string[] { "Hello", "Alaska", "Dad", "Peace" };

                        HashSet<char> row1 = new HashSet<char>("qwertyuiop");
                        HashSet<char> row2 = new HashSet<char>("asdfghjkl");
                        HashSet<char> row3 = new HashSet<char>("zxcvbnm");

                        foreach(string word in words)
                        {
                            //condition
                            if(word.ToLower().All(ch => row1.Contains(ch)) ||
                               word.ToLower().All(ch => row2.Contains(ch)) ||
                               word.ToLower().All(ch => row3.Contains(ch)))
                            {
                                Console.WriteLine(word);
                            }
                        }
            *//*

            string[] words = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> charRow = new Dictionary<char, int>();


            //map each character to its corresponding row
            for(int i = 0; i< rows.Length; i++)
            {
                foreach (char ch in rows[i])//every character in spacific row by index
                {
                    charRow[ch] = i;
                }
            }

            List<string> result = new List<string>();
            //map on words and check if all characters belong to the same row
            foreach (string word in words)
            {
                int rowIndex = charRow[char.ToLower(word[0])]; //get the row index of the first character
                bool isValid = true;

                foreach(char ch in word)
                {
                    if (charRow[char.ToLower(ch)] != rowIndex)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine("Words that can be typed using one row of keyboard: " + string.Join(", ", result));
*/
            #endregion


            #region Problem 15: Find Missing Number in an Array
            /*
                        int[] arr = new int[] { 0,1,3 };
                        int n = arr.Length; // n is the length of the array, which is 3 in this case

                        HashSet<int> set = new HashSet<int>(arr);
                        for (int i = 0; i <= n; i++)
                        {
                            if (!set.Contains(i))
                            {
                                Console.WriteLine("Missing Number: " + i);
                                break;
                            }
                        }
            */
            #endregion

            #region Problem 16: find common charcters in string 
            /*
                        string[] words = new string[] { "bella", "label", "roller" };

                        int[] minFreq = new int[26];

                        for (int i = 0; i < minFreq.Length; i++)
                        {
                            minFreq[i] = int.MaxValue;
                        }

                        foreach (string word in words)
                        {
                            int[] charFreq = new int[26];
                            foreach (char c in word)
                            {
                                charFreq[c - 'a']++;//adding value of current character by 1
                            }


                            for (int i = 0; i < 26; i++)
                            {
                                minFreq[i] = Math.Min(minFreq[i], charFreq[i]);//get the minimum value for each character for each word there a character changed
                            }
                        }

                        List<string> result = new List<string>();
                        for (int i = 0; i < 26; i++)
                        {
                            for (int j = 0; j < minFreq[i]; j++)
                            {
                                result.Add(((char)(i + 'a')).ToString());
                            }
                        }

                        Console.WriteLine("Common characters: " + string.Join(", ", result));
            */



            // Another way using dictionary

            string[] words = new string[] { "bella", "label", "roller" };
            Dictionary<char, int> common = new Dictionary<char, int>();//for first word 

            foreach(char c in words[0])
            {
                if (common.ContainsKey(c))
                    common[c]++;
                else
                    common[c] = 1;
            }

            //for each word after the first one we will update the common dictionary
            for(int i = 1; i< words.Length; i++)
            {
                Dictionary<char, int> current = new Dictionary<char, int>();//for current word after the first one

                foreach(char c in words[i])
                {
                    if (current.ContainsKey(c))
                        current[c]++;
                    else
                        current[c] = 1;
                }


                foreach(char key in common.Keys.ToList())
                {
                    if (current.ContainsKey(key))
                    {
                        common[key] = Math.Min(common[key], current[key]);//update the value of common dictionary to be the minimum value between the current word and the previous common value
                    }
                    else
                    {
                        common[key] = 0;//if the current word does not contain the key we will set its value to 0 in common dictionary
                    }
                }
            }

            List<string> result = new List<string>();

            foreach(var entry in common)
            {
                for(int i = 0; i < entry.Value; i++)
                {
                    result.Add(entry.Key.ToString());
                }
            }

            Console.WriteLine("Common characters: " + string.Join(", ", result));


            #endregion

        }
    }
}
