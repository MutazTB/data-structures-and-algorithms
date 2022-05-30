using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            int[] unsortedArray = { 8, 4, 23, 42, 16, 15 };
            Console.WriteLine("Unsorted Array:");
            Print(unsortedArray);

            QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
            Console.WriteLine("Sorted Array:");
            Print(unsortedArray);

        }
        
        // The recursive part of the algorithm        
        public static int[] QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Partition the Algorithm
                int position = Partition(array, left, right);

                // Sort the left side
                QuickSort(array, left, position - 1);

                // Sort the right side
                QuickSort(array, position + 1, right);
            }
            return array;

        }

        // Helper function takes in indices and array of values, iterates through array and swaps values if less than value at right index.        
        static int Partition(int[] arr, int left, int right)
        {
            // set a pivot
            int pivot = arr[right];

            // get the index of the lower value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }

            Swap(arr, right, low + 1);

            Console.WriteLine(string.Join(",", arr));


            return low + 1;
        }

        /// <summary>
        /// Swaps two values within an array
        /// </summary>
        /// <param name="arr">array of integer values</param>
        /// <param name="i">index for swap</param>
        /// <param name="low">other index for swap</param>
        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        static void Print(int[] arr)
        {
            Console.WriteLine();
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}