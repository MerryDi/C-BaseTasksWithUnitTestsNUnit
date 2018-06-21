using System;
using System.Collections.Generic;
using System.Linq;


namespace BaseTasksLibrary
{
    public class SimpleArraysCalc
    {
        /// <summary>
        /// Get minimum element of array
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns>number</returns>
        public static int MinElementCalculation(int[] arr)
        {
            return arr.Min();
        }


        /// <summary>
        /// Get maximum element of array
        /// </summary>
        /// <param name="arr">array</param>
        public static int MaxElementCalculation(int[] arr)
        {
            return arr.Max();
        }


        /// <summary>
        /// Get index of minimum element of array
        /// </summary>
        /// <param name="arr">array</param>
        public static int IndexOfMinElementCalculation(int[] arr)
        {
            return arr.ToList().IndexOf(arr.Min());
        }


        /// <summary>
        /// Get index of maximum element of array
        /// </summary>
        /// <param name="arr">array</param>
        public static int IndexOfMaxElementCalculation(int[] arr)
        {
            return arr.ToList().IndexOf(arr.Max());
        }


        /// <summary>
        /// Get sum of elements with add indexes of array
        /// </summary>
        /// <param name="arr">array</param>
        public static int SumOfElementsWithOddIndexCalculation(int[] arr)
        {
            int i = 0;
            int sum = 0;

            while (i < arr.Length)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];
                }
                i++;
            }
            return sum;
        }

        /// <summary>
        /// Get number of elements with add indexes of array
        /// </summary>
        /// <param name="arr">array</param>
        public static int NumberOfElementsWithOddIndexCalculation(int[] arr)
        {
            int i = 0;
            int counter = 0;

            while (i < arr.Length)
            {
                if (i % 2 == 1)
                {
                    counter++;
                }
                i++;
            }
            return counter;
        }


        /// <summary>
        /// Reverse array
        /// </summary>
        /// <param name="arr">array</param>
        public static int[] ArrayReverseCalculation(int[] arr)
        {
            int[] b = new int[arr.Length];
            Array.Copy(arr, 0, b, 0, arr.Length);
            Array.Reverse(b);
            return b;
        }


        /// <summary>
        /// Reverse array like mirror reverse
        /// </summary>
        /// <param name="arr">array</param>
        public static int[] AnotherReverseCalculation(int[] arr)
        {
            int half;

            if (arr.Length % 2 == 0)
            {
                half = arr.Length / 2;
            }
            else
            {
                half = (arr.Length - 1) / 2;
            }

            int[] b = new int[arr.Length];
            Array.Copy(arr, 0, b, 0, arr.Length);

            Array.Copy(arr, arr.Length - half, b, 0, half);
            Array.Copy(arr, 0, b, arr.Length - half, half);

            return b;
        }


        /// <summary>
        /// Buble sort algorithm
        /// </summary>
        /// <param name="arr">array</param>
        public static int[] BubbleSortCalculation(int[] arr)
        {
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        var temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            return arr;
        }


        /// <summary>
        /// Select Search algorithm
        /// </summary>
        /// <param name="arr">array</param>
        public static int[] SelectSortCalculation(int[] arr)
        {

            for (int x = 0; x < arr.Length; x++)
            {
                int minIndex = x;
                for (int y = x; y < arr.Length; y++)
                {
                    if (arr[minIndex] > arr[y])
                    {
                        minIndex = y;
                    }
                }
                int temp = arr[x];
                arr[x] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }


        /// <summary>
        /// Insert Search algorithm
        /// </summary>
        /// <param name="arr">array</param>
        public static int[] InsertSortCalculation(int[] arr)
        {
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                var temp = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }




    }
}
