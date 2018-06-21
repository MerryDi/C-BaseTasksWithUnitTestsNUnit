using System;


namespace BaseTasks
{
  
    class ConditionalOperators 
        {
            static void Main(string[] args)
            {
                Quarter();
                Multiplication();
                PositiveSum();
                MaxValue();
                StudentMarks();

                Console.ReadLine();

            }

            /// <summary>
            /// Calculation the quarter of coordinates sheat for the point inserted from the stream
            /// </summary>
            public static void Quarter()
            {
                Console.WriteLine("\nQuarter calculation, enter 2 numbers");
                int a = BaseTasksLibrary.GetDataFromConsole.GetIntValue("Enter value for a ");
                int b = BaseTasksLibrary.GetDataFromConsole.GetIntValue("Enter value for b ");

                Console.WriteLine("The quarter is {0}", BaseTasksLibrary.ConditionalOperatorsCalc.QuarterCalculation(a, b));
            }


            /// <summary>
            /// Calculate a*b if a is even number and a+b otherwise
            /// </summary>
            public static void Multiplication()
            {
                Console.WriteLine("\nMultiplication calculation, enter 2 numbers");
                double a = BaseTasksLibrary.GetDataFromConsole.GetDoubleValue("Enter value for a ");
                double b = BaseTasksLibrary.GetDataFromConsole.GetDoubleValue("Enter value for b ");

                Console.WriteLine("The multiplication if a is positive and sum otherwise is {0}", BaseTasksLibrary.ConditionalOperatorsCalc.MultiplicationCalculation(a, b));
            }


            /// <summary>
            /// Calculate the sum of positive numbers
            /// </summary>
            static void PositiveSum()
            {
                double[] a = new double[3];

                Console.WriteLine("\nPositiveSum calculation, enter 3 numbers");

                for (int i = 1; i <= a.Length; i++)
                {
                    a[i - 1] = BaseTasksLibrary.GetDataFromConsole.GetDoubleValue("Enter value for a" + i);
                }

                Console.WriteLine("The positive sum is {0}", BaseTasksLibrary.ConditionalOperatorsCalc.PositiveSumCalculation(a));

            }


            /// <summary>
            /// Calculate max(a*b*c, a+b+c)+3 
            /// </summary>
            static void MaxValue()
            {
                double[] a = new double[3];

                Console.WriteLine("\nThe max(a*b*c, a+b+c)+3 calculation, enter 3 numbers");
                for (int i = 1; i <= a.Length; i++)
                {
                    a[i - 1] = BaseTasksLibrary.GetDataFromConsole.GetDoubleValue("Enter value for a" + i);
                }

                Console.WriteLine("Result is ${0}", BaseTasksLibrary.ConditionalOperatorsCalc.MaxValueCalculation(a));
            }


            /// <summary>
            /// Transform students marks to ABCDEF
            /// </summary>
            public static void StudentMarks()
            {
                int mark = BaseTasksLibrary.GetDataFromConsole.GetIntValue("\nEnter student's mark (type number 0 to exit )");

                if (BaseTasksLibrary.ConditionalOperatorsCalc.StudentMarksCalculation(mark) == "")
                {
                    StudentMarks();
                }
                else
                {
                    Console.WriteLine("The rate is {0}", BaseTasksLibrary.ConditionalOperatorsCalc.StudentMarksCalculation(mark));
                }

            }



        }

    
}