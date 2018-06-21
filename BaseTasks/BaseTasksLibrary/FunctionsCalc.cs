using System;
using System.Globalization;
using System.Threading;


namespace BaseTasksLibrary
{
    public class FunctionsCalc
    {

        /// <summary>
        /// Get Week Day Number
        /// </summary>
        /// <param name="number">number of weekday</param>
        /// <returns>weekday in words</returns>
        public static string GetWeekDayNumberCalculation(int number)
        {
            string result = "";

            if (CultureInfo.CurrentCulture.Name == "ru-RU") //"en-US")
            {
                number += 1;

            }
            
            Console.WriteLine(CultureInfo.CurrentCulture.Name);

                switch (number)
            {
                case 1:
                    result = "Sunday";
                    break;
                case 2:
                    result =  "Monday";
                    break;
                case 3:
                    result = "Tuesday";
                    break;
                case 4:
                    result = "Wednesday";
                    break;
                case 5:
                    result = "Thursday";
                    break;
                case 6:
                    result = "Friday";
                    break;
                case 7:
                    result = "Saturday";
                    break;
            }
            result = "Incorrect data!";

            return result;

        }


        /// <summary>
        /// Get number in words
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>number in words</returns>
        public static string WordsConstructor(int number)
        {
            string words = "";

            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + WordsConstructor(Math.Abs(number));

            

            if ((number / 1000000) > 0)
            {
                words += WordsConstructor(number / 1000000) + " million";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += WordsConstructor(number / 1000) + " thousand";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += WordsConstructor(number / 100) + " hundred";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }


        /// <summary>
        /// NumberToText for 1 - 999 999 999 999 
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>number in words</returns>
        public static string NumberToText(int number)
        {
            string words = "";

            if (number < 0)
                words = "Minus " + NumberToText(-number);
            else if (number == 0)
                words = "";
            else if (number <= 19)
                words = new string[] {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
         "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
         "Seventeen", "Eighteen", "Nineteen"}[number - 1] + " ";
            else if (number  <= 99)
                words = new string[] {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy",
         "Eighty", "Ninety"}[number / 10 - 2] + " " + NumberToText(number % 10);
            else if (number <= 199)
                words = "One Hundred " + NumberToText(number % 100);
            else if (number <= 999)
                words = NumberToText(number / 100) + "Hundreds " + NumberToText(number % 100);
            else if (number <= 1999)
                words = "One Thousand " + NumberToText(number % 1000);
            else if (number <= 999999)
                words = NumberToText(number / 1000) + "Thousands " + NumberToText(number % 1000);
            else if (number <= 1999999)
                words = "One Million " + NumberToText(number % 1000000);
            else if (number <= 999999999)
                words = NumberToText(number / 1000000) + "Millions " + NumberToText(number % 1000000);
            else if (number <= 1999999999)
                words = "One Billion " + NumberToText(number % 1000000000);
            else
                words = NumberToText(number / 1000000000) + "Billions " + NumberToText(number % 1000000000);

            return words;
        }


        /// <summary>
        /// Calculation Distance Between Two Point 
        /// </summary>
        /// <param name="arr">array with point's coordinates</param>
        /// <returns>distance between two points</returns>
        public static double DistanceBetweenTwoPointCalculation(int[] arr)
        {
            return  Math.Sqrt( Math.Pow((arr[2] - arr[0]), 2) +  Math.Pow((arr[3] - arr[1]), 2));
        }
    }
}
