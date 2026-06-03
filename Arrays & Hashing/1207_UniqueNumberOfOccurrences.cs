public static class UNO
{
    //[1,2,2,1,1,3] //1:3, 2:2; 3:1
    public static bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = [];
        foreach (int num in arr)
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

        HashSet<int> set = [];

        foreach (KeyValuePair<int, int> kvp in dict)
        {
            if (set.Add(kvp.Value) == false)
            {
                return false;
            }
        }

        return set.Count == dict.Count;
    }
}
