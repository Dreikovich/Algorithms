public class ContainerWithMostWater
{
    //1 ms, beats 99,62%
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int h = Math.Min(height[left], height[right]);

            int area = width * h;
            if (area > maxArea)
            {
                maxArea = area;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
