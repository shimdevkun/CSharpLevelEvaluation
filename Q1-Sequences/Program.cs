﻿using System;

namespace Q1_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethods();

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }

        /// <summary>
        ///     This method prints all odd numbers from 0 to 10 using a loop.
        ///     You should not use an if statement
        ///     Output:
        ///     1
        ///     3
        ///     5
        ///     7
        ///     9
        /// </summary>
        public static void PrintOddNumbers()
        {
            // TODO: Implement this method to match the description above
            for (int i = 1; i < 10; i += 2)
                Console.WriteLine(i);
        }

        /// <summary>
        ///     This method prints the multiples of both 2 and 3
        ///     between 1 and 30 inclusively.
        ///     You must use the % (remainder) operator.
        ///     Output:
        ///     6
        ///     12
        ///     18
        ///     24
        ///     30
        /// </summary>
        public static void PrintMultiplesOf2And3()
        {
            // TODO: Implement this method to match the description above
            for (int i = 1; i < 10; i += 2)
                if (i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine(i);
        }


        /// <summary>
        ///     This method prints a line of 10 * with a loop
        ///     Output: **********
        /// </summary>
        public static void PrintLine()
        {
            // TODO: Implement this method to match the description above
            for (int i = 0; i < 10; i++)
                Console.Write("*");
        }

        /// <summary>
        ///     This method prints a line with a length of 10
        ///     by alternating * and - with a loop
        ///     Output: *-*-*-*-*-
        /// </summary>
        public static void PrintLineComplex()
        {
            // TODO: Implement this method to match the description above
            for (int i = 0; i < 10; i++)
                if (i % 2 == 0) Console.Write("*");
                else Console.Write("-");
        }

        /// <summary>
        ///     This method prints the following shape:
        ///           ***
        ///           * *
        ///           *** 
        /// </summary>
        public static void PrintRectangle()
        {
            // TODO: Implement this method to match the description above
            for (int i = 0; i < 3; i++)
                Console.Write("*");
            Console.WriteLine();

            Console.Write("*");
            Console.Write(" ");
            Console.WriteLine("*");

            for (int i = 0; i < 3; i++)
                Console.Write("*");
        }

        /// <summary>
        ///     This method prints a shape with n lines and n columns
        ///     where n is the length parameter.
        ///     Output for 5:
        ///          *****
        ///          *   *
        ///          *   *
        ///          *   *
        ///          *****
        /// </summary>
        public static void PrintRectangleComplex(int length)
        {
            // TODO: Implement this method to match the description above
            for (int i = 0; i < length; i++)
                Console.Write("*");
            Console.WriteLine();


            for (int i = 0; i < length - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < length - 2; j++)
                    Console.Write(" ");
                Console.WriteLine("*");
            }

            for (int i = 0; i < length; i++)
                Console.Write("*");
        }

        /// <summary>
        ///     This method prints a triangle
        ///     Output:
        ///            *
        ///           ***
        ///          *****
        /// </summary>
        public static void PrintTriangle()
        {
            // TODO: Implement this method to match the description above
            int height = 3;
            int stars = 1;

            for (int i = 0; i < height; i++, stars += 2)
            {
                for (int j = 0; j < height - i; j++)
                    Console.Write(" ");

                for (int j = 0; j < stars; j++)
                    Console.Write("*");

                for (int j = 0; j < height - i; j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
        }



        // ----------------------------------------------------
        // ---------- DO NOT MODIFY THE TEST SECTION ----------
        // ----------------------------------------------------
        #region TEST

        /// <summary>
        ///     This method calls all methods within the Sequences class
        /// </summary>
        public static void TestMethods()
        {
            Console.WriteLine("First 10 odd numbers:");
            PrintOddNumbers();

            Console.WriteLine();

            Console.WriteLine("First 10 multiples of 2 and 3:");
            PrintMultiplesOf2And3();

            Console.WriteLine();

            Console.WriteLine("Simple line:");
            PrintLine();

            Console.WriteLine();

            Console.WriteLine("Complex line:");
            PrintLineComplex();

            Console.WriteLine();

            Console.WriteLine("Default rectangle:");
            PrintRectangle();

            Console.WriteLine();

            Console.WriteLine("4 x 4 rectangle:");
            PrintRectangleComplex(4);

            Console.WriteLine();

            Console.WriteLine("10 x 10 rectangle:");
            PrintRectangleComplex(10);

            Console.WriteLine();

            Console.WriteLine("Default triangle:");
            PrintTriangle();
        }
        #endregion
    }
}
