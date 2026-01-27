using System;

namespace CodingAssessment.Fundamentals
{
    public static class EscapeSequences
    {
        public static void Run()
        {
            Console.WriteLine("Hello\nWorld!\\");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine(@"c:\Hello_World\mi_carpeta");
        }
    }
}
