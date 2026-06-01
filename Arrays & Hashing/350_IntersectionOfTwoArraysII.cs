namespace algorithms.Arrays___Hashing;

public static class IntersectionOfTwoArrays {
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dict = [];
        List<int> elements = [];

        foreach (var num in nums1)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
            {
                dict[num] += 1;
            }
        }

        foreach (var num in nums2)
        {
            if (dict.ContainsKey(num) && dict[num] > 0)
            {
                elements.Add(num);
                dict[num] -= 1;
            }
            
        }

        return elements.ToArray();
    }
    
    // 1 ms, slow memory
    public static int[] Intersect01(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dict = [];
        Dictionary<int, int> dict2 = [];
        int [] elements = new int[Math.Min(nums1.Length, nums2.Length)];
        int index = 0;

        dict.FillDictionary(nums1);
        dict2.FillDictionary(nums2);

        foreach (var kvp in dict)
        {
            if (dict2.ContainsKey(kvp.Key))
            {
                var minimalOccursNumber = Math.Min(kvp.Value, dict2[kvp.Key]);
                for (int j = 0; j < minimalOccursNumber; j += 1)
                {
                    elements[index] = kvp.Key;
                    index += 1;
                }
            }
        }

        int[] result = new int[index];
        // cutting zeroes to adjust correct array lenght 
        for (int i = 0; i < index; i += 1)
        {
            result[i] = elements[i];
        }

        return result;
        // return elements[..i];;
    }
    //[2,2]  [2,1,1] -> [2]
    //[2,2] [2,2,1] -> [2,2]
    // [3,3,2,2] -> [3,1,2] -> [3,2]
    // 1 ms, 47 MB memory
    public static int[] Intersect2(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dict = [];
        Dictionary<int, int> dict2 = [];
        List<int> elements = [];

        dict.FillDictionary(nums1);
        dict2.FillDictionary(nums2);

        foreach (var kvp in dict)
        {
            if (dict2.ContainsKey(kvp.Key))
            {
                var minimalOccursNumber = Math.Min(kvp.Value, dict2[kvp.Key]);
                for (int i = 0; i < minimalOccursNumber; i += 1)
                {
                    elements.Add(kvp.Key);
                }
            }
        }

        return elements.ToArray();
    }

    private static Dictionary<int, int> FillDictionary(this Dictionary<int, int> dict, int[] nums)
    {
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
            {
                dict[num] += 1;
            }
        }

        return dict;
    }
}