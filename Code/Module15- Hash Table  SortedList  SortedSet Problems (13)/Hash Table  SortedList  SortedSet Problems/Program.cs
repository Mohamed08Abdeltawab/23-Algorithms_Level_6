using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table__SortedList__SortedSet_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1: Copy Hashtable to Another Hashtable
            Console.WriteLine("====== Problem 1 ======");

            Hashtable ht1_1 = new Hashtable()
            {
                {"A", 1},
                {"B", 2},
                {"C", 3},
                {5, "D"},
                {6, "E"},
            };

            Hashtable ht1_2 = new Hashtable(ht1_1);

            foreach(DictionaryEntry item in ht1_2)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            #endregion


            #region Problem2: Sort and Remove Duplicates from a List
            Console.WriteLine("\n====== Problem 2 ======");

            List<int> list2 = new List<int>() { 5, 3, 8, 1, 2, 5, 3 };

            SortedSet<int> sortedSet2 = new SortedSet<int>(list2);

            foreach (int item in sortedSet2)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Problem3: Find Missing Numbers in a Range
            Console.WriteLine("\n====== Problem 3 ======");
            SortedSet<int> sortedSet3 = new SortedSet<int>() { 1, 2, 4, 6, 7 };
            for(int i = 1; i <= 7; i++)
            {
                if (!sortedSet3.Contains(i))
                {
                    Console.WriteLine("Missing number: " + i);
                }
            }

            #endregion


            #region Problem4: Track Unique Active Users by Login Time
            Console.WriteLine("\n====== Problem 4 ======");
            //we need ordering and uniqueness, so we can use SortedSet with a custom comparer
            SortedSet<DateTime> activeUsers4 = new SortedSet<DateTime>();
            activeUsers4.Add(new DateTime(2024, 11, 9, 10, 7, 0, 0));
            activeUsers4.Add(new DateTime(2024, 11, 9, 10, 0, 0, 0));
            activeUsers4.Add(new DateTime(2024, 11, 9, 10, 5, 0, 0));

            foreach (DateTime loginTime in activeUsers4)
            {
                Console.WriteLine("Active user login time: " + loginTime);
            }

            #endregion


            #region Problem5: Automatically Sort Event Timelines
            Console.WriteLine("\n====== Problem 5 ======");

            SortedSet<DateTime> eventTimeline5 = new SortedSet<DateTime>
            {
                new DateTime(2024, 12, 25),
                new DateTime(2024, 11, 30),
                new DateTime(2025, 1, 1)
            };

            Console.WriteLine("Upcoming events:");
            foreach (var eventTime in eventTimeline5)
            {
                Console.WriteLine(eventTime.ToShortDateString());
            }

            #endregion


            #region Problem6: Organize Movie Showtimes
            Console.WriteLine("\n====== Problem 6 ======");

            SortedSet<DateTime> showtimes6 = new SortedSet<DateTime>
            {
                new DateTime(2024, 11, 19, 14, 0, 0),
                new DateTime(2024, 11, 19, 12, 30, 0),
                new DateTime(2024, 11, 19, 16, 15, 0)
            };

            Console.WriteLine("Next showtime: " + showtimes6.Min.ToShortTimeString());
            Console.WriteLine("All showtimes:");
            foreach (var time in showtimes6)
            {
                Console.WriteLine(time.ToShortTimeString());
            }

            #endregion


            #region Problem7: Manage Meeting Times for a Calendar
            Console.WriteLine("\n====== Problem 7 ======");

            SortedSet<TimeSpan> meetingTimes = new SortedSet<TimeSpan>
            {
                new TimeSpan(14, 0, 0), // 2:00 PM
                new TimeSpan(9, 30, 0), // 9:30 AM
                new TimeSpan(11, 0, 0)  // 11:00 AM
            };

            Console.WriteLine("Today's meetings (sorted):");
            foreach (var time in meetingTimes)
            {
                Console.WriteLine(time);
            }

            #endregion

            #region Problem8: Track Unique Items in a Shopping Cart
            Console.WriteLine("\n====== Problem 8 ======");

            SortedSet<string> shoppingCart = new SortedSet<string>
            {
                "Apple",
                "Banana",
                "Orange",
                "Apple" // Duplicate, won't be added
            };

            Console.WriteLine("Shopping cart items (sorted):");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Problem9: Manage Unique Flight Times
            Console.WriteLine("\n====== Problem 9 ======");

            SortedSet<DateTime> flightTimes = new SortedSet<DateTime>
            {
                new DateTime(2024, 11, 19, 8, 0, 0),
                new DateTime(2024, 11, 19, 12, 45, 0),
                new DateTime(2024, 11, 19, 8, 0, 0) // Duplicate, won't be added
            };

            Console.WriteLine("Flight times (sorted):");
            foreach (var time in flightTimes)
            {
                Console.WriteLine(time.ToShortTimeString());
            }
            #endregion

            #region Problem10: Manage Tags in a Blogging Platform
            Console.WriteLine("\n====== Problem 10 ======");

            SortedSet<string> tags = new SortedSet<string>
            {
                "C#", "Programming", "Tutorial", "DotNet"
            };

            // Add more tags
            tags.Add("Coding");
            tags.Add("Programming"); // Duplicate, won't be added

            Console.WriteLine("All Tags:");
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
            #endregion

            #region Problem11: Autocomplete Suggestions in a Search Feature
            Console.WriteLine("\n====== Problem 11 ======");

            SortedSet<string> words = new SortedSet<string>
            {
                "apple", "application", "appreciate", "banana", "band", "bandwidth", "cat", "cater"
            };

            Console.Write("Enter a prefix: ");
            string prefix = Console.ReadLine();

            var suggestions = GetSuggestions(words, prefix);

            Console.WriteLine("Autocomplete suggestions:");
            foreach (var suggestion in suggestions)
            {
                Console.WriteLine(suggestion);
            }

            #endregion


        }

        //function for Problem 11: Get autocomplete suggestions based on prefix
        static IEnumerable<string> GetSuggestions(SortedSet<string> words, string prefix)
        {
            foreach(var word in words)
            {
                if(word.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    yield return word;
                }
            }
        }
    }
}
