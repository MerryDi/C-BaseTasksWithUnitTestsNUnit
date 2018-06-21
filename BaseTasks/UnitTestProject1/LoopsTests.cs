using NUnit.Framework;


namespace BaseTasksTests
{
    class LoopsTests
    {
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(99, ExpectedResult = 2450)]
        public static int SumEvenNumbersCalculationTest(int num)
        {
            return BaseTasksLibrary.LoopsCalc.SumEvenNumbersCalculation(num);
        }



        [TestCase(1, ExpectedResult = 0)]
        [TestCase(99, ExpectedResult = 49)]
        public static int NumberEvenNumbersCalculationTest(int num)
        {
            return BaseTasksLibrary.LoopsCalc.NumberEvenNumbersCalculation(num);
        }



        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(22, ExpectedResult = false)]
        [TestCase(97, ExpectedResult = true)]
        [TestCase(625, ExpectedResult = false)]
        public static bool IsPrimeTest(int number)
        {
            return BaseTasksLibrary.LoopsCalc.IsPrime(number);
        }



        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(6, ExpectedResult = 2)]
        [TestCase(1000, ExpectedResult = 31)]
        public static int MAxIntSqrtTest(int number)
        {
            return BaseTasksLibrary.LoopsCalc.MaxIntSqrt(number);
        }



        [TestCase(1, ExpectedResult = 1)]
        [TestCase(4, ExpectedResult = 24)]
        public static double FactorialTest(int number)
        {
            return BaseTasksLibrary.LoopsCalc.Factorial(number);
        }

       

        [TestCase(0, ExpectedResult = 1)]
        [TestCase(10, ExpectedResult = 2)]
        [TestCase(100, ExpectedResult = 3)]
        [TestCase(1000, ExpectedResult = 4)]
        [TestCase(10000, ExpectedResult = 5)]
        [TestCase(100000, ExpectedResult = 6)]
        [TestCase(1000000, ExpectedResult = 7)]
        [TestCase(10000000, ExpectedResult = 8)]
        [TestCase(100000000, ExpectedResult = 9)]
        [TestCase(1000000000, ExpectedResult = 10)]
        [TestCase(-1000000000, ExpectedResult = 10)]
        public static int NumDigitsTest(int n)
        {
            return BaseTasksLibrary.LoopsCalc.NumDigits(n);
        }



        [TestCase(1000, ExpectedResult = new double[] { 0, 0, 0, 1 })]
        [TestCase(345678, ExpectedResult = new double[] { 8, 7, 6, 5, 4, 3 })]
        public static int[] ReverseAsArrayTest(int number)
        {
            return BaseTasksLibrary.LoopsCalc.ReverseAsArray(number);
        }


        
    }
}
