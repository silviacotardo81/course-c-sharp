using System;

namespace CodingAssessment.Fundamentals
{
    public static class ArithmeticAndCasting
    {
        public static void Run()
        {
            int result = 3 + 1 * 5 / 2;
            Console.WriteLine(result);

            Console.WriteLine(5 / 10);      // int division
            Console.WriteLine(7m / 5);      // decimal division
        }
    }
}
