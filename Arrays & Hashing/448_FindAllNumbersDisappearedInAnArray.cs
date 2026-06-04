public static class FindDisappeared
{
    // 3 ms, beats 94.95%
    //memory75.70, beats 33.8
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> result = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int number = Math.Abs(nums[i]);
            int targetIndex = number - 1;
            if (nums[targetIndex] > 0)
            {
                nums[targetIndex] = -nums[targetIndex];
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }

        return result;
    }

    //14 ms beats44.79%
    //memory 71.59 beats 74,44%
    public static IList<int> FindDisappearedNumbers2(int[] nums)
    {
        List<int> result = [];
        HashSet<int> unique = [.. nums];

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!unique.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
