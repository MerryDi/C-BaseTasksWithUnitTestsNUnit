using System;


namespace BaseTasks
{
    class Functions 
    {
        static void Main(string[] args)
        {
            GetWeekDayNumber();
            NumberToWordsGenerator();
            WordsToNumberGenerator();
            DistanceBetweenTwoPoint();

            Console.ReadLine();

        }


        /// <summary>
        ///  Get Numbe of Week Day and return the Word
        /// </summary>
        public static void GetWeekDayNumber()
        {
            Console.WriteLine("\nEnter number of a day of the week:");

            int x = int.Parse(Console.ReadLine());
          
            Console.WriteLine(BaseTasksLibrary.FunctionsCalc.GetWeekDayNumberCalculation(x));
        }


        /// <summary>
        /// Convert Number To Words 
        /// </summary>
        public static void NumberToWordsGenerator()
        {
            int number = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter a number to modify it to string ");
            Console.WriteLine(BaseTasksLibrary.FunctionsCalc.WordsConstructor(number));
        }


        /// <summary>
        /// Convert Words To Number
        /// </summary>
        public static void WordsToNumberGenerator()
        {
            int number = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter numder  to transform it into numbers in words from 0 to 999 999 999 999  ");

            Console.WriteLine(BaseTasksLibrary.FunctionsCalc.NumberToText(number));

        }


        /// <summary>
        /// Calculate the Distance Between Two Point
        /// </summary>
        public static void DistanceBetweenTwoPoint()
        {
            int[] arr = BaseTasksLibrary.GetDataFromConsole.GetPoint();

            Console.WriteLine("\nThe distance is :" + BaseTasksLibrary.FunctionsCalc.DistanceBetweenTwoPointCalculation(arr));
        }

    }
}
