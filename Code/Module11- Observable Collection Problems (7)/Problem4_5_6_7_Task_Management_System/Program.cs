using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_5_6_7_Task_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem4 - Task Management System
            Console.WriteLine("======= Task Management System =======");

            ObservableCollection<string> tasks = new ObservableCollection<string>();
            tasks.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Task Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Task Removed: {e.OldItems[0]}");
            };

            tasks.Add("Complete report");
            tasks.Add("Attend meeting");
            tasks.Remove("Complete report");
            #endregion

            #region Problem5 - Live Chat Application
            Console.WriteLine("======= Live Chat Application =======");
            ObservableCollection<string> chatMessages = new ObservableCollection<string>();
            chatMessages.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Message: {e.NewItems[0]}");
            };

            chatMessages.Add("Hello!");
            chatMessages.Add("How are you?");

            #endregion


            #region Problem6 - Dynamic Weather Updates
            Console.WriteLine("======= Dynamic Weather Updates =======");
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();
            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Weather Update: {e.NewItems[0]}");
            };

            weatherUpdates.Add("New York: Sunny, 25°C");
            weatherUpdates.Add("London: Rainy, 15°C");

            #endregion


            #region Problem7 - Real-Time Notification System
            Console.WriteLine("======= Real-Time Notification System =======");
            ObservableCollection<string> notifications = new ObservableCollection<string>();
            notifications.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Notification: {e.NewItems[0]}");
            };

            notifications.Add("Your order is under processing.");
            notifications.Add("Your order has been shipped.");
            notifications.Add("Your order is Delivered.");

            #endregion
        }
    }
}
