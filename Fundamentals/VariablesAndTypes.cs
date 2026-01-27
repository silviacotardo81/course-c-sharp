using System;

namespace CodingAssessment.Fundamentals
{
    public static class VariablesAndTypes
    {
        public static void Run()
        {
            var name = "Bob";
            var entero = 3;
            var flotante = 34.4;
            decimal money = 12.3m;

            Console.WriteLine($"Hello, {name}");
            Console.WriteLine(entero);
            Console.WriteLine(flotante);
            Console.WriteLine(money);
        }
    }
}
