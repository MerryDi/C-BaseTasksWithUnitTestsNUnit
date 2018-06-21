using System;



namespace BaseTasksLibrary
{
    public class ConditionalOperatorsCalc
    {

        /// <summary>
        /// Calculate the quarter for the point
        /// </summary>
        /// <param name="a">x axis</param>
        /// <param name="b">y axis</param>
        /// <returns>The quarter of Coordinate system where the point located</returns>
        public static int QuarterCalculation(double a, double b)
        {
            int result = 0;
            if (a >= 0)
            {
                result = b >= 0 ? 1 : 4;
            }
            else
            {
                result = b >= 0 ? 2 : 3;
            }


            return result;
        }


        /// <summary>
        /// Calculate a*b if a is even number and a+b otherwise
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The result of operation</returns>
        public static double MultiplicationCalculation(double a, double b)
        {
            return a % 2 == 0 ? a * b : a + b;
        }


        /// <summary>
        /// Calculate the sum of positive numbers
        /// </summary>
        /// <param name="a">Array of numbers</param>
        /// <returns>The sum of numbers</returns>
        public static double PositiveSumCalculation(double[] a)
        {
            double sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0) sum += a[i];
            }

            return sum;
        }


        /// <summary>
        /// Calculate max(a*b*c, a+b+c)+3 
        /// </summary>
        /// <param name="a">Array of numbers</param>
        /// <returns>Max Value</returns>
        public static double MaxValueCalculation(double[] a)
        {
           
                if (a.Length == 3)
                {
                    return Math.Max(a[0] * a[1] * a[2], a[0] + a[1] + a[2]) + 3;

                }

            throw new ArgumentOutOfRangeException();

        }


        /// <summary>
        /// Transform students marks to ABCDEF
        /// </summary>
        /// <param name="mark">mark</param>
        /// <returns>Student's Mark</returns>
        public static string StudentMarksCalculation
            (int mark)
        {
            string result = "";

            switch (mark)
            {
                case int i when (mark >= 1 && mark <= 19):
                    result =  "F";
                    break;
                case int i when (mark >= 20 && mark <= 39):
                    result = "E";
                    break;
                case int i when (mark >= 40 && mark <= 59):
                    result = "D";
                    break;
                case int i when (mark >= 60 && mark <= 74):
                    result = "C";
                    break;
                case int i when (mark >= 75 && mark <= 89):
                    result = "B";
                    break;
                case int i when (mark >= 90 && mark <= 100):
                    result = "A";
                    break;
                default:
                   throw new ArgumentException($"{mark} is out of range");
            }
            return result;
        }


    }
}

