using System;
using NUnit.Framework;


namespace BaseTasksTests
{
    public class ConditionalOperatorsTests
    {
        [TestCase(256.21, 555.21, ExpectedResult = 1)]
        [TestCase(-256.21, 555.21, ExpectedResult = 2)]
        [TestCase(-256.21, -555.21, ExpectedResult = 3)]
        [TestCase(256.21, -555.21, ExpectedResult = 4)]
        [TestCase(0, 0, ExpectedResult = 1)]
        public int QuarterTest(double x, double y)
        {
            return BaseTasksLibrary.ConditionalOperatorsCalc.QuarterCalculation(x, y);
        }


        [TestCase(21, 22, ExpectedResult = 43)]
        [TestCase(22, 21, ExpectedResult = 462)]
        [TestCase(0, 1, ExpectedResult = 0)]
        [TestCase(-55, 12, ExpectedResult = -43)]
        [TestCase(-90, 110, ExpectedResult = -9900)]
        public double MultiplicationTest(double x, double y)
        {
            return BaseTasksLibrary.ConditionalOperatorsCalc.MultiplicationCalculation(x, y);
        }


        [TestCase(new double[] { 123.00, 123.00, 123.00 }, ExpectedResult = 369.00)]
        [TestCase(new double[] { 123, 123, -123 }, ExpectedResult = 246)]
        [TestCase(new double[] { 123, -123, 123 }, ExpectedResult = 246)]
        [TestCase(new double[] { 123, -123, -123 }, ExpectedResult = 123)]
        [TestCase(new double[] { -123, 123, 123 }, ExpectedResult = 246)]
        [TestCase(new double[] { -123, 123, -123 }, ExpectedResult = 123)]
        [TestCase(new double[] { -123, -123, 123 }, ExpectedResult = 123)]
        [TestCase(new double[] { -123, -123, -123 }, ExpectedResult = 0)]
        [TestCase(new double[] { 0, 0, 0 }, ExpectedResult = 0)]
        public double PositiveSumTest(double[] a)
        {
            return BaseTasksLibrary.ConditionalOperatorsCalc.PositiveSumCalculation(a);
        }



        [TestCase(new double[] { 3, -1, -2 }, ExpectedResult = 9)]
        [TestCase(new double[] { -1, 3, -2 }, ExpectedResult = 9)]
        [TestCase(new double[] { -1, 3, -2 }, ExpectedResult = 9)]
        [TestCase(new double[] { -3, 1, 2 }, ExpectedResult = 3)]
        [TestCase(new double[] { 1, -3, 2 }, ExpectedResult = 3)]
        [TestCase(new double[] { 1, 2, -3 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, 2, 1 }, ExpectedResult = 6)]
        [TestCase(new double[] { 0, 2, -1 }, ExpectedResult = 4)]
        [TestCase(new double[] { 0, 2, 0 }, ExpectedResult = 5)]
        [TestCase(new double[] { 0, -2, 3 }, ExpectedResult = 4)]
        [TestCase(new double[] { 0, 0, 3 }, ExpectedResult = 6)]
        [TestCase(new double[] { 2, 0, 2 }, ExpectedResult = 7)]
        [TestCase(new double[] { 2, 0, -1 }, ExpectedResult = 4)]
        [TestCase(new double[] { 2, 0, 0 }, ExpectedResult = 5)]
        [TestCase(new double[] { -2, 0, 3 }, ExpectedResult = 4)]
        [TestCase(new double[] { 2, 2, 0 }, ExpectedResult = 7)]
        [TestCase(new double[] { -1, 2, 0 }, ExpectedResult = 4)]
        [TestCase(new double[] { 3, -2, 0 }, ExpectedResult = 4)]
        [TestCase(new double[] { 0, 2, -3 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, 2, -2 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, -2, 2 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, -2, 1 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, -2, -1 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, -2, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, 0, -1 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, 0, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { 2, 0, -3 }, ExpectedResult = 3)]
        [TestCase(new double[] { 2, 0, -2 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, 0, 2 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, 0, 1 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, 0, -1 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, 0, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { 2, -2, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, 0, -2 }, ExpectedResult = 3)]
        [TestCase(new double[] { 2, -3, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, 1, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, -1, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2, 0, 0 }, ExpectedResult = 3)]
        [TestCase(new double[] { 0, -2, 0 }, ExpectedResult = 3)]
        public double MaxValueTest(double[] a)
        {
            return BaseTasksLibrary.ConditionalOperatorsCalc.MaxValueCalculation(a);
        }


        [Test]
        public void MaxValueThrowTest()
        {

            Assert.That(() => BaseTasksLibrary.ConditionalOperatorsCalc.MaxValueCalculation(new double[] {1, 1, 1, 1}), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }


        [TestCase(100, ExpectedResult = "A")]
        [TestCase(90, ExpectedResult = "A")]
        [TestCase(89, ExpectedResult = "B")]
        [TestCase(75, ExpectedResult = "B")]
        [TestCase(74, ExpectedResult = "C")]
        [TestCase(60, ExpectedResult = "C")]
        [TestCase(59, ExpectedResult = "D")]
        [TestCase(40, ExpectedResult = "D")]
        [TestCase(39, ExpectedResult = "E")]
        [TestCase(20, ExpectedResult = "E")]
        [TestCase(19, ExpectedResult = "F")]
        [TestCase(1, ExpectedResult = "F")]
        public string StudentMarksTest(int x)
        {
            return BaseTasksLibrary.ConditionalOperatorsCalc.StudentMarksCalculation(x);
        }


        [Test]
        public void StudentMarksThrowETest()
        {
            Assert.That(() => BaseTasksLibrary.ConditionalOperatorsCalc.StudentMarksCalculation(-1), Throws.Exception.TypeOf<ArgumentException>());
        }
    }
}
