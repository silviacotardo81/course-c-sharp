using System;

namespace CodingAssessment.Exercises.Arrays
{
    public static class ServiceTime
    {
        public static int Solve(int[] requests, int t, int x)
        {
            int count = 0;
            int startTime = t - x;

            for (int i = 0; i < requests.Length; i++)
            {
                if (requests[i] >= startTime && requests[i] <= t)
                {
                    count++;
                }
            }
            return count;
        }

    }
}

