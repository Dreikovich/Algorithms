public static class TopKFrequent
{
    //runtime 20 ms; beats only 9,34%
    //memory 50,86; beats 99,89%
    public static int[] FindTopKFrequent(int[] nums, int k)
    {
        Array.Sort(nums);
        List<(int Number, int Count)> frequencies = new List<(int Number, int Count)>();
        List<int> result = [];

        int currentNumber = nums[0];
        int currentCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (currentNumber == nums[i])
            {
                currentCount += 1;
            }
            else
            {
                frequencies.Add((currentNumber, currentCount));
                currentNumber = nums[i];
                currentCount = 1;
            }
        }

        frequencies.Add((currentNumber, currentCount));

        frequencies.Sort((a, b) => b.Count.CompareTo(a.Count));

        for (int i = 0; i < k; i++)
        {
            result.Add(frequencies[i].Number);
        }

        return [.. result];
    }
}
