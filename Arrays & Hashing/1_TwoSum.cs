public static class TwoSumTask
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i += 1)
        {
            for (int j = i + 1; j < nums.Length; j += 1)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return [];
    }
}
