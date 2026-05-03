using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int x = 22; // Element to be searched

            Console.WriteLine("Original Array:");
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            int result = LinearSearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + result);
        }


        // Function to perform linear search
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
