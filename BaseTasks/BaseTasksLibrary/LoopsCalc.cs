using System;
using System.Linq;


namespace BaseTasksLibrary
{
    public class LoopsCalc
    {

        /// <summary>
        /// SumEvenNumbers 1-99
        /// </summary>
        /// <param name="num">number</param>
        /// <returns>sum</returns>
        public static int SumEvenNumbersCalculation(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


        /// <summary>
        ///  Count number of even numbers 1-99
        /// </summary>
        /// <param name="num">number</param>
        /// <returnsnumber></returns>
        public static int NumberEvenNumbersCalculation(int num)
        {
            int counter = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }


        /// <summary>
        /// calculate if number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }


        /// <summary>
        /// Calculate Max Sqrt of number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Max Sqrt of number</returns>
        public static int MaxIntSqrt(int number)
        {
            int res = 0;
            if (number != 0)
            {
                do
                {
                    res++;
                } while (res * res <= number);
            }

            return --res;
        }

        /// <summary>
        /// calculate Factorial
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>fuctorial</returns>
        public static double Factorial(int number)
        {
            double result = 0.0;

            if (number == 1)
                result = 1;
            else
                result = number * Factorial(number - 1);

            return result;
        }



        /// <summary>
        /// Calculate Digits of number
        /// </summary>
        /// <param name="n">number</param>
        /// <returns>digits</returns>
        public static int NumDigits(int n, int k = 1)
        {
            int result = 0;

            if (n < 0)
            {
                n = -n;
            }

            if ((double)(n / 10) < 1)
            {
                result = k;
            }
            else
            {
                result = NumDigits(n / 10, k + 1);
            }

            return result;

        }



        /// <summary>
        /// Reverse number's characters
        /// </summary>
        /// <param name="number">numbre</param>
        /// <returns>number</returns>
        public static int[] ReverseAsArray(int number)
        {
            int[] result = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            Array.Reverse(result);
            return result;
        }

    }
}
