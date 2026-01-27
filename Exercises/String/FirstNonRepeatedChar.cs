using System.Collections.Generic;

namespace CodingAssessment.Exercises.Strings
{
    public static class FirstNonRepeatedChar
    {
        public static int Solve(string word)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (!map.ContainsKey(c))
                {
                    map[c] = 1;
                }
                else
                {
                    map[c]++;
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (map[word[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
