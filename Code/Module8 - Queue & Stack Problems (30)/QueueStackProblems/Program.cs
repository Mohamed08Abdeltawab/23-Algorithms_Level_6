using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
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
            /*
                        Queue<int> originalQueue = new Queue<int>(new[] { 5,1,3,2,4 });

                        List<int> tempList = new List<int>(originalQueue);
                        tempList.Sort();

                        Queue<int> sortedQueue = new Queue<int>(tempList);
                        Console.WriteLine("Original Queue: " + string.Join(", ", originalQueue));
                        Console.WriteLine("Sorted Queue: " + string.Join(", ", sortedQueue));
            */
            #endregion

            #region Problem 14: Interleave Queue Elements
            /*
                        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
                        Console.WriteLine("Original Queue: " + string.Join(", ", queue));

                        int halfSize = queue.Count / 2;

                        Stack<int> stack = new Stack<int>();
                        //stack 3,2,1
                        for(int i = 0; i < halfSize; i++)
                        {
                            stack.Push(queue.Dequeue());
                        }
                        //queue 4,5,6,3,2,1
                        while(stack.Count > 0)
                        {
                            queue.Enqueue(stack.Pop());
                        }

                        //queue 3,2,1,4,5,6
                        for (int i = 0; i < halfSize; i++)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }

                        //stack 3,2,1
                        //queue 4,5,6
                        for (int i = 0; i < halfSize; i++)
                        {
                            stack.Push(queue.Dequeue());
                        }

                        //queue 5,6,1,4
                        //queue 6,1,4,2,5
                        //queue 1,4,2,5,3,6
                        while (stack.Count > 0)
                        {
                            queue.Enqueue(stack.Pop());
                            queue.Enqueue(queue.Dequeue());
                        }

                        Console.WriteLine("Interleaved Queue: " + string.Join(", ", queue));
            */

            #endregion


            #region Problem 15: Rotate a Queue
            /*
                        Queue<int> rotateQueue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
                        int k = 2;

                        Console.WriteLine("Original Queue: " + string.Join(", ", rotateQueue));

                        for(int i = 0; i< k; i++)
                        {
                            rotateQueue.Enqueue(rotateQueue.Dequeue());
                        }
                        Console.WriteLine("Rotated Queue: " + string.Join(", ", rotateQueue));
            */
            #endregion



            #region Problem 16:  Merge Two Sorted Queues
            /*
                        Queue<int> queue1 = new Queue<int>(new[] { 1, 3, 5 });
                        Queue<int> queue2 = new Queue<int>(new[] { 2, 4, 6 });

                        Console.WriteLine("Queue 1: " + string.Join(", ", queue1));
                        Console.WriteLine("Queue 2: " + string.Join(", ", queue2));

                        Queue<int> mergedQueue = new Queue<int>();

                        for(; queue1.Count > 0 && queue2.Count > 0;)
                        {
                            if(queue1.Peek() < queue2.Peek())
                            {
                                mergedQueue.Enqueue(queue1.Dequeue());
                            }
                            else
                            {
                                mergedQueue.Enqueue(queue2.Dequeue());
                            }
                        }

                        // If there are remaining elements in queue1
                        while(queue1.Count > 0)
                        {
                            mergedQueue.Enqueue(queue1.Dequeue());
                        }

                        // If there are remaining elements in queue2
                        while(queue2.Count > 0)
                        {
                            mergedQueue.Enqueue(queue2.Dequeue());
                        }

                        Console.WriteLine("Merged Queue: " + string.Join(", ", mergedQueue));
            */
            #endregion


            #region Problem 17: First Non-Repeating Character in a Stream
            /*
                        Dictionary<char, int> charCount = new Dictionary<char, int>();
                        Queue<char> charQueue = new Queue<char>();

                        string input = "aabc";

                        Console.WriteLine("Input Stream: " + input);

                        foreach(char c in input)
                        {
                            //check if character is already in dictionary
                            if (!charCount.ContainsKey(c))
                                charCount[c] = 0;

                            charCount[c]++;
                            charQueue.Enqueue(c);

                            //dequeue characters that have count greater than 1
                            while(charQueue.Count > 0 && charCount[charQueue.Peek()] > 1)
                            {
                                charQueue.Dequeue();
                            }

                            //will print the first non-repeating character or "-" if there is none
                            Console.WriteLine(charQueue.Count > 0 ? charQueue.Peek().ToString() : "-");
                        }
            */

            #endregion

            #region Problem 18: Queue using two stacks 
            /*
                        Stack<int> stack1 = new Stack<int>();
                        Stack<int> stack2 = new Stack<int>();

                        //store income 
                        stack1.Push(1);
                        stack2.Push(2);

                        while(stack1.Count > 0)
                            stack2.Push(stack1.Pop());

                        Console.WriteLine("Queue from stack1 and stack2: " + string.Join(", ", stack2));
            */

            #endregion


            #region Problem 19: Rearrange Queue Alternately
            /*
                        //spet1: splite queue to two halves
                        //step2: merge the havles alternately
                        Queue<int> queue = new Queue<int>(new[] {1,2,3,4,5,6});
                        Console.WriteLine("Queue after Alternately: " + string.Join(", ", queue));

                        List<int> list = new List<int>(queue);
                        int n = list.Count;
                        Queue<int> result = new Queue<int>();

                        for(int i = 0; i < n / 2; i++)
                        {
                            result.Enqueue(list[i]);
                            result.Enqueue(list[n - i -1]);
                        }

                        if(n%2 != 0)//if n was odd number so we not taken that in for loop so we aded in the last of result
                            result.Enqueue(list[n/2]);


                        Console.WriteLine("Queue after Alternately: " + string.Join(", ", result));
            */

            #endregion


            #region Problem 20: Implement a Priority Queue
            /*
                        PriorityQueue pq = new PriorityQueue();
                        pq.Enqueue(10, 4);
                        pq.Enqueue(20,2);
                        pq.Enqueue(30,3);

                        Console.WriteLine(pq.Dequeue());
            */

            #endregion

            #region Problem 21: Rearrange Even and Odd Elements
            /*
                        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
                        Console.WriteLine("Original Queue: " + string.Join(", ", queue));
                        Queue<int> evenQueue = new Queue<int>();
                        Queue<int> oddQueue = new Queue<int>();

                        while (queue.Count > 0)
                        {
                            int current = queue.Dequeue();
                            if (current % 2 == 0)
                                evenQueue.Enqueue(current);
                            else
                                oddQueue.Enqueue(current);
                        }

                        while (evenQueue.Count > 0)
                            queue.Enqueue(evenQueue.Dequeue());


                        while (oddQueue.Count > 0)
                            queue.Enqueue(oddQueue.Dequeue());

                        Console.WriteLine("Rearranged Queue (Even followed by Odd): " + string.Join(", ", queue));
            */

            #endregion


            #region Problem 22: Clone a Queue Without Using Extra Space
            /*
                        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4});
                        Console.WriteLine("Original Queue: " + string.Join(", ", queue));
                        Queue<int> clonedQueue = new Queue<int>();

                        clonedQueue = CloneQueue(queue);

                        Console.WriteLine("Cloned Queue: " + string.Join(", ", clonedQueue));
            */
            #endregion

            #region Problem 23: Find Middle Element in a Queue
            /*
                        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
                        List<int> tempList = new List<int>(queue);

                        int middleIndex = tempList.Count / 2;
                        int middleElement = tempList[middleIndex];
                        Console.WriteLine("Queue: " + string.Join(", ", queue));
                        Console.WriteLine("Middle Element: " + middleElement);
            */
            #endregion


            #region Problem 24: Reverse a String

            Stack<char> charStack = new Stack<char>(new[] { 'h', 'e', 'l', 'l', 'o' });

            string reversedString = "";
            while(charStack.Count > 0)
            {
                reversedString += charStack.Pop();
            }
            Console.WriteLine("Reversed String: " + reversedString);

            #endregion



        }
        /*
                //problem 22: Clone a Queue Without Using Extra Space
                static Queue<int> CloneQueue(Queue<int> originalQueue)
                {
                    if (originalQueue.Count == 0)
                        return new Queue<int>();

                   int current = originalQueue.Dequeue();
                   Queue<int> clonedQueue = CloneQueue(originalQueue);
                   originalQueue.Enqueue(current);
                   clonedQueue.Enqueue(current);
                   return clonedQueue;

                }
        */
        /*
                //problem20
                public class PriorityQueue
                {
                    SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();

                    public void Enqueue(int value, int priority)
                    {
                        if (!queue.ContainsKey(priority))
                        {
                            queue[priority] = new Queue<int>();
                        }
                        queue[priority].Enqueue(value);
                    }


                    public int? Dequeue()
                    {
                        if(queue.Count == 0) return null;
                        //get highest priority 
                        int highestPriority = queue.Keys.Min();
                        int value = queue[highestPriority].Dequeue();
                        //after dequeue the element if was the last in highest priority in queue
                        //will remove the queue because is become empty if not well keep it
                        if (queue[highestPriority].Count == 0)
                        {
                            queue.Remove(highestPriority);
                        }

                        return value;
                    }
                }
        */
    }
}
