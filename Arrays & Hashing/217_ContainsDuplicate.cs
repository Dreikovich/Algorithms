public static class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> distinct = [];

        for (int i = 0; i < nums.Length; i++)
        {
            distinct.Add(nums[i]);
        }

        if (distinct.Count != nums.Length)
        {
            return true;
        }

        return false;
    }
}
