using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace QueueStackProblems // 1. browser back button
{
    internal class Program
    {
        static void BrowserBackButton(Stack<string> BrowserHistory)
        {
            BrowserHistory.Pop();
            if (BrowserHistory.Count <= 0)
            {
                Console.WriteLine("No pages in history");
                return;
            }
            Console.WriteLine("\ngo page back");
            Console.WriteLine("\ncurrent page: " + BrowserHistory.Peek());
        }

        static void BrowserForwardButton(Stack<string> BrowserHistory, string newPage)
        {
            BrowserHistory.Push(newPage);
            Console.WriteLine("\nOpening page: " + BrowserHistory.Peek());
        }

        static string DecimalToBinary(int decimalNumber)
        {
            Stack<int> binaryStack = new Stack<int>();
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binaryStack.Push(remainder);
                decimalNumber /= 2;
            }
            return string.Join("", binaryStack);
        }

        static void Main(string[] args)
        {
            #region Problem 1: browser back button
            /*
                        Stack<string> BrowserHistory = new Stack<string>();
                        BrowserForwardButton(BrowserHistory, "www.google.com");
                        BrowserForwardButton(BrowserHistory, "www.facebook.com");
                        BrowserBackButton(BrowserHistory);
                        BrowserForwardButton(BrowserHistory, "www.twitter.com");
                        BrowserBackButton(BrowserHistory);
            */
            #endregion

            #region Problem 2: convert decimal to binary using stack
            /*
            Console.WriteLine(DecimalToBinary(10));

            */
            #endregion

            #region problem 4: queue for printer job
            /*
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");
            queue.Enqueue("f");

            while (queue.Count > 0)
            {
                Console.WriteLine("processing..." + queue.Dequeue());
                if (queue.Count > 0)
                {
                    Console.WriteLine("Next job: " + queue.Peek());
                }
            }
            */
            #endregion


            #region problem 5: Traffic Signal System Simulation
            /*
                        Queue<string> trafficQueue = new Queue<string>();
                        trafficQueue.Enqueue("Car 1");
                        trafficQueue.Enqueue("Truck 1");
                        trafficQueue.Enqueue("Bike 1");
                        trafficQueue.Enqueue("Bus 1");

                        while(trafficQueue.Count > 0)
                        {
                            Console.WriteLine(trafficQueue.Dequeue() + " has passed");
                            if(trafficQueue.Count > 0)
                            {
                                Console.WriteLine("Vehicles waiting...");
                                Console.WriteLine(string.Join(", ", trafficQueue));
                            }
                            else
                            {
                                Console.WriteLine("No Vehicles waiting");
                            }

                        }
            */
            #endregion


            #region Problem 6: Ticketing System Simulation - Solution
            /*
                        Queue<int> ticketQueue = new Queue<int>();

                        for(int i = 101; i <= 105; i++)
                        {
                            ticketQueue.Enqueue(i);
                        }

                        while(ticketQueue.Count > 0)
                        {
                            Console.WriteLine("Processing Ticket: " + ticketQueue.Dequeue());
                            if(ticketQueue.Count > 0)
                            {
                                Console.WriteLine("Remaining Tickets: " + string.Join(", ", ticketQueue));
                            }
                            else
                            {
                                Console.WriteLine("No more tickets in the queue");
                            }
                        }
            */
            #endregion


            #region Problem 7: Implementing Simple Backtracking
            /*
                        Console.WriteLine("Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.\n");

                        Stack<string> backtrackingStack = new Stack<string>();
                        backtrackingStack.Push("Start");
                        backtrackingStack.Push("Go to Gaz Station");
                        backtrackingStack.Push("Go to Super Market");
                        backtrackingStack.Push("Go To Work");
                        backtrackingStack.Push("Go to Cafe");
                        backtrackingStack.Push("Go Home");


                        while(backtrackingStack.Count > 0)
                        {
                            Console.WriteLine("Back to: " + backtrackingStack.Pop());
                        }
            */
            #endregion

            #region Problem 8: Implementing a Simple Task Scheduler
            /*
                        Queue<string> tasks = new Queue<string>();
                        tasks.Enqueue("Task 1");
                        tasks.Enqueue("Task 2");
                        tasks.Enqueue("Task 3");
                        tasks.Enqueue("Task 4");

                        while(tasks.Count > 0)
                        {
                            Console.WriteLine("Processing: " + tasks.Dequeue());
                        }
            */
            #endregion


            #region Problem 9: Customer Service Simulation
            /*
                        Queue<string> ArrivedTime = new Queue<string>();
                        ArrivedTime.Enqueue("customer1");
                        ArrivedTime.Enqueue("customer2");
                        ArrivedTime.Enqueue("customer3");

                        while(ArrivedTime.Count > 0)
                        {
                            Console.WriteLine("Serving: " + ArrivedTime.Dequeue());
                        }
            */
            #endregion


            #region Problem 10: Web Page Request Handling - Solution
            /*
                        Queue<string> requests = new Queue<string>();
                        requests.Enqueue("Request1");
                        requests.Enqueue("Request2");
                        requests.Enqueue("Request3");


                        Console.WriteLine("Processing web requests:\n");
                        while (requests.Count > 0)
                        {
                            string currentRequest = requests.Dequeue();
                            Console.WriteLine($"Processed: {currentRequest}");
                        }
            */

            #endregion

            #region Problem 11: Reverse a Queue
            /*
                        Queue<int> originalQueue = new Queue<int>();
                        originalQueue.Enqueue(1);
                        originalQueue.Enqueue(2);
                        originalQueue.Enqueue(3);
                        originalQueue.Enqueue(4);
                        originalQueue.Enqueue(5);

                        Console.WriteLine("Original Queue: " + string.Join(", ", originalQueue));


                        Stack<int> tempStack = new Stack<int>();

                        while(originalQueue.Count > 0)
                        {
                            tempStack.Push(originalQueue.Dequeue());
                        }

                        while(tempStack.Count > 0)
                        {
                            originalQueue.Enqueue(tempStack.Pop());
                        }

                        Console.WriteLine("Reversed Queue: " + string.Join(", ", originalQueue));
            */
            #endregion

            #region Problem 11: Palindrome Queue
            /*
                        Queue<int> originalQueue = new Queue<int>(new [] { 1, 2, 3, 2, 1 });

                        Console.WriteLine("Original Queue: " + string.Join(", ", originalQueue));

                        Stack<int> tempStack = new Stack<int>(originalQueue);

                        bool isPalindrome = true;

                        foreach(var item in originalQueue)
                        {
                            if (tempStack.Pop() != item)
                            {
                                isPalindrome = false;
                                break;
                            }
                        }

                        if (isPalindrome)
                            Console.WriteLine("The queue is a palindrome.");
                        else
                            Console.WriteLine("The queue is not a palindrome.");
            */
            #endregion


            #region Problem 12: Generate Binary Numbers
            /*
                        int n = 5;
                        Queue<string> queue = new Queue<string>();
                        queue.Enqueue("1");


                        for (int i = 0; i < n; i++)
                        {
                            string binary = queue.Dequeue();
                            Console.WriteLine(binary);
                            queue.Enqueue(binary + "0");
                            queue.Enqueue(binary + "1");
                        }
            */
            #endregion


            #region Problem 13: Sort a Queue

            Queue<int> originalQueue = new Queue<int>(new[] { 5,1,3,2,4 });
            
            List<int> tempList = new List<int>(originalQueue);
            tempList.Sort();

            Queue<int> sortedQueue = new Queue<int>(tempList);
            Console.WriteLine("Original Queue: " + string.Join(", ", originalQueue));
            Console.WriteLine("Sorted Queue: " + string.Join(", ", sortedQueue));
            #endregion













        }
    }
}
