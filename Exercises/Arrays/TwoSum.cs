namespace CodingAssessment.Exercises.Arrays
{
    public static class TwoSum
    {
        public static bool Solve(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return true;
                }
            }
            return false;
        }
    }
}
