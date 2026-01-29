using System;

namespace CodingAssessment.Exercises.Graph
{
    public static class TaxiCalls
    {
        public static int Solve(int[][] calls)
        {
            int maxChain = 0;

            for (int i = 0; i < calls.Length; i++) 
            {
                int count = 1;
                int current = i;

                Console.WriteLine($"\nStart chain at ride {i}");

                while (true)
                {
                    bool found = false;

                    for (int j = current + 1; j < calls.Length; j++)
                    {
                        int arrivalA = calls[current][1];
                        int departureB = calls[j][0];

                        int destinationA = calls[current][3];
                        int originB = calls[j][2];

                        bool locationOk = destinationA == originB;
                        int waitTime = departureB - arrivalA;
                        bool timeOk = waitTime >= 0 && waitTime <= 10;

                        if (locationOk && timeOk)
                        {
                            Console.WriteLine($"  {current} -> {j}");
                            current = j;
                            count++;
                            found = true;
                            break; // tomo el primero y sigo
                        }
                    }

                    if (!found)
                        break;
                }

                Console.WriteLine($"Chain length: {count}");

                if (count > maxChain)
                    maxChain = count;
            }

            return maxChain;
        }

    }
}