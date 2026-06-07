using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("using Bubble Sort");
            #region Bubble Sort
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Original array: " + string.Join(", ", arr));

            BubbleSort(arr);

            Console.WriteLine("Sorted array: " + string.Join(", ", arr));

            #endregion

            Console.WriteLine("using Selection Sort");
            #region Selection Sort
            int[] arr2 = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original array: " + string.Join(", ", arr2));

            SelectionSortASC(arr2);

            Console.WriteLine("Sorted array: " + string.Join(", ", arr2));


            int[] arr3 = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Original array: " + string.Join(", ", arr3));

            SelectionSortDESC(arr3);

            Console.WriteLine("Sorted array: " + string.Join(", ", arr3));
            #endregion


            Console.WriteLine("using Insertion Sort");
            #region Insertion Sort
            int[]arr4 = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Original array: " + string.Join(", ", arr4));
            InsertionSort(arr4);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr4));


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

        //Function for perform Selection Sort
        static void SelectionSortASC(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for(int j= i + 1; j<n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //swaping
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }

        static void SelectionSortDESC(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                //swaping
                (arr[i], arr[maxIndex]) = (arr[maxIndex], arr[i]);
            }
        }

        // 5, 2, 9, 1, 5, 6 
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1; i< n; i++)
            {
                int key = arr[i];//i = 2 arr[i] = 9
                int j = i - 1;//arr[j] = 22
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
