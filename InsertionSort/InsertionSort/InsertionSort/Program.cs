using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {            
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            Console.WriteLine("Unsorted Array: ");
            Print(arr);

            Console.WriteLine();            
            Console.WriteLine("Sorted Array: ");
            Print(InsertionSort(arr));
        }

        public static int[] InsertionSort(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                int temp = myArray[i];
                int j = i - 1;

                while (j >= 0 && temp < myArray[j])
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }

                myArray[j + 1] = temp;
            }
            return myArray;
        }

        public static void Print(int[] arr)
        {
            Console.WriteLine();
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write(" ");
            Console.WriteLine();
        }
    }
}
