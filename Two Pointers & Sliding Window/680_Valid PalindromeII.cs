using System.Security.Principal;

public class SolutionPalindromeII
{
    //abcbea
    //b != e
    // 3 ms, beatd 70,77%s
    public bool ValidPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        return IsPalindrome(s, left, right, false);
    }

    private bool IsPalindrome(string s, int left, int right, bool deleted)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                if (deleted)
                {
                    return false;
                }
                return IsPalindrome(s, left + 1, right, true) || IsPalindrome(s, left, right - 1, true);
            }
            left++;
            right--;
        }
        return true;
    }
}