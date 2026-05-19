using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithms
{
    public enum coin
    {
        OneDollar = 1,
        FifeDollars = 5,
        TenDollars = 10,
        TwentyDollar = 20,
        FiftyDollar = 50,
        HundredDollars = 100
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //get list of spacific coins 
            List<int> coins = new List<int> { 1, 5, 10, 20, 50, 100 };

            //we need to make the list is descinding 
            coins.Sort((a, b) => b.CompareTo(a));

            int amount = 93;

            //create the result list 
            List<int> result = new List<int>();

            //pass the result list and amount to function that return the result list with the coins that make the amount
            result = GetCoins(coins, amount);

            //print the result list
            Console.WriteLine("Coins used to make the amount:");
            foreach(int coin in result)
            {
                Console.WriteLine(coin);
            }
        }

        public static List<int> GetCoins(List<int> coins, int amount)
        {
            //coins list is for standard coins we need to create new resutl list to return
            List<int> result = new List<int>();

            //looping for all coins element 
            foreach(int coin in coins)
            {
                //keep adding current coin if is less than or equal the amount
                while(amount >= coin)
                {
                    amount -= coin;
                    result.Add(coin);
                }
            }

            return result;
        }
    }
}
