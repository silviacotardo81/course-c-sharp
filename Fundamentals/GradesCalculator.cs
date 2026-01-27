using System;

namespace CodingAssessment.Fundamentals.ControlExercises
{
    public static class GradesCalculator
    {
        public static void Run()
        {
            int currentAssignments = 5;

            int sophiaSum = 93 + 87 + 98 + 95 + 100;
            int nicolasSum = 80 + 83 + 82 + 88 + 85;
            int zahirahSum = 84 + 96 + 73 + 85 + 79;
            int jeongSum = 90 + 92 + 98 + 100 + 97;

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine($"Sophia\t\t{sophiaScore}");
            Console.WriteLine($"Nicolas\t\t{nicolasScore}");
            Console.WriteLine($"Zahirah\t\t{zahirahScore}");
            Console.WriteLine($"Jeong\t\t{jeongScore}");
        }
    }
}
