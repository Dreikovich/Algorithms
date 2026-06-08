public static class LongestConsecutive
{
    // 70 ms,beats 41.52%
    // memory 66.99, beats 95.55%
    public static int FindLongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int longest = 1;
        int currentStreak = 1;

        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] + 1)
            {
                currentStreak++;
                continue;
            }
            else if (nums[i] == nums[i - 1])
            {
                continue;
            }
            else
            {
                longest = Math.Max(longest, currentStreak);
                currentStreak = 1;
            }
        }

        return Math.Max(longest, currentStreak);
    }
}
