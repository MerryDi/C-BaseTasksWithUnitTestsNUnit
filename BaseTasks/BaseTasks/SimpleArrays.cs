using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTasks
{
    class SimpleArrays 
    {
        static void Main(string[] args)
        {

            int[] arr = BaseTasksLibrary.GetDataFromConsole.GetArray();
            BaseTasksLibrary.GetDataFromConsole.WriteArray(arr);

            MinElement(arr);
            MaxElement(arr);
            IndexOfMinElement(arr);
            IndexOfMaxElement(arr);
            SumAndNumberOfElementsWithOddIndex(arr);
            ArrayReverse(arr);
            AnotherReverse(arr);
            BubbleSort(arr);
            SelectSort(arr);
            InsertSort(arr);

            Console.ReadLine();

        }


        /// <summary>
        /// Calculate Min Element of array
        /// </summary>
        /// <param name="arr"></param>
        public static void MinElement(int[] arr)
        {
            Console.WriteLine("\n Minimum element is " + BaseTasksLibrary.SimpleArraysCalc.MinElementCalculation(arr));
        }


        /// <summary>
        /// Calculate Max element of array
        /// </summary>
        /// <param name="arr"></param>
        public static void MaxElement(int[] arr)
        {
            Console.WriteLine("\n Maximum element is " + BaseTasksLibrary.SimpleArraysCalc.MaxElementCalculation(arr));

        }


        /// <summary>
        /// Calculate Max Index of array
        /// </summary>
        /// <param name="arr"></param>
        public static void IndexOfMinElement(int[] arr)
        {
            Console.WriteLine("\n Index of Minimum element is " + BaseTasksLibrary.SimpleArraysCalc.IndexOfMinElementCalculation(arr));
        }


        /// <summary>
        /// Calculate Max Index of array
        /// </summary>
        /// <param name="arr"></param>
        public static void IndexOfMaxElement(int[] arr)
        {
            Console.WriteLine("\nIndex of Maximum number is " + BaseTasksLibrary.SimpleArraysCalc.IndexOfMaxElementCalculation(arr));
        }


        /// <summary>
        /// Calculate the Sum And Number Of Elements Wit hOdd Indexes
        /// </summary>
        /// <param name="arr"></param>
        public static void SumAndNumberOfElementsWithOddIndex(int[] arr)
        {
            Console.WriteLine("\nSum Of Elements With Odd Indexes is " + BaseTasksLibrary.SimpleArraysCalc.SumOfElementsWithOddIndexCalculation(arr));
            Console.WriteLine("\nNumber Of Elements With Odd Indexes is " + BaseTasksLibrary.SimpleArraysCalc.NumberOfElementsWithOddIndexCalculation(arr));

        }


        /// <summary>
        /// Sort array in mirror way by element
        /// </summary>
        /// <param name="arr"></param>
        public static void ArrayReverse(int[] arr)
        {
            Console.WriteLine("\nReversed array:");
            BaseTasksLibrary.GetDataFromConsole.WriteArray(BaseTasksLibrary.SimpleArraysCalc.ArrayReverseCalculation(arr));
        }


        /// <summary>
        /// Sort array in mirror way by half
        /// </summary>
        /// <param name="arr"></param>
        public static void AnotherReverse(int[] arr)
        {
            Console.WriteLine("\nAnother reverse:");
            BaseTasksLibrary.GetDataFromConsole.WriteArray(BaseTasksLibrary.SimpleArraysCalc.AnotherReverseCalculation(arr));
        }


        /// <summary>
        /// Sort array with Bubble Sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            Console.WriteLine("\nBubbleSort array in ascending order:");
            BaseTasksLibrary.GetDataFromConsole.WriteArray(BaseTasksLibrary.SimpleArraysCalc.BubbleSortCalculation(arr));
        }


        /// <summary>
        /// Sort array with Select Sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectSort(int[] arr)
        {
            Console.WriteLine("\nSelectSort array in ascending order:");
            BaseTasksLibrary.GetDataFromConsole.WriteArray(BaseTasksLibrary.SimpleArraysCalc.SelectSortCalculation(arr));
        }


        /// <summary>
        /// Sort array with Insert Sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertSort(int[] arr)
        {
            Console.WriteLine("\nInsertSort array in ascending order:");
            BaseTasksLibrary.GetDataFromConsole.WriteArray(BaseTasksLibrary.SimpleArraysCalc.InsertSortCalculation(arr));
        }


      
    }
}
