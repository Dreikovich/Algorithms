public class SOSA
{
    //1 ms , beast 100%
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];

        int left = 0;
        int right = nums.Length - 1;
        int writeIdx = nums.Length - 1;

        while (left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];

            if (leftSquare < rightSquare)
            {
                result[writeIdx] = rightSquare;
                right--;
            }
            else
            {
                result[writeIdx] = leftSquare;
                left++;
            }
            writeIdx--;
        }
        return result;
    }

    //6 ms, beast 33%
    public int[] SortedSquares2(int[] nums)
    {
        int[] result = new int[nums.Length];

        int left = 0;
        int right = nums.Length - 1;
        int writeIdx = nums.Length - 1;

        while (left <= right)
        {
            if (Math.Pow(nums[left], 2) < Math.Pow(nums[right], 2))
            {
                result[writeIdx] = (int)Math.Pow(nums[right], 2);
                right--;
            }
            else
            {
                result[writeIdx] = (int)Math.Pow(nums[left], 2);
                left++;
            }
            writeIdx--;
        }
        return result;
    }
}
