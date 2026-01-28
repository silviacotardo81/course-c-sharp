using System;
using System.Data;

namespace CodingAssessment.Exercises.Arrays
{
    public static class ConcurrencyPeak
    {
        public static int Solve(int[][] requests)
        {
            int maxConcurrency = 0;

            for (int i = 0; i < requests.Length; i++)
            {
                int count = 0;
                int startA = requests[i][0];
                int endA = requests[i][1];

                for (int j = 0; j < requests.Length; j++)
                {
                    if (i == j) continue;

                    int startB = requests[j][0];
                    int endB = requests[j][1];

                    if (startA < endB && startB < endA)
                    {
                        count++;
                    }
                }

                if (count > maxConcurrency)
                {
                    maxConcurrency = count;
                }
            }

            return maxConcurrency;
        }
    }
}