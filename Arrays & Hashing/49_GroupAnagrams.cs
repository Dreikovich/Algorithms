using System.Threading.Channels;

public class GroupAnagrams
{
    // 19 ms, beats 81.82%
    public static IList<IList<string>> Group(string[] strs)
    {
        Dictionary<string, List<string>> dict = [];
        IList<IList<string>> result = [];

        foreach (var word in strs)
        {
            int[] AsciiWord = new int[26];
            for (int i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';
                AsciiWord[index]++;
            }

            var passport = string.Join("-", AsciiWord);

            if (!dict.ContainsKey(passport))
            {
                dict[passport] = [];
            }
            dict[passport].Add(word);
        }

        return [.. dict.Values];
    }

    //22 ms
    public static IList<IList<string>> Group2(string[] strs)
    {
        Dictionary<string, List<string>> dict = [];
        IList<IList<string>> result = [];

        foreach (var word in strs)
        {
            var charArray = word.ToCharArray();
            Array.Sort(charArray);
            var sortedWord = new string(charArray);

            //bad performance because of LINQ, 44 ms with this linq
            // var sortedWord = string.Concat(word.OrderBy(c => c));

            if (!dict.ContainsKey(sortedWord))
            {
                dict[sortedWord] = [];
            }
            dict[sortedWord].Add(word);
        }

        return [.. dict.Values];
    }
}

//eat:aet -    a1e1t1
//eatt: aett - a1e1t2
//tea:aet
//tan: ant
