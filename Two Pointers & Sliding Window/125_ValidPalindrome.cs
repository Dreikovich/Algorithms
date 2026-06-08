using System.Text;

public static class Palindrom
{
    //TODO optimize to beat more
    //22 ms, beats 22%
    public static bool IsPalindrome(string s)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                stringBuilder.Append(char.ToLower(c));
            }
        }

        string result = stringBuilder.ToString();

        int left = 0;
        int right = result.Length - 1;

        while (left < right)
        {
            if (result[left] != result[right])
            {
                return false;
            }

            left++;
            right--;
        }
        return true;
    }
}
