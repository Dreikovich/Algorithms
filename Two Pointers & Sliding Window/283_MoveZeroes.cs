public static class Zeroes
{
    // 1ms, beats 96.77%
    public static void MoveZeroes(int[] nums)
    {
        int slow = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[slow] = nums[i];
                slow++;
            }
        }

        while (slow < nums.Length)
        {
            nums[slow] = 0;
            slow++;
        }
    }
}
