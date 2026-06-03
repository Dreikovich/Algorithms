using System.Buffers;

public static class RansomNote
{
    //magazine = "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"
    //  ransomNote = "aa"
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> dict = [];

        foreach (char c in magazine)
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

        foreach (char c in ransomNote)
        {
            if (dict.ContainsKey(c) && dict[c] > 0)
            {
                dict[c] -= 1;
                continue;
            }
            return false;
        }
        return true;
    }
}
