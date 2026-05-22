using System;
using System.Collections.Generic;
using System.Linq;
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


            #endregion





















        }

    }
}
