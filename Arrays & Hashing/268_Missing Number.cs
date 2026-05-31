public class MissingNumber
{
    //xor rule
    //[9, 6, 4, 2, 3, 5, 7, 0, 1]
    public static int FindMissingNumber(int[] nums)
    {
        int missingNumber = nums.Length;

        for (int i = 0; i < nums.Length; i += 1)
        {
            missingNumber ^= i ^ nums[i];
        }

        return missingNumber;
    }

    //bad
    public static int FindMissingNumber2(int[] nums)
    {
        nums.Sort();
        if (nums[0] != 0)
        {
            return 0;
        }

        int previous = nums[0];
        for (int i = 1; i < nums.Length; i += 1)
        {
            if (nums[i] - 1 != previous)
            {
                return nums[i] - 1;
            }
            previous = nums[i];
        }

        return nums[^1] + 1;
    }
}
