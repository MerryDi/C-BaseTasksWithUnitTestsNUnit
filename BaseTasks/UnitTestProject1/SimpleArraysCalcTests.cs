using NUnit.Framework;
using System;

namespace BaseTasksTests
{
    class SimpleArraysCalcTests
    {
        [TestCase(new int[] { -1100, 0, 0, 1 }, ExpectedResult = -1100)]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = 0)]
        public static int MinElementCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.MinElementCalculation(arr);
        }


        [Test]
        public void MinElementCalculationThrowTest()
        {
            Assert.That(() => BaseTasksLibrary.SimpleArraysCalc.MinElementCalculation(new int[] { }), Throws.Exception.TypeOf<InvalidOperationException>());
        }


        [TestCase(new int[] { -1100, 0, 0, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = 1100)]
        public static int MaxElementCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.MaxElementCalculation(arr);
        }

        [Test]
        public void MaxElementCalculationThrowTest()
        {
            Assert.That(() => BaseTasksLibrary.SimpleArraysCalc.MaxElementCalculation(new int[] { }), Throws.Exception.TypeOf<InvalidOperationException>());
        }


        
        [TestCase(new int[] { -1100, 0, 0, 1 }, ExpectedResult = 0)]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = 1)]
        public static int IndexOfMinElementCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.IndexOfMinElementCalculation(arr);
        }

        [Test]
        public void IndexOfMinElementCalculationThrowTest()
        {
            Assert.That(() => BaseTasksLibrary.SimpleArraysCalc.IndexOfMinElementCalculation(new int[] { }), Throws.Exception.TypeOf<InvalidOperationException>());
        }


        [TestCase(new int[] { -1100, 0, 0, 1 }, ExpectedResult = 3)]
        public static int IndexOfMaxElementCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.IndexOfMaxElementCalculation(arr);
        }

        [Test]
        public void IndexOfMaxElementCalculationThrowTest()
        {
            Assert.That(() => BaseTasksLibrary.SimpleArraysCalc.IndexOfMaxElementCalculation(new int[] { }), Throws.Exception.TypeOf<InvalidOperationException>());
        }


        [TestCase(new int[] { -1100, 0, 0, 100 }, ExpectedResult = 100)]
        public static int SumOfElementsWithOddIndexCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.SumOfElementsWithOddIndexCalculation(arr);
        }

      

        [TestCase(new int[] { -1100, 0, 0, 100 }, ExpectedResult = 2)]
        public static int NumberOfElementsWithOddIndexCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.NumberOfElementsWithOddIndexCalculation(arr);
        }


   

        [TestCase(new int[] { -1100, 0, 0, 100 }, ExpectedResult = new int[] { 100, 0, 0, -1100 })]
        public static int[] ArrayReverseCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.ArrayReverseCalculation(arr);
        }




        [TestCase(new int[] { -1100, 0, 25, 0, 1 }, ExpectedResult = new int[] { 0, 1, 25, -1100, 0 })]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = new int[] { 0, 1100, 10, 0 })]
        public static int[] AnotherReverseCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.AnotherReverseCalculation(arr);
        }





        [TestCase(new int[] { -1100, 0, 25, 0, 1 }, ExpectedResult = new int[] { -1100, 0, 0, 1, 25 })]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = new int[] { 0, 0, 10, 1100 })]
        public static int[] BubbleSortCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.BubbleSortCalculation(arr);
        }



        [TestCase(new int[] { -1100, 0, 25, 0, 1 }, ExpectedResult = new int[] { -1100, 0, 0, 1, 25 })]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = new int[] { 0, 0, 10, 1100 })]
        public static int[] SelectSortCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.SelectSortCalculation(arr);
        }




        [TestCase(new int[] { -1100, 0, 25, 0, 1 }, ExpectedResult = new int[] { -1100, 0, 0, 1, 25 })]
        [TestCase(new int[] { 10, 0, 0, 1100 }, ExpectedResult = new int[] { 0, 0, 10, 1100 })]
        public static int[] InsertSortCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.SimpleArraysCalc.InsertSortCalculation(arr);
        }



    }
}
