public static class Jewels
{
    public static int NumJewelsInStones(string jewels, string stones)
    {
        HashSet<char> jewelsSet = [.. jewels];
        int count = 0;
        foreach (char stone in stones)
        {
            if (jewelsSet.Contains(stone))
            {
                count += 1;
            }
        }

        return count;
    }

    public static int NumJewelsInStones2(string jewels, string stones)
    {
        int count = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            foreach (char jewel in jewels)
            {
                if (stones[i] == jewel)
                {
                    count += 1;
                }
            }
        }

        return count;
    }
}
