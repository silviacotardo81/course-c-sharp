using System;

namespace CodingAssessment.Fundamentals
{
    public static class StringsAndInterpolation
    {
        public static void Run()
        {
            string firstName = "Bob";
            string greeting = "Hello";

            Console.WriteLine(greeting + " " + firstName + "!");
            Console.WriteLine($"{greeting} {firstName}!");

            int version = 11;
            string updateText = "Update to Windows";
            Console.WriteLine($"{updateText} {version}!");

            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }
    }
}
