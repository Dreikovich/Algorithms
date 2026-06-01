namespace algorithms.Arrays___Hashing;

public static class Fucis {
    //Frequency map , 2ms 
    public static int FirstUniqChar(string s)
    {
        int[] chars = new int [26];
        foreach (var c in  s)
        {
            chars[c - 'a'] += 1;
        }
        for (int i = 0; i < s.Length; i += 1)
        {
            if (chars[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
    
    ///Frequency map , 4ms, LINQ 
    public static int FirstUniqChar2(string s) {
        int[] chars = new int[26];
        foreach (var c in  s)
        {
            chars[c - 'a'] += 1;
        }

        return s.IndexOf(s.FirstOrDefault(c => chars[c-'a']==1));
    }
    
    
    // so so
    public static int FirstUniqChar3(string s)
    {
        Dictionary<char, int> dict = [];
        foreach (var c in s)
        {
            if (!dict.ContainsKey(c))
            {
                dict[c] = 1;
            }
            else
            {
                dict[c] += 1;
            }
        }

        foreach (var kvp in dict)
        {
            if (kvp.Value == 1)
            {
                return s.IndexOf(kvp.Key);
            }
        }

        return -1;
    }
}