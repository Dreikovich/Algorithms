public static class FindDisappeared
{
    public static IList<int> FindDisappearedNumbers(int[] nums)
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
