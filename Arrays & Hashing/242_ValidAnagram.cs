public class ValidAnagram
{
    //best solution 0ms
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        int[] counts = new int[26];

        foreach (var l in s)
        {
            counts[l - 'a'] += 1;
        }

        foreach (var l in t)
        {
            var iAscii = l - 'a';
            counts[iAscii] -= 1;
            if (counts[iAscii] < 0)
            {
                return false;
            }
        }

        return true;
    }

    // 1ms, Array.TrueFor not needed
    public bool IsAnagram2(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        int[] counts = new int[26];

        foreach (var l in s)
        {
            counts[l - 'a'] += 1;
        }

        foreach (var l in t)
        {
            var iAscii = l - 'a';
            counts[iAscii] -= 1;
            if (counts[iAscii] < 0)
            {
                return false;
            }
        }

        return Array.TrueForAll<int>(counts, x => x == 0);
    }

    //bad solution
    public bool IsAnagram3(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dict1 = ConvertStringToDict(s);
        Dictionary<char, int> dict2 = ConvertStringToDict(t);

        if (dict1.Count != dict2.Count)
            return false;

        foreach (var kvp in dict1)
        {
            if (!dict2.TryGetValue(kvp.Key, out int value) || value != kvp.Value)
            {
                return false;
            }
        }
        return true;
    }

    private Dictionary<char, int> ConvertStringToDict(string s)
    {
        Dictionary<char, int> dict = [];
        foreach (char l in s)
        {
            if (dict.ContainsKey(l))
            {
                dict[l] += 1;
            }
            else
            {
                dict[l] = 1;
            }
        }
        return dict;
    }
}
