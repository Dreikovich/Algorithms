using System.Globalization;

public static class MajorityElement
{
    // Boyer-Moore
    //[2, 2, 1, 1, 1, 2, 2]

    public static int FindMajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (num == candidate) ? 1 : -1;
        }
        return candidate;
    }

    //O(N)
    public static int FindMajorityElement2(int[] nums)
    {
        Dictionary<int, int> dict = [];
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 0;
            }

            dict[num] += 1;

            if (dict[num] > nums.Length / 2)
            {
                return num;
            }
        }

        return 0;
    }

    //bad
    public static int FindMajorityElement3(int[] nums)
    {
        int numberOccurs = 0;
        HashSet<int> values = [];

        foreach (var num in nums)
        {
            values.Add(num);
        }
        foreach (var number in values)
        {
            for (int j = 0; j < nums.Length; j += 1)
            {
                if (nums[j] == number)
                {
                    numberOccurs += 1;
                }
            }
            if (numberOccurs > (nums.Length / 2))
            {
                return number;
            }
            numberOccurs = 0;
        }

        return 0;
    }
}
