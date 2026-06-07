using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Shopping_Cart_for_an_E_commerce_App
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> cart = new ObservableCollection<string>();
            cart.CollectionChanged += (sender, e) =>
            {
                if(e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Item {e.NewItems[0]} added to cart");
                if(e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Item {e.OldItems[0]} removed from cart");
                if(e.Action == NotifyCollectionChangedAction.Replace)
                    Console.WriteLine($"Item {e.OldItems[0]} replaced with {e.NewItems[0]} in cart");
                if (e.Action == NotifyCollectionChangedAction.Reset)
                    Console.WriteLine("Cart cleared");
            };

            cart.Add("Laptop");
            cart.Add("Smartphone");
            cart.Remove("Laptop");
            cart[0] = "Tablet";
        }
    }
}
