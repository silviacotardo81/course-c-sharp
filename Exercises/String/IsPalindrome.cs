using System.Text;

namespace CodingAssessment.Exercises.Strings
{
    public static class IsPalindrome
    {
        public static bool Solve(string word)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            string reverse = sb.ToString();
            return word == reverse;
        }
    }
}
