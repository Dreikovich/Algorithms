using System.Text;

namespace algorithms.Arrays___Hashing;

public static class WordPattern {
    // TODO rewrite for 2 dictionary strategy or hashSet to exclude ContainsValue
    //1 ms, memory beats 70,69%
    public static bool CheckWordPattern(string pattern, string s)
    {
        Dictionary<char, string> dict = [];
        List<string> words = s.Split(' ').ToList();
        if (words.Count != pattern.Length)
        {
            return false;
        }

        for (int i = 0; i < words.Count; i += 1)
        {
            if (!dict.ContainsKey(pattern[i]))
            {
                if (dict.ContainsValue(words[i]))
                {
                    return false;
                }
                dict[pattern[i]] = words[i];
            }
            else
            {
                if (dict[pattern[i]]!=words[i])
                {
                    return false;
                }
            }
        }

        return true;
    }

    //complex, but 1ms , beats 96,28% . Memory beats 20,58%
    public static bool CheckWordPattern2(string pattern, string s)
    {
        Dictionary<char, string> dict = [];
        List<string> words = s.Split(' ').ToList();
        if (words.Count != pattern.Length)
        {
            return false;
        }
        
        foreach (var letter in pattern)
        {
            if (!dict.ContainsKey(letter))
            {
                var first = words[0];
                if (dict.ContainsValue(first))
                {
                    return false;
                }
                dict[letter] = first;
                words.RemoveAt(0);
                
            }
            else
            {
                dict.TryGetValue(letter, out var value);
                int index = words.FindIndex(word=> word == value);
                if (index != -1)
                {
                    words.RemoveAt(index);
                }
            }
        }

        if (words.Count != 0)
        {
            return false;
        }
        
        StringBuilder recreated = new StringBuilder();
        foreach (var letter in pattern)
        {
            if (dict.TryGetValue(letter, out var value))
            {
                recreated.Append(value);
            }
            
        }

        string sWithoutSpace = s.Replace(" ", "");
        return recreated.ToString().Equals(sWithoutSpace);
    }
}