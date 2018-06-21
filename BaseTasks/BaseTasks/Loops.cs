using System;
using System.Linq;


namespace BaseTasks
{
    class Loops 
    {

        static void Main(string[] args)
        {
            EvenNumbers();
            SimpleNumbers();
            SqrtToInteger();
            CalculateFactorial();
            CalculateSumOfSymbolsInNumbre();
            DigitMirror();
            
            Console.ReadLine();
        }


        /// <summary>
        /// Calculate sum of even numbers from 1 to 99
        /// </summary>
        public static void EvenNumbers()
        {
            Console.WriteLine("\nSum of even numbers from 1 to 99 is " + BaseTasksLibrary.LoopsCalc.SumEvenNumbersCalculation(99));
            Console.WriteLine("Number of even numbers from 1 to 99 is " + BaseTasksLibrary.LoopsCalc.NumberEvenNumbersCalculation(99));
        }


        /// <summary>
        /// check if number is simple (number is divided only by itself and 1
        /// </summary>
        public static void SimpleNumbers()
        {
            int isSimple = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter number to verify it's simple ");

            if (BaseTasksLibrary.LoopsCalc.IsPrime(isSimple))
            {
                Console.WriteLine("It is simple");
            }
            else
            {
                Console.WriteLine("It is not simple");
            }
        }


        /// <summary>
        /// Get square of Natural number with approximation to integer (with binary search)
        /// </summary>
        public static void SqrtToInteger()
        {
            int number = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter number to get maximum integer square root  ");
            Console.WriteLine("Sqrt(" + number + ") = " + BaseTasksLibrary.LoopsCalc.MaxIntSqrt(number));
        }


        /// <summary>
        /// Calculate Factorial of the number
        /// </summary>
        public static void CalculateFactorial()
        {
            int number = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter number to calculate factorial");
            Console.WriteLine(number + "! = " + BaseTasksLibrary.LoopsCalc.Factorial(number));

        }


        /// <summary>
        /// Calculate the sum of characters in number
        /// </summary>
        public static void CalculateSumOfSymbolsInNumbre()
        {
            int number = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter number to calculate the symbols");
            Console.WriteLine("We have " + BaseTasksLibrary.LoopsCalc.NumDigits(number) + " symbols");

        }


        /// <summary>
        /// Get new number from reverses inserted
        /// </summary>
        public static void DigitMirror()
        {
            int number = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter number for reverse");
            int[] result = BaseTasksLibrary.LoopsCalc.ReverseAsArray(number);

            Console.Write("Reversed number is ");
            foreach (int i in result)
            {
                Console.Write(i);
            }
        }

    }
}
