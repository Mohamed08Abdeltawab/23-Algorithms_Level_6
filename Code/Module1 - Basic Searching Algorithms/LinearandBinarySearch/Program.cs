using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearandBinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 37, 41, 45, 46, 49, 51, 55, 58, 70, 80, 82, 90, 95 }; // Sorted array
            int x = 22; // Element to be searched

            Console.WriteLine("Original Array:");
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine("\nResult of Linear Search:\n");
            #region Linear Search
            int result = LinearSearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + result);

            #endregion

            Console.WriteLine("\nResult of Binary Search:\n");
            #region Binary Search
            int resultBinary = BinarySearch(arr, x);
            if(resultBinary == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + resultBinary);
            #endregion
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

        //Function to perform Binary search
        static int BinarySearch(int[] arr, int target)
        {
            int end = arr.Length - 1;
            int start = 0;
            int count = 0;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                count++;
                if (arr[mid] == target)
                {
                    Console.WriteLine("Binary Search Iterations: " + count);
                    return mid;
                }
                else if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
