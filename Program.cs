using System;
using CodingAssessment.Fundamentals;
using CodingAssessment.Fundamentals.ControlExercises;
using CodingAssessment.Exercises.Arrays;
using CodingAssessment.Exercises.Strings;
using CodingAssessment.Exercises.Graph;

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

                case "servicetime":
                    RunServiceTime();
                    break;

                case "concurrencypeak":
                    RunConcurrencyPeak();
                    break;

                case "taxicalls":
                    RunTaxiCalls();
                    break;

                default:
                    ShowHelp();
                    break;
            }
        }

// ===== Algorithm runners =====
        private static void RunTaxiCalls()
        {
            int[][] calls =
            {
                new int[] {10, 20, 1, 2},  // Viaje 0
                new int[] {25, 35, 2, 3},  // Viaje 1
                new int[] {40, 50, 3, 4},  // Viaje 2
                new int[] {22, 30, 2, 5}   // Viaje 3
            };
            int result = TaxiCalls.Solve(calls);
            Console.WriteLine(result); 
        }

        private static void RunConcurrencyPeak()
        {
            int[][] requests =
            {
                new int[] { 1, 4 },
                new int[] { 2, 6 },
                new int[] { 3, 5 },
                new int[] { 7, 9 }
            };

            int result = ConcurrencyPeak.Solve(requests);
            Console.WriteLine(result); // debería imprimir 3
        }

        private static void RunServiceTime()
        {
            int[] requests = { 1, 4, 7, 10, 13 };
            int t = 12;
            int x = 7;
            int result = ServiceTime.Solve(requests, t, x);
            Console.WriteLine(result);
        }

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
            Console.WriteLine("  dotnet run servicetime");
            Console.WriteLine("  dotnet run taxicalls");
        }
    }
}
