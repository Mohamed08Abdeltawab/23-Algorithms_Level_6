using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1 // 1. browser back button
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> BrowserHistory = new Stack<string>();

            BrowserForwardButton(BrowserHistory, "www.google.com");
            BrowserForwardButton(BrowserHistory, "www.facebook.com");
            BrowserBackButton(BrowserHistory);
            BrowserForwardButton(BrowserHistory, "www.twitter.com");
            BrowserBackButton(BrowserHistory);

        }
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
    }
}
