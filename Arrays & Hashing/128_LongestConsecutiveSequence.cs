public static class LongestConsecutive
{
    //22 ms, beats 68.10%
    public static int FindLongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>([.. nums]);
        int longest = 0;
        foreach (var num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;
                while (set.Contains(currentNum + 1))
                {
                    currentStreak++;
                    currentNum++;
                }
                longest = Math.Max(currentStreak, longest);
            }
        }
        return longest;
    }

    // 70 ms,beats 41.52%
    // memory 66.99, beats 95.55%
    public static int FindLongestConsecutive2(int[] nums)
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
