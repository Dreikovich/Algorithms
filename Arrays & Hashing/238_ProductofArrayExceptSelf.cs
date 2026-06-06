public static class ProductExceptSelf
{
    //[2,3,5,7]
    // 5
    // 2*3*7
    // left [1,2,6,30]
    //right [105,35,7,1]

    //1ms, beats 100%;
    //memory 63.9, beats 51.05%
    public static int[] CountProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        int rightAccumulator = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            var right = nums[i + 1] * rightAccumulator;
            result[i] *= right;
            rightAccumulator = right;
        }
        return result;
    }

    //2 ms
    public static int[] CountProductExceptSelf01(int[] nums)
    {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] result = new int[nums.Length];

        int multiply = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                left[i] = 1;
            }
            else
            {
                multiply *= nums[i - 1];
                left[i] = multiply;
            }
        }

        multiply = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i == nums.Length - 1)
            {
                right[i] = 1;
            }
            else
            {
                multiply *= nums[i + 1];
                right[i] = multiply;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = left[i] * right[i];
        }
        return result;
    }

    // time limit bad solition O(N^2)
    public static int[] CountProductExceptSelf2(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int multiply = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    multiply *= nums[j];
                }
                if (j == nums.Length - 1)
                {
                    result[i] = multiply;
                }
            }
        }

        return result;
    }
}
