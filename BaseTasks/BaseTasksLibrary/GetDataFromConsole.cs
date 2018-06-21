using System;


namespace BaseTasksLibrary
{
    public class GetDataFromConsole
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Get value from stream as Ushort
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetIntValue(string input)
        {
            int value;
            Console.WriteLine(input);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid value please try again..");
            }

            return value;
        }


        /// <summary>
        /// GetDoubleValue from stream
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double GetDoubleValue(string input)
        {
            double value;
            Console.WriteLine(input);

            while (!Double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("\n invalid value please try again..");
            }
            return value;
        }


        /// <summary>
        /// WriteArray to stream
        /// </summary>
        /// <param name="arr"></param>
        public static void WriteArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\n Array Index: " + i + " AND Array Item: " + arr[i].ToString());
            }
        }

        /// <summary>
        /// GetArray from stream
        /// </summary>
        /// <returns></returns>
        public static int[] GetArray()
        {
            Console.WriteLine("\n Define Array Size? ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter numbers divided by Enter:\n");
            int[] arr = new int[number];

            for (int i = 0; i < number; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        /// <summary>
        /// GetPoint from stream
        /// </summary>
        /// <returns></returns>
        public static int[] GetPoint()
        {
            Console.WriteLine("\nInser point A coordinates:");
            int x1 = GetIntValue("x_1 = ");
            int y1 = GetIntValue("y_1 = ");

            Console.WriteLine("\nInser point B coordinates:");
            int x2 = GetIntValue("x_2 = ");
            int y2 = GetIntValue("y_2 = ");

            int[] arr = { x1, y1, x2, y2 };

            return arr;
        }

    }


    /// <summary>
    /// Interface for adding numbers
    /// </summary>
    public interface IAdder
    {
        string AddInt(string first);
        string AddDouble(string first);
    }


    /// <summary>
    /// Implementation of interface
    /// </summary>
    public class AdderService : IAdder
    {
        public string AddDouble(string first)
        {
            try
            {
                var value = Double.Parse(first);
                return value.ToString();
            }
            catch (FormatException)
            {
                throw new FormatException();
            }

        }


        public string AddInt(string first)
        {
            try
            {
                var value = int.Parse(first);
                return value.ToString();
            }
            catch (FormatException)
            {
                throw new FormatException();
            }

        }

    }

}
