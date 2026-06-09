namespace algorithms.Two_Pointers___Sliding_Window;

public class Str
{
    // 0 ms, beats 100%
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            //Tuple Swap
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}

//Tuple Swap
//(s[left], s[right]) = (s[right], s[left]);
// it is the same as code below (with buffer/temp)
// char buffer = s[left];
// s[left] = s[right];
// s[right] = buffer;
