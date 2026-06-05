public static class TopKFrequent
{
    //8 ms, beats 91.98%
    //memory 53.04, beats 69,87%
    public static int[] FindTopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> counts = [];
        List<int> result = new List<int>();

        foreach (var num in nums)
        {
            if (!counts.ContainsKey(num))
            {
                counts[num] = 0;
            }
            counts[num]++;
        }

        List<int>[] sorted = new List<int>[nums.Length + 1];
        foreach (var kvp in counts)
        {
            var index = kvp.Value;
            if (sorted[index] == null)
            {
                sorted[index] = [];
            }
            sorted[index].Add(kvp.Key);
        }

        for (int i = sorted.Length - 1; i >= 0; i--)
        {
            if (sorted[i] != null)
            {
                foreach (var value in sorted[i])
                {
                    if (result.Count == k)
                    {
                        return [.. result];
                    }
                    result.Add(value);
                }
            }
        }
        return [.. result];
    }

    //runtime 20 ms; beats only 9,34%
    //memory 50,86; beats 99,89%
    public static int[] FindTopKFrequent2(int[] nums, int k)
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
