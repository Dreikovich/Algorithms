public static class TST
{
    // 0 ms, beats 100%
    // beeter approach generally
    public static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return [left + 1, right + 1];
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return [];
    }

    // 0 ms, beats 100%
    public static int[] TwoSum2(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (numbers[left] + numbers[right] != target)
        {
            if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
        }
        return [left + 1, right + 1];
    }
}
