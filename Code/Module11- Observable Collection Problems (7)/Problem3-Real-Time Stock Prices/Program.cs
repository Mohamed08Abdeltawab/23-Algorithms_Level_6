using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Real_Time_Stock_Prices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<(string,float)> stockPrices = new ObservableCollection<(string, float)>();
            stockPrices.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    var stock = ((string, float))e.NewItems[0];
                    Console.WriteLine($"Add Product: {stock.Item1}, Price: {stock.Item2}");
                }

                if(e.Action == NotifyCollectionChangedAction.Remove)
                {
                    var stock = ((string, float))e.OldItems[0];
                    Console.WriteLine($"Remove Product: {stock.Item1}, Price: {stock.Item2}");
                }

                if(e.Action == NotifyCollectionChangedAction.Replace)
                {
                    var oldStock = ((string, float))e.OldItems[0];
                    var newStock = ((string, float))e.NewItems[0];
                    Console.WriteLine($"Replace Product: {oldStock.Item1}, Old Price: {oldStock.Item2}, New Price: {newStock.Item2}");
                }
            };

            stockPrices.Add(("AAPL", 150.25f));
            stockPrices.Add(("GOOGL", 2800.50f));

            stockPrices[0] = ("AAPL", 155.00f);

            stockPrices.RemoveAt(1);

        }
    }
}
