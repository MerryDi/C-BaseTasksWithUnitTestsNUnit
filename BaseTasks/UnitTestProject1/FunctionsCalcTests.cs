using NUnit.Framework;

namespace BaseTasksTests
{
    class FunctionsCalcTests
    {
        [TestCase(1, ExpectedResult = "Sunday")]
        [TestCase(2, ExpectedResult = "Monday")]
        [TestCase(3, ExpectedResult = "Tuesday")]
        [TestCase(4, ExpectedResult = "Wednesday")]
        [TestCase(5, ExpectedResult = "Thursday")]
        [TestCase(6, ExpectedResult = "Friday")]
        [TestCase(7, ExpectedResult = "Saturday")]
        [TestCase(8, ExpectedResult = "Incorrect data!")]
        [TestCase(0, ExpectedResult = "Incorrect data!")]
        public static string GetWeekDayNumberCalculationTest(int num)
        {
            return BaseTasksLibrary.FunctionsCalc.GetWeekDayNumberCalculation(num);
        }



        [TestCase(0, ExpectedResult = "zero")]
        [TestCase(-15, ExpectedResult = "minus fifteen")]
        [TestCase(3000000, ExpectedResult = "three million")]
        [TestCase(400000, ExpectedResult = "four hundred thousand")]
        [TestCase(50000, ExpectedResult = "fifty thousand")]
        [TestCase(6025, ExpectedResult = "six thousandand twenty-five")]
        [TestCase(100, ExpectedResult = "one hundred")]
        [TestCase(84, ExpectedResult = "eighty-four")]
        public static string WordsConstructorCalculationTest(int num)
        {
            return BaseTasksLibrary.FunctionsCalc.WordsConstructor(num);
        }



        [TestCase(20, ExpectedResult = "Twenty ")]
        [TestCase(30, ExpectedResult = "Thirty ")]
        [TestCase(40, ExpectedResult = "Forty ")]
        [TestCase(50, ExpectedResult = "Fifty ")]
        [TestCase(60, ExpectedResult = "Sixty ")]
        [TestCase(70, ExpectedResult = "Seventy ")]
        [TestCase(80, ExpectedResult = "Eighty ")]
        [TestCase(95, ExpectedResult = "Ninety Five ")]
        [TestCase(-15, ExpectedResult = "Minus Fifteen ")]
        [TestCase(-200, ExpectedResult = "Minus Two Hundreds ")]
        [TestCase(3000000, ExpectedResult = "Three Millions ")]
        [TestCase(400000, ExpectedResult = "Four Hundreds Thousands ")]
        [TestCase(50000, ExpectedResult = "Fifty Thousands ")]
        [TestCase(6025, ExpectedResult = "Six Thousands Twenty Five ")]
        [TestCase(100, ExpectedResult = "One Hundred ")]
        [TestCase(84, ExpectedResult = "Eighty Four ")]
        [TestCase(1005, ExpectedResult = "One Thousand Five ")]
        [TestCase(1000005, ExpectedResult = "One Million Five ")]
        [TestCase(1000000000, ExpectedResult = "One Billion ")]
        [TestCase(1999999, ExpectedResult = "One Million Nine Hundreds Ninety Nine Thousands Nine Hundreds Ninety Nine ")]
        [TestCase(1000000003, ExpectedResult = "One Billion Three ")]
        [TestCase(2000000000, ExpectedResult = "Two Billions ")]
        public static string NumberToTextTest(int num)
        {
            return BaseTasksLibrary.FunctionsCalc.NumberToText(num);
        }



        [TestCase( new int[] { 3, 4, -3, -4 }, ExpectedResult = 10)]
        [TestCase(new int[] { 0, 0, 0, 0 }, ExpectedResult = 0)]
        public static double DistanceBetweenTwoPointCalculationTest(int[] arr)
        {
            return BaseTasksLibrary.FunctionsCalc.DistanceBetweenTwoPointCalculation(arr);

        }
    }
}
