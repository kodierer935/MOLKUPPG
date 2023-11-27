using System;

namespace inl3_uppg1
{
    internal class Program
    {
        // 4. Up here there should be a static method Func with two parameters X and Y
        public static double Funk(double x, double y)
        {
            return 2 * x + y / 4;
        }

        public static void Main(string[] args)
        {
            // 1. Correct the line below so that the next line prints 0.4!!
            double a = 2.0 / 5;              // <-- Change here!
            Console.WriteLine($"a = {a}"); // <-- Should give "a = 0.4"

            // 2. Make a loop that prints the int array:


            int[] I = new int[] { 99, 12, 4, 7, 33 };
            // insert the loop here!
            foreach (int i in I)
            {
                Console.WriteLine(i);
            }


            // 3. Make a loop that prints the elements of the int array that are greater than 5:
            int[] J = new int[] { 2, 1, 5, 0, 4, 2, 7, 2, 7, 2, 0, 2, 8, 3, 2 };
            // insert the loop here!
            foreach (int i in J)
            {
                if (i > 5)
                {
                    Console.WriteLine(i);
                }
            }


            // 4. Make a static method Func that replaces the calculation expression
            //    2 * X + Y / 4 below:
            double X = 2.3;
            double Y = 12.8;
            double Z = Funk(X, Y);
            Console.WriteLine(Z); // Should give 7.8
        }
    }
}