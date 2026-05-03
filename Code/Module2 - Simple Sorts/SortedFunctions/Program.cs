using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bubble Sort
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Original array: " + string.Join(", ", arr));

            BubbleSort(arr);

            Console.WriteLine("Sorted array: " + string.Join(", ", arr));

            #endregion
        }

        //Function for perform Bubble Sort
        static void BubbleSort(int[] arr)
        {
            for(int i =0;i< arr.Length-1; i++)
            {
                for(int j = 0; j< arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])//swap if the element found is greater than the next element
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
            }
        }
    }
}
