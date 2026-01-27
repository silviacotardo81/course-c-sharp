using System;
using CodingAssessment.Fundamentals;
using CodingAssessment.Fundamentals.ControlExercises;
using CodingAssessment.Exercises.Arrays;
using CodingAssessment.Exercises.Strings;

namespace CodingAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp();
                return;
            }

            switch (args[0].ToLower())
            {
                // ===== Fundamentals =====
                case "variables":
                    VariablesAndTypes.Run();
                    break;

                case "strings":
                    StringsAndInterpolation.Run();
                    break;

                case "escape":
                    EscapeSequences.Run();
                    break;

                case "arithmetic":
                    ArithmeticAndCasting.Run();
                    break;

                case "grades":
                    GradesCalculator.Run();
                    break;

                // ===== Algorithms =====
                case "containsduplicate":
                    RunContainsDuplicate();
                    break;

                case "twosum":
                    RunTwoSum();
                    break;

                case "palindrome":
                    RunPalindrome();
                    break;

                case "firstunique":
                    RunFirstNonRepeatedChar();
                    break;

                default:
                    ShowHelp();
                    break;
            }
        }

        // ===== Algorithm runners =====

        static void RunContainsDuplicate()
        {
            int[] nums = { 1, 2, 3, 4, 1 };
            bool result = ContainsDuplicate.Solve(nums);
            Console.WriteLine(result);
        }

        static void RunTwoSum()
        {
            int[] nums = { 5, 1, 2, 4 };
            int target = 10;
            bool result = TwoSum.Solve(nums, target);
            Console.WriteLine(result);
        }

        static void RunPalindrome()
        {
            string word = "ana";
            bool result = IsPalindrome.Solve(word);
            Console.WriteLine(result);
        }

        static void RunFirstNonRepeatedChar()
        {
            string word = "loveleetcode";
            int index = FirstNonRepeatedChar.Solve(word);
            Console.WriteLine(index);
        }

        static void ShowHelp()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("Fundamentals:");
            Console.WriteLine("  dotnet run variables");
            Console.WriteLine("  dotnet run strings");
            Console.WriteLine("  dotnet run escape");
            Console.WriteLine("  dotnet run arithmetic");
            Console.WriteLine("  dotnet run grades");
            Console.WriteLine();
            Console.WriteLine("Algorithms:");
            Console.WriteLine("  dotnet run containsduplicate");
            Console.WriteLine("  dotnet run twosum");
            Console.WriteLine("  dotnet run palindrome");
            Console.WriteLine("  dotnet run firstunique");
        }
    }
}
